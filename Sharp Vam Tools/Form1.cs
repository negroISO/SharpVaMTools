using Microsoft.WindowsAPICodePack.Dialogs;
using SharpCompress.Archives;
using SharpCompress.Common;
using SharpCompress.Readers;
using SharpCompress.Writers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Windows.Shapes;
using Color = System.Drawing.Color;
using Control = System.Windows.Forms.Control;
using File = System.IO.File;
using FileSystem = Microsoft.VisualBasic.FileIO.FileSystem;
using SearchOption = System.IO.SearchOption;

namespace Sharp_VaM_Tools
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static Encoding encoding = Encoding.UTF8;
        public Form1()
        {

            InitializeComponent();
            this.Icon = Sharp_VaM_Tools.Properties.Resources.icon;
            this.StyleManager = metroStyleManager1;
            Settings_Theme_ComboBX.SelectedItem = Settings_Theme_ComboBX.Items[0];
            Settings_ThemeStyle_ComboBX.SelectedItem = Settings_ThemeStyle_ComboBX.Items[13];
            if (Graphics.FromHwnd(Handle).DpiX > 96)
            {
                //MessageBox.Show("Your DPI: " + Graphics.FromHwnd(Handle).DpiX.ToString());
                Settings_FontSize_Txtbx.Text = "6";
                Settings_SetFontSize_BTN_Click(Settings_SetFontSize_BTN, EventArgs.Empty);
            }
            if (!System.IO.Directory.Exists(@"C:\Windows\temp\SharpVamTools"))
            {
                try
                {
                    System.IO.Directory.CreateDirectory(@"C:\Windows\temp\SharpVamTools");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

            if (!System.IO.File.Exists("_Error_log.txt"))
            {
                try
                {
                    System.IO.File.Create("_Error_log.txt");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }

            if (!System.IO.File.Exists("_Settings.txt"))
            {
                try
                {
                    System.IO.File.Create("_Settings.txt");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                try
                {
                    string text = System.IO.File.ReadAllText("_Settings.txt", encoding);
                    int ex_creators_index_end = text.IndexOf("[/Exceptional Creators]");
                    int ex_creators_index_start = text.IndexOf("[Exceptional Creators]");
                    if (ex_creators_index_end != -1)
                    {
                        Settings_ExCreators_Txtbx.Text = text.Substring(ex_creators_index_start, ex_creators_index_end - ex_creators_index_start).Replace("[Exceptional Creators]", "");
                        Settings_ExCreators_Txtbx.Text = Regex.Replace(Settings_ExCreators_Txtbx.Text, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd();
                        Settings_ExCreators_Txtbx.Lines = Settings_ExCreators_Txtbx.Lines.OrderBy(l => l).ToArray();
                    }

                    int Vars_locations_index_start = text.IndexOf("[Saved Locations]");
                    int Vars_locations_index_end = text.IndexOf("[/Saved Locations]");
                    if (Vars_locations_index_end != -1)
                    {
                        SearchMyFolders_VarsLocations_Txtbx.Text = text.Substring(Vars_locations_index_start, Vars_locations_index_end - Vars_locations_index_start).Replace("[Saved Locations]", "");
                        SearchMyFolders_VarsLocations_Txtbx.Text = Regex.Replace(SearchMyFolders_VarsLocations_Txtbx.Text, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd();
                        //Vars_locations.Lines = Vars_locations.Lines.OrderBy(l => l).ToArray();
                        SearchInsideVars_VarPaths_Txtbx.Text = SearchMyFolders_VarsLocations_Txtbx.Text;


                        string[] Vars_locations_split = SearchMyFolders_VarsLocations_Txtbx.Text.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                        foreach (string line in Vars_locations_split)
                        {
                            if (!line.Contains("JayJayWon\\BrowserAssist\\OffloadedVARs"))
                            {
                                MissingFromF95_CreatorPaths_Txtbx.AppendText(line + "\\lv" + Environment.NewLine);
                                MISC_Paths_Txtbx.AppendText(line + Environment.NewLine);
                            }
                        }
                    }

                    int pixeldrain_api_start = text.IndexOf("[pixeldrain_api]");
                    int pixeldrain_api_end = text.IndexOf("[/pixeldrain_api]");
                    if (pixeldrain_api_end != -1)
                    {
                        Settings_PixeldrainApi_Txtbx.Text = text.Substring(pixeldrain_api_start, pixeldrain_api_end - pixeldrain_api_start).Replace("[pixeldrain_api]", "");
                    }

                    int Encoding_start = text.IndexOf("[Encoding]");
                    int Encoding_end = text.IndexOf("[/Encoding]");
                    if (Encoding_end != -1)
                    {
                        string encoding_txt = text.Substring(Encoding_start, Encoding_end - Encoding_start).Replace("[Encoding]", "");
                        encoding = Encoding.GetEncoding(encoding_txt.Trim());
                        if (encoding_txt.Trim() == "UTF-8") { Settings_UTF8_Chkbx.Checked = true; Settings_GB2312_Chkbx.Checked = false; }
                        if (encoding_txt.Trim() == "GB2312") { Settings_UTF8_Chkbx.Checked = false; Settings_GB2312_Chkbx.Checked = true; }
                    }

                    int Appearance_Start = text.IndexOf("[Appearance]");
                    int Appearance_End = text.IndexOf("[/Appearance]");
                    if (Appearance_End != -1)
                    {
                        string[] lines = text.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                        string Theme = string.Empty; string Style = string.Empty;
                        foreach (string line in lines)
                        {
                            if (line.StartsWith("Theme="))
                            {
                                Theme = line.Replace("Theme=", "");
                                foreach (var item in Settings_Theme_ComboBX.Items)
                                {
                                    if (item.ToString() == Theme)
                                    {
                                        Settings_Theme_ComboBX.SelectedIndex = Settings_Theme_ComboBX.FindStringExact(item.ToString());
                                        Settings_Theme_ComboBX_SelectedIndexChanged(Settings_Theme_ComboBX, EventArgs.Empty);
                                        break;
                                    }
                                }
                            }
                            if (line.StartsWith("Style="))
                            {
                                Style = line.Replace("Style=", "");
                                foreach (var item in Settings_ThemeStyle_ComboBX.Items)
                                {
                                    if (item.ToString() == Style)
                                    {
                                        Settings_ThemeStyle_ComboBX.SelectedIndex = Settings_ThemeStyle_ComboBX.FindStringExact(item.ToString());
                                        Settings_ThemeStyle_ComboBX_SelectedIndexChanged(Settings_ThemeStyle_ComboBX, EventArgs.Empty);
                                    }
                                }
                            }
                            if (line.StartsWith("FontSize="))
                            {
                                Settings_FontSize_Txtbx.Text = line.Replace("FontSize=", "");
                                Settings_SetFontSize_BTN_Click(Settings_SetFontSize_BTN, EventArgs.Empty);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "================================(" + DateTime.Now + ")" + "\r\n" + ex.Message);
                }

            }

            SearchInsideVars_db_Path_Txtbx.Text = Directory.GetCurrentDirectory() + "\\_Database.txt";
            SearchMyFolders_VarsList_Txtbx.AllowDrop = true;
            SearchMyFolders_VarsList_Txtbx.DragEnter += new DragEventHandler(SearchMyFolders_VarsList_Txtbx_DragEnter);
            SearchMyFolders_VarsList_Txtbx.DragDrop += new DragEventHandler(SearchMyFolders_VarsList_Txtbx_DragDrop);

            Security_VarsToScan_Txtbx.AllowDrop = true;
            Security_VarsToScan_Txtbx.DragEnter += new DragEventHandler(Security_VarsToScan_Txtbx_DragEnter);
            Security_VarsToScan_Txtbx.DragDrop += new DragEventHandler(Security_VarsToScan_Txtbx_DragDrop);

            SearchInsideVars_VarToCRCAndPaths_Txtbx.AllowDrop = true;
            SearchInsideVars_VarToCRCAndPaths_Txtbx.DragEnter += new DragEventHandler(var_to_crc_and_path_DragEnter);
            SearchInsideVars_VarToCRCAndPaths_Txtbx.DragDrop += new DragEventHandler(SearchInsideVars_VarToCRCAndPaths_Txtbx_DragDrop);

            Extract_Output_Txtbx.AllowDrop = true;
            Extract_Output_Txtbx.DragEnter += new DragEventHandler(Extract_Output_Txtbx_DragEnter);
            Extract_Output_Txtbx.DragDrop += new DragEventHandler(Extract_Output_Txtbx_DragDrop);

            AnalyzeVars_Result_Txtbx.AllowDrop = true;
            AnalyzeVars_Result_Txtbx.DragEnter += new DragEventHandler(AnalyzeVars_Result_Txtbx_DragEnter);
            AnalyzeVars_Result_Txtbx.DragDrop += new DragEventHandler(AnalyzeVars_Result_Txtbx_DragDrop);
            
        }

        /// ******** Search My Folders Start ******** ///  
        private void SearchMyFolders_Browse_BTN_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog fdialog = new CommonOpenFileDialog();
            fdialog.InitialDirectory = "C:\\";
            fdialog.IsFolderPicker = true;
            if (fdialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                List<string> lines = SearchMyFolders_VarsLocations_Txtbx.Text.ToLower().Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!lines.Contains(fdialog.FileName.ToLower()))
                {
                    if (!SearchMyFolders_VarsLocations_Txtbx.Text.EndsWith("\n") && SearchMyFolders_VarsLocations_Txtbx.Text.Length > 0) { SearchMyFolders_VarsLocations_Txtbx.AppendText(Environment.NewLine); }

                    SearchMyFolders_VarsLocations_Txtbx.AppendText(fdialog.FileName + Environment.NewLine);
                }
                Regex.Replace(SearchMyFolders_VarsLocations_Txtbx.Text, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd();
            }
        }

        private void SearchMyFolders_SaveLocations_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                string text = System.IO.File.ReadAllText("_Settings.txt", encoding);

                int Vars_locations_index_start = text.IndexOf("[Saved Locations]");
                int Vars_locations_index_end = text.IndexOf("[/Saved Locations]");

                if (Vars_locations_index_end != -1)
                {
                    string text_before = text.Substring(Vars_locations_index_start, Vars_locations_index_end - Vars_locations_index_start) + "[/Saved Locations]";
                    string text_after = "[Saved Locations]" + "\n" + SearchMyFolders_VarsLocations_Txtbx.Text + "\n" + "[/Saved Locations]";
                    System.IO.File.WriteAllText("_Settings.txt", text.Replace(text_before, text_after), encoding);

                }
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Save My Folders - Save Locations" + "\r\n" + ex.Message + Environment.NewLine);

            }

        }


        private CancellationTokenSource Cancel_Search_Missing_Vars = new CancellationTokenSource();
        private void SearchMyFolders_CM_datagridview1_CancelAll_Click(object sender, EventArgs e)
        {
            Cancel_Search_Missing_Vars.Cancel();
            Boss_Smoking_Gif.Visible = false;
            foreach (var process in Process.GetProcessesByName("aria2c"))
            {
                process.Kill();
            }
            string[] aria_tmp = Directory.GetDirectories(SearchMyFolders_VarsLocations_Txtbx.Lines[0].ToString(), "tmp_aria2c", SearchOption.AllDirectories);
            foreach (string tmp_folder in aria_tmp)
            {
                System.IO.Directory.Delete(tmp_folder, true);
            }
        }
        private bool Is_Hub_Checked;
        private async void SearchMyFolders_StartSearching_BTN_Click(object sender, EventArgs e)
        {
            if (SearchMyFolders_StartSearching_BTN.Text == "Searching..." || SearchMyFolders_VarsList_Txtbx.Text.Length == 0)
            {
                Cancel_Search_Missing_Vars.Cancel();
                return;
            }
            Is_Hub_Checked = false;
            Cancel_Search_Missing_Vars = new CancellationTokenSource();
            var cancellationToken = Cancel_Search_Missing_Vars.Token;


            SearchMyFolders_StartSearching_BTN.Text = "Searching...";

            try
            {
                Sharp_VaM_Tools.Extract_Var_Names.dependencies.Clear();
                SearchMyFolders_dataGridView1.Rows.Clear();

                if (!SearchMyFolders_VarsList_Txtbx.Text.Contains(".") || SearchMyFolders_ExtractVarNamesFirst_Chkbx.Checked || Regex.IsMatch(SearchMyFolders_VarsList_Txtbx.Text, "\\.(var|latest|min)"))
                {

                    Sharp_VaM_Tools.Extract_Var_Names.dependencies.Clear();
                    Sharp_VaM_Tools.Extract_Var_Names.Extract_Var_names(SearchMyFolders_VarsList_Txtbx.Text, Settings_ExCreators_Txtbx.Text);
                    SearchMyFolders_VarsList_Txtbx.Text = string.Empty;
                    if (Sharp_VaM_Tools.Extract_Var_Names.dependencies.Count() == 1 && Sharp_VaM_Tools.Extract_Var_Names.dependencies[0].Length == 0)
                    {
                        SearchMyFolders_StartSearching_BTN.Text = "Search";
                        MessageBox.Show("Couldn't extract any valid var name!");
                        return;
                    }
                    foreach (string file in Sharp_VaM_Tools.Extract_Var_Names.dependencies)
                    {
                        if (file.Length > 0) { SearchMyFolders_VarsList_Txtbx.AppendText(file + Environment.NewLine); }
                    }
                }

                string[] Vars_Locations_To_Search_In = SearchMyFolders_VarsLocations_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                string[] Vars_To_Search = SearchMyFolders_VarsList_Txtbx.Text.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string location in Vars_Locations_To_Search_In)
                {
                    if (!Directory.Exists(location))
                    {
                        MessageBox.Show("This var location doesn't exist, remove it from var locations box at the top: " + location);
                    }
                }

                foreach (string var in Vars_To_Search)
                {

                    List<string> list = new List<string>();

                    if (Regex.IsMatch(var, "\\..*?\\.[0-9]+"))
                    {
                        await Task.Run(() =>
                        {
                            foreach (string path in Vars_Locations_To_Search_In)
                            {
                                if (System.IO.Directory.Exists(path.Trim()))
                                {
                                    list.AddRange(Directory.GetFiles(path.Trim(), var.Trim() + ".*var", SearchOption.AllDirectories).ToList<string>());
                                }
                            }

                        }, Cancel_Search_Missing_Vars.Token);
                    }
                    else
                    {
                        Var_Latest_Version = string.Empty;
                        await Task.Run(() =>
                        {
                            Get_Latest_Version(var, Vars_Locations_To_Search_In);
                        }, Cancel_Search_Missing_Vars.Token);
                        if (Var_Latest_Version != string.Empty)
                        {
                            list.Add(Var_Latest_Version);
                        }
                    }
                    if (list.Count > 0)
                    {
                        foreach (string var_path in list)
                        {
                            if (Regex.IsMatch(var_path, "\\..*?\\.[0-9]+.var$")) { SearchMyFolders_dataGridView1.Rows.Add(var, "Found", var_path); }
                        }
                    }
                    else
                    {
                        SearchMyFolders_dataGridView1.Rows.Add(var, "[!] NOT Found", "[!] N/A");
                    }
                    SearchMyFolders_dataGridView1.FirstDisplayedScrollingRowIndex = SearchMyFolders_dataGridView1.Rows.Count - 1;
                }
                SearchMyFolders_dataGridView1.Sort(SearchMyFolders_dataGridView1.Columns["Result"], ListSortDirection.Ascending);
                Boss_Fine_PIC.Visible = true; Fine_PIC.Visible = true; hero.Visible = false;
                foreach (DataGridViewRow row in SearchMyFolders_dataGridView1.Rows)
                {
                    if (row.Cells[1].Value.ToString() == "[!] NOT Found")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        Boss_Fine_PIC.Visible = false; Fine_PIC.Visible = false; hero.Visible = false;
                    }

                }

                SearchMyFolders_dataGridView1.FirstDisplayedScrollingRowIndex = 0;
                if (SearchMyFolders_AutoDownload_Chkbx.Checked)
                {
                    SearchMyFolders_CM_datagridview1_DownloadHub.PerformClick();
                }
            }
            catch (OperationCanceledException) { }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Search My Folders - Start Searching" + "\r\n" + ex.Message + Environment.NewLine);
            }
            SearchMyFolders_StartSearching_BTN.Text = "Search";
        }

        private void SearchMyFolders_ExtractOnly_metajson_Chkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (SearchMyFolders_ExtractOnly_metajson_Chkbx.Checked) { SearchMyFolders_Ignore_metajson_Chkbx.Checked = false; }

        }

        private void SearchMyFolders_Ignore_metajson_Chkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (SearchMyFolders_Ignore_metajson_Chkbx.Checked) { SearchMyFolders_ExtractOnly_metajson_Chkbx.Checked = false; }

        }

        private void SearchMyFolders_Search_DataGridView_TextChanged(object sender, EventArgs e)
        {
            if (SearchMyFolders_dataGridView1.Rows.Count > 0)
            {
                SearchMyFolders_dataGridView1.MultiSelect = true;
                SearchMyFolders_dataGridView1.ClearSelection();
                foreach (DataGridViewRow row in SearchMyFolders_dataGridView1.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        if (row.Cells[i].Value != null && Regex.IsMatch(row.Cells[i].Value.ToString(), ".*" + SearchMyFolders_Search_DataGridView.Text + ".*", RegexOptions.IgnoreCase))
                        {
                            int rowIndex = row.Index;
                            SearchMyFolders_dataGridView1.Rows[rowIndex].Selected = true;
                        }
                    }

                }
                if (SearchMyFolders_dataGridView1.SelectedRows.Count > 0)
                {
                    SearchMyFolders_dataGridView1.FirstDisplayedScrollingRowIndex = SearchMyFolders_dataGridView1.SelectedRows[0].Index;
                }
            }

        }

        private void SearchMyFolders_CM_datagridview1_CopySelected_Click(object sender, EventArgs e)
        {
            if (SearchMyFolders_dataGridView1.Rows.Count > 0)
            {
                Clipboard.SetDataObject(SearchMyFolders_dataGridView1.GetClipboardContent());
            }
        }

        private async void SearchMyFolders_CM_datagridview1_SearchMissingVars_Click(object sender, EventArgs e)
        {
            Boss_Smoking_Gif.Visible = true;
            Is_Hub_Checked = true;
            await Check_hub();
            SearchMyFolders_dataGridView1.Sort(SearchMyFolders_dataGridView1.Columns["Path"], ListSortDirection.Ascending);
            foreach (DataGridViewRow row in SearchMyFolders_dataGridView1.Rows)
            {
                if (row.Cells[2].Value.ToString().StartsWith("https://"))
                {
                    SearchMyFolders_dataGridView1.Rows[row.Index].Selected = true;
                    SearchMyFolders_dataGridView1.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
            Boss_Smoking_Gif.Visible = false;
        }

        private async void SearchMyFolders_CM_datagridview1_DownloadHub_Click(object sender, EventArgs e)
        {
            Boss_Smoking_Gif.Visible = true;
            try
            {
                if (Is_Hub_Checked != true) { await Check_hub(); }

                Cancel_Search_Missing_Vars.Cancel();
                Cancel_Search_Missing_Vars = new CancellationTokenSource();
                var cancellationToken = Cancel_Search_Missing_Vars.Token;

                string downloads_folder = SearchMyFolders_VarsLocations_Txtbx.Lines.FirstOrDefault().Trim();
                if (!downloads_folder.EndsWith("\\")) { downloads_folder = downloads_folder + "\\"; }
                foreach (DataGridViewRow row in SearchMyFolders_dataGridView1.Rows)
                {
                    row.Selected = true;
                    if (row.Cells[2].Value.ToString().StartsWith("https://") && !cancellationToken.IsCancellationRequested)
                    {
                        string creator = row.Cells[1].Value.ToString().Substring(0, row.Cells[1].Value.ToString().IndexOf(".")).Trim();
                        string save_location = Regex.Replace(downloads_folder, "Addonpackages.*", string.Empty, RegexOptions.IgnoreCase);
                        if (Directory.Exists(save_location + "addonpackages\\")) { save_location = save_location + "addonpackages\\"; }
                        if (Directory.Exists(save_location + creator)) { save_location = save_location + creator + "\\"; }

                        try
                        {
                            await Download_Vars(row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString(), save_location);
                            if (System.IO.File.Exists(save_location + row.Cells[1].Value.ToString()))
                            {
                                //Check if downloaded var is not corrupted, empty, or only has meta.json
                                try
                                {
                                    int Entries = 0;
                                    var opts = new SharpCompress.Readers.ReaderOptions();
                                    opts.ArchiveEncoding.Default = encoding;
                                    using (Stream stream = System.IO.File.Open(save_location + row.Cells[1].Value.ToString(), FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                                    using (var archive = ReaderFactory.Open(stream, opts))
                                    {
                                        while (archive.MoveToNextEntry())
                                        {
                                            //var must have either custom or saves dirs and at least 1 file inside them
                                            if (Regex.IsMatch(archive.Entry.Key, @"(^custom/.*\.|^saves/.*\.)", RegexOptions.IgnoreCase))
                                            {
                                                Entries++;
                                            }
                                        }
                                    }
                                    if (Entries > 0)
                                    {
                                        row.Cells[2].Value = save_location + row.Cells[1].Value.ToString();

                                    }
                                    else
                                    {
                                        row.Cells[2].Value = "Error, downloaded var is fake, ¯\\_(ツ)_/¯, try skip Hub Check option or download again later!";
                                        row.DefaultCellStyle.BackColor = Color.Red;
                                        System.IO.File.Delete(save_location + row.Cells[1].Value.ToString());
                                        row.Cells[1].Value = "[!] NOT Found";
                                    }


                                }
                                catch
                                {
                                    row.Cells[2].Value = "Error, downloaded var is corrupted or empty ¯\\_(ツ)_/¯, try again!";
                                    row.DefaultCellStyle.BackColor = Color.Red;
                                    System.IO.File.Delete(save_location + row.Cells[1].Value.ToString());
                                    row.Cells[1].Value = "[!] NOT Found";
                                }


                            }
                            else
                            {
                                row.Cells[2].Value = "Error Downloading or Operation Canceled ¯\\_(ツ)_/¯";
                                row.Cells[1].Value = "[!] NOT Found";
                                row.DefaultCellStyle.BackColor = Color.Red;
                            }
                        }
                        catch (Exception ex) { row.Cells[2].Value = "Error: " + ex.Message; row.DefaultCellStyle.BackColor = Color.Red; }
                    }
                    row.Selected = false;
                }
            }
            catch (OperationCanceledException) { }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> " + "\r\n" + ex.Message + Environment.NewLine);
            }
            Boss_Smoking_Gif.Visible = false; Boss_Fine_PIC.Visible = true;
        }

        private void SearchMyFolders_CM_datagridview1_MalwareScan_Click(object sender, EventArgs e)
        {
            if (SearchMyFolders_dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewCell cell in SearchMyFolders_dataGridView1.SelectedCells)
                {
                    if (cell.Value.ToString().Length > 0)
                    {
                        int row_index = cell.RowIndex;
                        if (System.IO.File.Exists(SearchMyFolders_dataGridView1.Rows[row_index].Cells[2].Value.ToString()))
                        {
                            Security_VarsToScan_Txtbx.AppendText(SearchMyFolders_dataGridView1.Rows[row_index].Cells[2].Value.ToString() + Environment.NewLine);
                        }
                    }
                }
            }

        }

        //Using timer instead of System.Threading.Thread.Sleep() which locks UI
        private void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds; timer1.Enabled = true; timer1.Start();
            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
            };

            while (timer1.Enabled)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }
        private async void SearchMyFolders_CM_datagridview1_SearchTorrent_Click(object sender, EventArgs e)
        {
            Cancel_Search_Missing_Vars.Cancel();
            Cancel_Search_Missing_Vars = new CancellationTokenSource();
            var cancellationToken = Cancel_Search_Missing_Vars.Token;

            if (SearchMyFolders_dataGridView1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in SearchMyFolders_dataGridView1.Rows)
                {
                    try
                    {

                        if (row.Cells[1].Value.ToString().Contains("[!] NOT Found") && !cancellationToken.IsCancellationRequested)
                        {
                            bool found = false;
                            row.Selected = true;
                            string var_name = row.Cells[0].Value.ToString();

                            if (System.IO.Directory.Exists(System.IO.Directory.GetCurrentDirectory() + "\\Download_Links\\_Torrents"))
                            {
                                string[] torrents = Directory.GetFiles(System.IO.Directory.GetCurrentDirectory() + "\\Download_Links\\_Torrents", "*.torrent", SearchOption.AllDirectories);
                                string Found_in_Torrents = string.Empty;
                                foreach (string torrent in torrents)
                                {
                                    string output = string.Empty;
                                    await Task.Run(() =>
                                    {
                                        Process ariaTorrent = new Process();
                                        ariaTorrent.StartInfo.FileName = System.IO.Directory.GetCurrentDirectory() + "\\_Tools\\" + "aria2c.exe";
                                        ariaTorrent.StartInfo.Arguments = "--show-files " + "\"" + torrent + "\"";
                                        ariaTorrent.StartInfo.RedirectStandardOutput = true;
                                        ariaTorrent.StartInfo.CreateNoWindow = true;
                                        ariaTorrent.StartInfo.UseShellExecute = false;
                                        ariaTorrent.Start();
                                        while (!ariaTorrent.HasExited)
                                        {
                                            output = ariaTorrent.StandardOutput.ReadToEnd();
                                        }
                                        if (output.Contains(var_name))
                                        {
                                            Found_in_Torrents += System.IO.Path.GetFileName(torrent) + "   |   ";
                                            found = true;
                                        }
                                    });
                                }
                                if (found)
                                {
                                    row.Cells[2].Value = System.Web.HttpUtility.HtmlDecode(Found_in_Torrents);
                                    row.Cells[1].Value = "[+] Found in Torrents";
                                    row.DefaultCellStyle.BackColor = Color.Green;
                                }
                            }

                            if (found == false)
                            {
                                Uri uri = new Uri("https://en.btdig.com/search?order=0&q=" + "%22" + row.Cells[0].Value.ToString() + "%22");
                                var client = new WebClient();
                                client.Encoding = encoding;
                                var response = await client.DownloadStringTaskAsync(uri);
                                if (Regex.Matches(response, var_name).Count > 1 && !response.Contains("0 results found"))
                                {
                                    string magnets_string = string.Empty;
                                    Regex magnets = new Regex("magnet:.*announce");
                                    foreach (Match match in magnets.Matches(response))
                                    {
                                        magnets_string += match.Value + Environment.NewLine;
                                    }
                                    row.Cells[2].Value = System.Web.HttpUtility.HtmlDecode(magnets_string);
                                    row.Cells[1].Value = "[+] Found in Torrents";
                                    row.DefaultCellStyle.BackColor = Color.Green;
                                }
                                else
                                {
                                    row.Cells[1].Value = "[!] Not Found in Torrents";
                                }
                                wait(1611); //Cooling down otherwise we get 429 too many requests
                            }
                            row.Selected = false;
                        }
                    }
                    catch (OperationCanceledException) { }
                    catch (Exception ex)
                    {
                        if (ex.Message == "The remote server returned an error: (429) Too Many Requests.")
                        {
                            row.Cells[2].Value = "Couldn't search btdig.com, cloudflare blocking our request (429) ¯\\_(ツ)_/¯";
                        }
                        else
                        {
                            row.Cells[2].Value = ex.Message;
                        }
                        System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Search for Missing Vars (Torrent):" + "\r\n" + ex.Message + Environment.NewLine);
                    }
                }

                SearchMyFolders_dataGridView1.Sort(SearchMyFolders_dataGridView1.Columns["Result"], ListSortDirection.Ascending);

            }
        }

        private void SearchMyFolders_CM_datagridview1_SearchF95_Click(object sender, EventArgs e)
        {

            if (SearchMyFolders_dataGridView1.Rows.Count > 0 && SearchMyFolders_dataGridView1.CurrentCell.Value.ToString().Length > 0)
            {
                int row_index = SearchMyFolders_dataGridView1.CurrentCell.RowIndex;
                string f95_query = SearchMyFolders_dataGridView1.Rows[row_index].Cells[0].Value.ToString();
                System.Diagnostics.Process.Start("https://f95zone.to/search/?q=" + f95_query + "&t=post&c[nodes][0]=72&o=date&c[child_nodes]=1"); //Dev
            }

        }

        private void SearchMyFolders_CM_datagridview1_SaveResultcsv_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchMyFolders_dataGridView1.Rows.Count > 0)
                {
                    var SaveFileDialog = new SaveFileDialog();
                    SaveFileDialog.Filter = "csv File|*.csv";
                    if (SaveFileDialog.ShowDialog() != DialogResult.OK)
                        return;
                    using (TextWriter tw = new StreamWriter(SaveFileDialog.FileName, false, encoding))
                    {
                        tw.WriteLine("Var,Result,Path / URL");
                        for (int i = 0; i < SearchMyFolders_dataGridView1.Rows.Count - 1; i++)
                        {

                            for (int c = 0; c < SearchMyFolders_dataGridView1.Columns.Count; c++)
                            {
                                tw.Write($"{SearchMyFolders_dataGridView1.Rows[i].Cells[c].Value.ToString()}");

                                if (c != SearchMyFolders_dataGridView1.Columns.Count - 1)
                                {
                                    tw.Write(",");
                                }
                            }
                            tw.WriteLine();

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Save Result (.csv)" + "\r\n" + ex.Message + Environment.NewLine);
            }
        }

        private void SearchMyFolders_CM_datagridview1_SaveDownloadLinksTxt_Click(object sender, EventArgs e)
        {
            try
            {
                if (SearchMyFolders_dataGridView1.Rows.Count > 0)
                {
                    var SaveFileDialog = new SaveFileDialog();
                    SaveFileDialog.Filter = "txt File|*.txt";
                    if (SaveFileDialog.ShowDialog() != DialogResult.OK)
                        return;
                    using (TextWriter tw = new StreamWriter(SaveFileDialog.FileName, false, encoding))
                    {
                        foreach (DataGridViewRow row in SearchMyFolders_dataGridView1.Rows)
                        {
                            if (row.Cells[2].Value.ToString().StartsWith("https://"))
                            {
                                tw.Write(row.Cells[1].Value + Environment.NewLine + row.Cells[2].Value + Environment.NewLine + Environment.NewLine);
                            }

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Save Download Links (.txt)" + "\r\n" + ex.Message + Environment.NewLine);
            }
        }

        private void SearchMyFolders_CM_datagridview1_OpenVarLocation_Click(object sender, EventArgs e)
        {
            if (SearchMyFolders_dataGridView1.Rows.Count > 0)
            {
                int row_index = SearchMyFolders_dataGridView1.CurrentCell.RowIndex;
                string path = SearchMyFolders_dataGridView1.Rows[row_index].Cells[2].Value.ToString();
                if (System.IO.File.Exists(path))
                {
                    System.Diagnostics.Process.Start("C:\\Windows\\explorer.exe", "/select, \"" + path + "\"");
                }
                if (path.StartsWith("https://") || path.StartsWith("http://"))
                {
                    System.Diagnostics.Process.Start(path);
                }
                if (path.Contains(".torrent   |") && System.IO.Directory.Exists(Directory.GetCurrentDirectory() + "\\Download_Links\\_Torrents"))
                {
                    System.Diagnostics.Process.Start("C:\\Windows\\explorer.exe", Directory.GetCurrentDirectory() + "\\Download_Links\\_Torrents");
                }

            }
        }

        private void SearchMyFolders_CM_datagridview1_CopyVarsToPath_Click(object sender, EventArgs e)
        {

            if (SearchMyFolders_dataGridView1.Rows.Count > 0)
            {
                string errorlog = string.Empty;
                CommonOpenFileDialog fdialog = new CommonOpenFileDialog();
                fdialog.InitialDirectory = "C:\\";
                fdialog.IsFolderPicker = true;
                if (fdialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    foreach (DataGridViewCell cell in SearchMyFolders_dataGridView1.SelectedCells)
                    {
                        if (cell.Value.ToString().Length > 0)
                        {
                            int row_index = cell.RowIndex;
                            string var_path = SearchMyFolders_dataGridView1.Rows[row_index].Cells[2].Value.ToString();
                            string copy_path = fdialog.FileName + "\\" + System.IO.Path.GetFileName(var_path);
                            try
                            {
                                if (System.IO.File.Exists(var_path))
                                {
                                    if (System.IO.File.Exists(copy_path)) { System.IO.File.Delete(copy_path); }
                                    System.IO.File.Copy(var_path, copy_path);
                                }

                            }
                            catch (Exception ex)
                            {
                                errorlog += "Couldn't copy: " + var_path + " ===> " + ex.Message + Environment.NewLine;
                                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Copy Selected Vars to Different Location" + "\r\n" + var_path + " ===> " + ex.Message + Environment.NewLine);
                            }
                        }
                    }
                    if (errorlog != string.Empty)
                    {
                        MessageBox.Show(errorlog);
                    }
                    Cursor.Current = Cursors.Default;
                    System.Diagnostics.Process.Start("C:\\Windows\\explorer.exe", fdialog.FileName);
                }

            }
        }

        private async Task Check_hub()
        {
            Cancel_Search_Missing_Vars = new CancellationTokenSource();
            var cancellationToken = Cancel_Search_Missing_Vars.Token;

            try
            {

                foreach (DataGridViewRow row in SearchMyFolders_dataGridView1.Rows)
                {
                    row.Selected = true;
                    bool found = false;
                    if (row.Cells[1].Value.ToString().Contains("NOT Found") && !cancellationToken.IsCancellationRequested)
                    {
                        try
                        {
                            string var_name = row.Cells[0].Value.ToString();
                            if (!Regex.Match(var_name, @"(\.\d+$)").Success)
                            {
                                var_name = var_name + ".latest";
                            }
                            string creator = var_name.Substring(0, var_name.IndexOf(".")).Trim();

                            if (!SearchMyFolders_SkipHubCheck_Chkbx.Checked)
                            {
                                string json = "{\"source\":\"VaM\",\"action\":\"findPackages\",\"packages\":\"" + var_name + "\"}";
                                var client = new WebClient();
                                client.Encoding = encoding;
                                client.Headers.Add("Content-Type:application/json");
                                var response = await client.UploadStringTaskAsync(new Uri("https://hub.virtamate.com/citizenx/api.php"), json);
                                JavaScriptSerializer serializer = new JavaScriptSerializer();
                                dynamic fileid = serializer.Deserialize<object>(response);

                                //small fix for some vars that hub does not return null but a different version example: V2.___UniversalMorphCollection___.103
                                string VersionHubReturns = fileid["packages"][var_name]["filename"];
                                if (fileid["packages"][var_name]["downloadUrl"] != "null" && VersionHubReturns.ToLower().Contains(var_name.ToLower().Replace(".latest", string.Empty)))
                                {
                                    row.Cells[1].Value = fileid["packages"][var_name]["filename"];
                                    row.Cells[2].Value = fileid["packages"][var_name]["downloadUrl"];
                                    row.DefaultCellStyle.BackColor = Color.Green;
                                    found = true;
                                }
                            }

                            //if (fileid["packages"][var_name]["downloadUrl"] == "null")
                            if (System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory() + "\\Download_Links\\" + creator + ".txt") && found == false)
                            {
                                using (StreamReader reader = new StreamReader(System.IO.Directory.GetCurrentDirectory() + "\\Download_Links\\" + creator + ".txt"))
                                {
                                    //Order by descending version then search
                                    Dictionary<string, int> Numeric = new Dictionary<string, int>();
                                    string[] lines = reader.ReadToEnd().Split(new string[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
                                    foreach (string line in lines)
                                    {
                                        try
                                        {
                                            int Numeric_Line = Convert.ToInt32(Regex.Replace(line, @".*\..*?\.([0-9]+).var.*", "$1"));
                                            if (!Numeric.ContainsKey(line))
                                            {
                                                Numeric.Add(line, Numeric_Line);
                                            }
                                        }
                                        catch
                                        {
                                            //no valid var name
                                        }
                                    }
                                    Numeric = Numeric.OrderByDescending(k => k.Value).ToDictionary(k => k.Key, k => k.Value);
                                    foreach (KeyValuePair<string, int> Pair in Numeric)
                                    {
                                        if (Pair.Key.Contains(var_name.Replace(".latest", ".")))
                                        {
                                            row.Cells[1].Value = Pair.Key.Substring(0, Pair.Key.IndexOf(".var") + 4).Trim();
                                            row.Cells[2].Value = Regex.Replace(Pair.Key, @".*https:", "https:").Trim();
                                            row.DefaultCellStyle.BackColor = Color.Green;
                                            found = true;
                                            break;
                                        }
                                    }
                                }
                            }

                            if (System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory() + "\\Download_Links\\_MIXED_VARs.txt") && found == false)
                            {
                                using (StreamReader reader = new StreamReader(System.IO.Directory.GetCurrentDirectory() + "\\Download_Links\\_MIXED_VARs.txt"))
                                {
                                    string line;
                                    while ((line = reader.ReadLine()) != null)
                                    {
                                        if (line.Contains(var_name.Replace(".latest", ".")))
                                        {
                                            row.Cells[1].Value = line.Substring(0, line.IndexOf(".var") + 4).Trim();
                                            row.Cells[2].Value = Regex.Replace(line, @".*https:", "https:");
                                            row.DefaultCellStyle.BackColor = Color.Green;
                                            found = true;
                                            break;
                                        }
                                    }

                                }
                            }


                            if (found != true)
                            {
                                row.Cells[1].Value = "[!] NOT Found on Hub/Pixel";
                            }
                        }
                        catch (Exception ex)
                        {
                            row.Cells[2].Value = "[!] Error: " + ex.Message;
                        }
                    }

                    row.Selected = false;

                }
            }
            catch (OperationCanceledException) { }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Search for Missing Vars (Hub/Pixel)" + "\r\n" + ex.Message + Environment.NewLine);
            }

        }

        private async Task Download_Vars(string var_name, string Download_url, string Downloads_folder)
        {
            try
            {
                if (Download_url.StartsWith("https://hub.virtamate.com") || Download_url.Contains("internal_data/attachments"))
                {
                    using (var client2 = new WebClient())
                    {
                        client2.Headers.Add("Cookie", "vamhubconsent=yes");
                        await client2.DownloadFileTaskAsync(Download_url, Downloads_folder + var_name);
                    }
                }
                else
                {
                    if (!System.IO.Directory.Exists(Downloads_folder + "tmp_aria2c"))
                    {
                        System.IO.Directory.CreateDirectory(Downloads_folder + "tmp_aria2c");
                    }
                    if (System.IO.Directory.Exists(Downloads_folder + "tmp_aria2c"))
                    {
                        System.IO.Directory.Delete(Downloads_folder + "tmp_aria2c", true);
                        System.IO.Directory.CreateDirectory(Downloads_folder + "tmp_aria2c");
                    }

                    Download_url = Regex.Replace(Download_url, "pixeldrain.com/u", "pixeldrain.com/api/file", RegexOptions.IgnoreCase);

                    Process process = new Process();
                    process.StartInfo.FileName = System.IO.Directory.GetCurrentDirectory() + "\\_Tools\\" + "aria2c.exe";
                    process.StartInfo.Arguments = "--check-certificate=false -d " + "\"" + Downloads_folder + "tmp_aria2c" + "\"" + " \"" + Download_url + "\"";
                    if (System.IO.File.Exists(System.IO.Directory.GetCurrentDirectory() + "\\_Tools\\" + "cookies.txt"))
                    {
                        process.StartInfo.Arguments += " --load-cookies " + "\"" + System.IO.Directory.GetCurrentDirectory() + "\\_Tools\\" + "cookies.txt" + "\"";
                    }
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.Start();
                    while (!process.HasExited)
                        await Task.Delay(100);

                    if (File.Exists(Downloads_folder + "tmp_aria2c\\" + var_name))
                    {
                        File.Move(Downloads_folder + "tmp_aria2c\\" + var_name, Downloads_folder + var_name);
                        Directory.Delete(Downloads_folder + "tmp_aria2c\\", true);
                    }

                    else
                    {
                        try
                        {
                            List<string> archives = new List<string>();
                            archives.AddRange(Directory.GetFiles(Downloads_folder + "tmp_aria2c\\", "*.zip").ToList<string>());
                            archives.AddRange(Directory.GetFiles(Downloads_folder + "tmp_aria2c\\", "*.rar").ToList<string>());
                            archives.AddRange(Directory.GetFiles(Downloads_folder + "tmp_aria2c\\", "*.7z").ToList<string>());
                            if (archives.Count > 0)
                            {
                                foreach (string archive in archives)
                                {
                                    var opts = new SharpCompress.Readers.ReaderOptions();
                                    opts.ArchiveEncoding.Default = encoding;
                                    using (Stream stream = System.IO.File.OpenRead(archive))
                                    using (var reader = ReaderFactory.Open(stream, opts))
                                    {
                                        reader.WriteAllToDirectory(Downloads_folder + "tmp_aria2c\\");
                                    }
                                }

                                string[] vars = Directory.GetFiles(Downloads_folder + "tmp_aria2c\\", "*.var", SearchOption.AllDirectories);
                                foreach (string var in vars)
                                {
                                    if (var.EndsWith("\\" + var_name))
                                    {
                                        File.Move(var, Downloads_folder + var_name);
                                        Directory.Delete(Downloads_folder + "tmp_aria2c\\", true);
                                    }
                                }
                            }
                        }
                        catch { }
                    }
                    if (System.IO.Directory.Exists(Downloads_folder + "tmp_aria2c\\")) { Directory.Delete(Downloads_folder + "tmp_aria2c\\", true); }
                }
            }
            catch (OperationCanceledException) { }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Download Missing Vars" + "\r\n" + ex.Message + Environment.NewLine);
            }
        }

        private void SearchMyFolders_VarsList_Txtbx_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void SearchMyFolders_GlobalExtractVarNames(string file)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    var opts = new SharpCompress.Readers.ReaderOptions();
                    opts.ArchiveEncoding.Default = encoding;

                    if (file.ToLower().EndsWith(".var"))
                    {
                        //v1.7: Replaced ZipArchive -> ReaderFactory.Open, ZipArchive cannot recognized some Chinese Vars
                        using (Stream stream = System.IO.File.OpenRead(file))
                        using (var archive = ReaderFactory.Open(stream, opts))
                            while (archive.MoveToNextEntry())
                            {
                                if (SearchMyFolders_ExtractOnly_metajson_Chkbx.Checked)
                                {
                                    if (archive.Entry.Key.Equals("meta.json"))
                                    {
                                        using (var streamReader = new StreamReader(archive.OpenEntryStream()))
                                        {
                                            string content = streamReader.ReadToEnd();
                                            int index_start = content.IndexOf("\"dependencies\"");
                                            int index_end = content.Length;
                                            if (content.Contains("customOptions"))
                                            {
                                                index_end = content.IndexOf("\"customOptions\"");
                                            }
                                            Sharp_VaM_Tools.Extract_Var_Names.Extract_Var_names(content.Substring(index_start, index_end - index_start), Settings_ExCreators_Txtbx.Text);
                                        }
                                    }
                                }
                                else if (SearchMyFolders_Ignore_metajson_Chkbx.Checked)
                                {

                                    if (archive.Entry.Key == "/meta.json") { goto done; }
                                    if (archive.Entry.Key.ToLower().EndsWith(".json") || archive.Entry.Key.ToLower().EndsWith(".vap") || archive.Entry.Key.ToLower().EndsWith(".vaj") || archive.Entry.Key.ToLower().EndsWith(".clothingplugins"))
                                    {

                                        using (var streamReader = new StreamReader(archive.OpenEntryStream()))
                                        {
                                            Sharp_VaM_Tools.Extract_Var_Names.Extract_json(streamReader.ReadToEnd());
                                        }
                                    }
                                done:;

                                }
                            }
                    }
                    if (file.ToLower().EndsWith(".json") || file.ToLower().EndsWith(".vap") || file.ToLower().EndsWith(".vaj") || file.ToLower().EndsWith(".clothingplugins"))
                    {
                        string content = System.IO.File.ReadAllText(file, encoding);

                        //if it's meta.json parse it normally, if it's scene.json or .vap parse only lines with ":/"
                        if (file.ToLower().EndsWith("meta.json"))
                        {
                            int index_start = content.IndexOf("\"dependencies\"");
                            int index_end = content.Length;
                            if (content.Contains("customOptions"))
                            {
                                index_end = content.IndexOf("\"customOptions\"");
                            }

                            Sharp_VaM_Tools.Extract_Var_Names.Extract_Var_names(content.Substring(index_start, index_end - index_start), Settings_ExCreators_Txtbx.Text);
                        }
                        else { Sharp_VaM_Tools.Extract_Var_Names.Extract_json(content); }

                    }

                    if (file.ToLower().EndsWith(".txt"))
                    {
                        string content = System.IO.File.ReadAllText(file, encoding);
                        Sharp_VaM_Tools.Extract_Var_Names.Extract_Var_names(content, Settings_ExCreators_Txtbx.Text);
                    }

                    if ((file.ToLower().EndsWith(".zip")) | (file.ToLower().EndsWith(".rar")))
                    {
                        try
                        {
                            using (Stream stream = System.IO.File.OpenRead(file))
                            using (var reader = ReaderFactory.Open(stream, opts))
                            {
                                while (reader.MoveToNextEntry())
                                {
                                    if (!reader.Entry.IsDirectory && reader.Entry.Key.ToLower().EndsWith(".var"))
                                    {
                                        SearchMyFolders_VarsList_Txtbx.AppendText(reader.Entry.Key.Substring(reader.Entry.Key.LastIndexOf("/") + 1) + Environment.NewLine);
                                    }
                                }
                            }
                        }
                        catch (SharpCompress.Common.CryptographicException ex)
                        {

                            opts.Password = Microsoft.VisualBasic.Interaction.InputBox(ex.Message + " Enter password to continue.", "Password Required", "password");
                            using (Stream stream = System.IO.File.OpenRead(file))
                            using (var reader = ReaderFactory.Open(stream, opts))
                            {
                                while (reader.MoveToNextEntry())
                                {
                                    if ((!reader.Entry.IsDirectory) && (reader.Entry.Key.ToLower().EndsWith(".var")))
                                    {
                                        SearchMyFolders_VarsList_Txtbx.AppendText(reader.Entry.Key.Substring(reader.Entry.Key.LastIndexOf("/") + 1) + Environment.NewLine);
                                    }
                                }
                            }
                            opts.Password = null;
                        }

                    }

                    //7z does not support streaming
                    if (file.ToLower().EndsWith(".7z"))
                    {
                        try
                        {
                            using (var archive = ArchiveFactory.Open(file, opts))
                            {
                                foreach (SharpCompress.Common.Entry entry in archive.Entries)
                                {
                                    if (entry.Key.EndsWith(".var"))
                                    {
                                        SearchMyFolders_VarsList_Txtbx.AppendText(entry.Key + Environment.NewLine);
                                    }
                                }
                            }
                        }
                        catch (SharpCompress.Common.CryptographicException ex)
                        {
                            opts.Password = Microsoft.VisualBasic.Interaction.InputBox(ex.Message + " Enter password to continue.", "Password Required", "password");
                            using (var archive = ArchiveFactory.Open(file, opts))
                            {
                                foreach (SharpCompress.Common.Entry entry in archive.Entries)
                                {
                                    if (entry.Key.ToLower().EndsWith(".var"))
                                    {
                                        SearchMyFolders_VarsList_Txtbx.AppendText(entry.Key.Substring(entry.Key.LastIndexOf("/") + 1) + Environment.NewLine);
                                    }
                                }
                            }
                            opts.Password = null;
                        }
                    }

                    if (Directory.Exists(file))
                    {
                        string[] vars_in_dir = Directory.GetFiles(file, "*.var", SearchOption.AllDirectories);
                        foreach (string var in vars_in_dir) { SearchMyFolders_VarsList_Txtbx.AppendText(System.IO.Path.GetFileName(var) + Environment.NewLine); }
                    }
                }
                catch (Exception ex)
                {
                    System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") ========= Search My Folders - Extract Var Names: " + file + "\r\n" + ex.Message + Environment.NewLine);
                }


                foreach (string dependency in Sharp_VaM_Tools.Extract_Var_Names.dependencies)
                {
                    if (dependency.Length > 0 && !SearchMyFolders_VarsList_Txtbx.Text.Contains(dependency))
                    {
                        SearchMyFolders_VarsList_Txtbx.AppendText(dependency + Environment.NewLine);
                    }
                }

                Cursor.Current = Cursors.Default;

            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") ========= Search My Folders - Extract Var Names:" + "\r\n" + ex.Message + Environment.NewLine);
            }
        }

        private void SearchMyFolder_Browse2_BTN_Click(object sender, EventArgs e)
        {
            var filedlg = new OpenFileDialog();
            filedlg.Filter = "Supported files|*.var;*.json;*.vap;*.vaj;*.clothingplugins;*.txt;*.zip;*.rar;*.7z";
            filedlg.Multiselect = true;
            if (filedlg.ShowDialog() != DialogResult.OK)
                return;
            Sharp_VaM_Tools.Extract_Var_Names.dependencies.Clear();
            SearchMyFolders_VarsList_Txtbx.Clear();
            foreach (var path in filedlg.FileNames)
            {
                SearchMyFolders_GlobalExtractVarNames(path);
            }
            if (SearchMyFolders_VarsList_Txtbx.Text.Length == 0)
            {
                MessageBox.Show("Couldn't extract any var names, this happens when text doesn't have any valid var names or var doesn't have any dependencies.");
            }
            if (SearchMyFolders_AutoSearch_Chkbx.Checked)
            {
                SearchMyFolders_StartSearching_BTN.PerformClick();
            }
        }
        private void SearchMyFolders_VarsList_Txtbx_DragDrop(object sender, DragEventArgs e)
        {
            Sharp_VaM_Tools.Extract_Var_Names.dependencies.Clear();
            SearchMyFolders_VarsList_Txtbx.Clear();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                SearchMyFolders_GlobalExtractVarNames(file);
            }
            if (SearchMyFolders_VarsList_Txtbx.Text.Length == 0)
            {
                MessageBox.Show("Couldn't extract any var names, this happens when text doesn't have any valid var names or var doesn't have any dependencies.");
            }
            if (SearchMyFolders_AutoSearch_Chkbx.Checked)
            {
                SearchMyFolders_StartSearching_BTN.PerformClick();
            }
        }

        private void SearchMyFolders_CM_VarsList_Txtbx_Copy_Click(object sender, EventArgs e)
        {
            if (SearchMyFolders_VarsList_Txtbx.Text.Length > 0) { Clipboard.SetText(SearchMyFolders_VarsList_Txtbx.SelectedText); }
        }

        private void SearchMyFolders_CM_VarsList_Txtbx_Paste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText().Length > 0) { SearchMyFolders_VarsList_Txtbx.Text = Clipboard.GetText(); }
        }

        private void SearchMyFolders_CM_VarsList_Txtbx_Clear_Click(object sender, EventArgs e)
        {
            SearchMyFolders_VarsList_Txtbx.Text = string.Empty;
        }

        private void SearchMyFolders_CM_VarsList_Txtbx_Extract_Click(object sender, EventArgs e)
        {
            Sharp_VaM_Tools.Extract_Var_Names.dependencies.Clear();
            Sharp_VaM_Tools.Extract_Var_Names.Extract_Var_names(SearchMyFolders_VarsList_Txtbx.Text, Settings_ExCreators_Txtbx.Text);
            SearchMyFolders_VarsList_Txtbx.Text = string.Empty;
            foreach (string file in Sharp_VaM_Tools.Extract_Var_Names.dependencies)
            {
                if (file.Length > 0)
                {
                    SearchMyFolders_VarsList_Txtbx.AppendText(file + Environment.NewLine);
                }
            }
        }

        private void SearchMyFolders_CM_VarsList_Txtbx_CopyAll_Click(object sender, EventArgs e)
        {
            if (SearchMyFolders_VarsList_Txtbx.Text.Length > 0) { Clipboard.SetText(SearchMyFolders_VarsList_Txtbx.Text); }
        }


        private void SearchMyFolders_CM_VarsList_Txtbx_ExtractVAMMissingDependencies_Click(object sender, EventArgs e)
        {
            try
            {
                SearchMyFolders_VarsList_Txtbx.Clear();
                string VaM_Output = "C:\\Users\\" + Environment.UserName + "\\AppData\\LocalLow\\MeshedVR\\VaM\\output_log.txt";
                if (System.IO.File.Exists(VaM_Output))
                {
                    using (var fs = new FileStream(VaM_Output, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (var sr = new StreamReader(fs, encoding))
                    {
                        string line = string.Empty;
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.StartsWith("Missing addon package"))
                            {
                                SearchMyFolders_VarsList_Txtbx.AppendText(Regex.Replace(line, @"(Missing addon package\s|\sthat package.*)", string.Empty) + Environment.NewLine);
                            }
                        }
                    }
                    if (SearchMyFolders_AutoSearch_Chkbx.Checked)
                    {
                        SearchMyFolders_StartSearching_BTN.PerformClick();
                    }
                }
                else
                {
                    MessageBox.Show("Sorry, couldn't find vam output log");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchMyFolders_CM_datagridview1_MoveVarsToPath_Click(object sender, EventArgs e)
        {
            if (SearchMyFolders_dataGridView1.Rows.Count > 0)
            {
                string errorlog = string.Empty;
                CommonOpenFileDialog fdialog = new CommonOpenFileDialog();
                fdialog.InitialDirectory = "C:\\";
                fdialog.IsFolderPicker = true;
                if (fdialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    foreach (DataGridViewCell cell in SearchMyFolders_dataGridView1.SelectedCells)
                    {
                        if (cell.Value.ToString().Length > 0)
                        {
                            int row_index = cell.RowIndex;
                            string var_path = SearchMyFolders_dataGridView1.Rows[row_index].Cells[2].Value.ToString();
                            string move_path = fdialog.FileName + "\\" + System.IO.Path.GetFileName(var_path);
                            try
                            {
                                if (System.IO.File.Exists(var_path))
                                {
                                    if (System.IO.File.Exists(move_path)) { System.IO.File.Delete(move_path); }
                                    System.IO.File.Move(var_path, move_path);
                                }

                            }
                            catch (Exception ex)
                            {
                                errorlog += "Couldn't move: " + var_path + " ===> " + ex.Message + Environment.NewLine;
                                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Move Selected Vars to Different Location" + "\r\n" + var_path + " ===> " + ex.Message + Environment.NewLine);
                            }
                        }
                    }
                    if (errorlog != string.Empty)
                    {
                        MessageBox.Show(errorlog);
                    }
                    Cursor.Current = Cursors.Default;
                    System.Diagnostics.Process.Start("C:\\Windows\\explorer.exe", fdialog.FileName);
                }

            }
        }
        /// ******** Search My Folders End ******** ///   

        /// ******** Extract Start ******** ///   

        private void Extract_VarNames_BTN_Click(object sender, EventArgs e)
        {
            if (Extract_Input_Txtbx.Text.Length > 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                Extract_Output_Txtbx.Text = string.Empty;
                Sharp_VaM_Tools.Extract_Var_Names.dependencies.Clear();
                if (Extract_Isjson_Chkbx.Checked) { Sharp_VaM_Tools.Extract_Var_Names.Extract_json(Extract_Input_Txtbx.Text); }
                else { Sharp_VaM_Tools.Extract_Var_Names.Extract_Var_names(Extract_Input_Txtbx.Text, Settings_ExCreators_Txtbx.Text); }
                foreach (string dependency in Sharp_VaM_Tools.Extract_Var_Names.dependencies)
                {
                    if (dependency.Length > 0)
                    {
                        Extract_Output_Txtbx.AppendText(dependency + Environment.NewLine);
                    }

                }
                Cursor.Current = Cursors.Default;
                if (Extract_Output_Txtbx.Text.Length > 0)
                {
                    Extract_Generate_metajson_BTN.Visible = true;
                    Extract_GenerateDependecies_BTN.Visible = true;
                }
            }
        }
        private void Extract_DownloadLinks_BTN_Click(object sender, EventArgs e)
        {
            if (Extract_Input_Txtbx.Text.Length > 0 && Extract_Input_Txtbx.Text.Contains("api/file/"))
            {
                Extract_Output_Txtbx.Clear();
                string[] download_txt = Extract_Input_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in download_txt)
                {
                    string var = string.Empty;
                    string download_link = string.Empty;
                    if (line.Contains(".var\"") && line.Contains("api/file/"))
                    {
                        string[] split = line.Split(new string[] { "\">" }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (string atom in split)
                        {
                            if (atom.Contains("api/file"))
                            {
                                download_link = System.Net.WebUtility.HtmlDecode(Regex.Replace(atom, ".*<a href=\"", "https://pixeldrain.com"));
                                var = System.Net.WebUtility.HtmlDecode(download_link.Substring(download_link.LastIndexOf("/") + 1));
                            }

                        }
                        Extract_Output_Txtbx.AppendText(var + "   " + download_link + Environment.NewLine);
                    }

                }

                //remove duplicate lines
                Extract_Output_Txtbx.Text = Regex.Replace(Extract_Output_Txtbx.Text, @"^(.+)$(?=[\s\S]*^(\1)$[\s\S]*)", string.Empty, RegexOptions.Multiline).TrimEnd();

            }
            else
            {
                MessageBox.Show("Couldn't extract any download links");
            }

        }

        private string licenseType = string.Empty;

        private string Var_Latest_Version = string.Empty;
        private Task Get_Latest_Version(string var, string[] paths)
        {
            List<string> list = new List<string>();

            foreach (string path in paths)
            {
                if (System.IO.Directory.Exists(path.Trim()))
                {
                    list.AddRange(Directory.GetFiles(path.Trim(), var.Trim() + ".*var", SearchOption.AllDirectories).ToList<string>());
                }

            }
            if (list.Count > 0)
            {
                Dictionary<string, int> Numeric = new Dictionary<string, int>();
                foreach (string var_path in list)
                {
                    if (Regex.IsMatch(var_path, "\\..*?\\.[0-9]+.var$"))
                    {
                        Numeric.Add(var_path, Convert.ToInt32(Regex.Replace(var_path, ".*\\.([0-9]+)\\.var$", "$1")));
                    }
                }
                Numeric = Numeric.OrderByDescending(k => k.Value).ToDictionary(k => k.Key, k => k.Value);
                Var_Latest_Version = Numeric.First().Key;
            }
            return Task.CompletedTask;
        }

        private void Get_metajson_info(string var, bool get_licenseType, bool get_SubDependencies)
        {
            try
            {
                Sharp_VaM_Tools.Extract_Var_Names.dependencies.Clear();
                string[] Vars_Locations_To_Search_In = SearchMyFolders_VarsLocations_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                List<string> list = new List<string>();
                foreach (string path in Vars_Locations_To_Search_In)
                {
                    list.AddRange(Directory.GetFiles(path.Trim(), Regex.Replace(var.Trim(), @"\.var$|\.latest$", string.Empty) + ".*var", SearchOption.AllDirectories).ToList<string>());
                }
                string var_path = string.Empty;
                if (var.EndsWith(".latest"))
                {
                    List<int> list_numeric = new List<int>();
                    foreach (string aa in list)
                    {
                        try
                        {
                            list_numeric.Add(Convert.ToInt32(aa.Substring(aa.LastIndexOf('\\') + 1).Replace(Regex.Replace(var.Trim(), @"\.var$|latest$", string.Empty), string.Empty).Replace(".var", "")));
                        }
                        catch
                        {

                        }
                    }
                    list_numeric.Sort();
                    foreach (int i in list_numeric)
                    {
                        foreach (string path in list)
                        {
                            if (path.EndsWith("." + i + ".var"))
                            {
                                var_path = path;
                            }
                        }

                    }
                }
                else
                {
                    var_path = list[0];
                }


                var opts = new SharpCompress.Readers.ReaderOptions();
                opts.ArchiveEncoding.Default = encoding;
                using (Stream stream = System.IO.File.OpenRead(var_path))
                using (var reader = ReaderFactory.Open(stream, opts))
                {
                    while (reader.MoveToNextEntry())
                    {
                        if (reader.Entry.Key.ToLower().Equals("meta.json"))
                        {
                            using (var streamReader = new StreamReader(reader.OpenEntryStream()))
                            {
                                string content = streamReader.ReadToEnd();
                                if (get_licenseType == true)
                                {
                                    string[] lines = content.Split('\n');
                                    foreach (string line in lines)
                                    {
                                        if (line.Contains("\"licenseType\"")) { licenseType = line; break; }
                                    }
                                }
                                if (get_SubDependencies == true)
                                {
                                    //Removed
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                licenseType = "   \"licenseType\" : \"MISSING\",";
            }
        }

        private string Generated_dependecies = string.Empty;
        private void Extract_GenerateDependecies_BTN_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Generate_dependecies();
            Extract_GenerateDependecies_BTN.Visible = false;
            Cursor.Current = Cursors.Default;
        }
        private void Generate_dependecies()
        {
            if (Extract_Output_Txtbx.Text.Length == 0) { return; }
            Generated_dependecies = string.Empty;
            string[] dependencies = Extract_Output_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            Extract_Output_Txtbx.Text = string.Empty;
            bool get_license = Extract_LicenseType_Chkbx.Checked;
            bool get_subDep = Extract_GetSubDependencies_Chkbx.Checked;

            foreach (string dependency in dependencies)
            {
                string Dependency_match = string.Empty;
                if (Regex.Match(dependency, @"\..*?\.[0-9]+").Success)
                {
                    Dependency_match = dependency;
                }
                else
                {
                    Dependency_match = dependency + ".latest";
                }
                if (get_license)
                {
                    Get_metajson_info(Dependency_match, true, false);
                    Extract_Output_Txtbx.AppendText("      \"" + Dependency_match + "\"" + " : {" + Environment.NewLine +
                               "         " + licenseType.Trim() + Environment.NewLine +
                               "         " + "\"dependencies\" : {" + Environment.NewLine +
                               "         }" + Environment.NewLine +
                               "      }," + Environment.NewLine
                               );
                }

                if (!get_license)
                {
                    Extract_Output_Txtbx.AppendText("      \"" + Dependency_match + "\"" + " : {}," + Environment.NewLine);
                }

            }
            //remove "," from last dependency
            Generated_dependecies = Extract_Output_Txtbx.Text = Extract_Output_Txtbx.Text.Remove(Extract_Output_Txtbx.Text.LastIndexOf(","));

            //Highlight MISSING
            Regex regex = new Regex("\"MISSING\"", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(Extract_Output_Txtbx.Text);
            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                {
                    Extract_Output_Txtbx.Select(m.Index, m.Length);
                    Extract_Output_Txtbx.SelectionColor = Color.Red;
                }
                Extract_Output_Txtbx.Select(matches[0].Index, matches[0].Length);

            }
        }

        private void Extract_Generate_metajson_BTN_Click(object sender, EventArgs e)
        {
            if (Generated_dependecies == string.Empty)
            {
                Generate_dependecies();
            }

            Extract_Output_Txtbx.Text = string.Empty;
            Extract_Output_Txtbx.AppendText(
                "{" + Environment.NewLine +
                "   \"licenseType\" : \"CC BY\"," + Environment.NewLine +
                "   \"creatorName\" : \"Boss963\"," + Environment.NewLine +
                "   \"packageName\" : \"var_name\"," + Environment.NewLine +
                "   \"standardReferenceVersionOption\" : \"Latest\"," + Environment.NewLine +
                "   \"scriptReferenceVersionOption\" : \"Exact\"," + Environment.NewLine +
                "   \"description\" : \"Boss963 | Auto Generated by SharpVaMTools\"," + Environment.NewLine +
                "   \"credits\" : \"\"," + Environment.NewLine +
                "   \"instructions\" : \"\"," + Environment.NewLine +
                "   \"promotionalLink\" : \"\"," + Environment.NewLine +
                "   \"programVersion\" : \"1.22.0.9\"," + Environment.NewLine +
                "   \"contentList\" : [" + Environment.NewLine +
                "      \"Custom\"," + Environment.NewLine +
                "      \"Saves\"" + Environment.NewLine +
                "   ]," + Environment.NewLine +
                "   \"dependencies\" : {" + Environment.NewLine +
                Generated_dependecies + Environment.NewLine +
                "   }," + Environment.NewLine +
                 "   \"customOptions\" : {" + Environment.NewLine +
                "   \"preloadMorphs\" : \"false\"" + Environment.NewLine +
                "   }," + Environment.NewLine +
                "   \"hadReferenceIssues\" : \"false\"," + Environment.NewLine +
                "   \"referenceIssues\" : [" + Environment.NewLine +
                "   ]" + Environment.NewLine +
                "}"
                );
            Extract_Generate_metajson_BTN.Visible = false; Extract_GenerateDependecies_BTN.Visible = false;

        }

        private void Extract_CM_Input_Txtbx_Copy_Click(object sender, EventArgs e)
        {
            if (Extract_Input_Txtbx.SelectedText.Length > 0) { Clipboard.SetText(Extract_Input_Txtbx.SelectedText); }

        }

        private void Extract_CM_Input_Txtbx_Paste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText().Length > 0) { Extract_Input_Txtbx.Text = Clipboard.GetText(); }

        }

        private void Extract_CM_Input_Txtbx_Clear_Click(object sender, EventArgs e)
        {
            Extract_Input_Txtbx.Text = string.Empty;
        }

        private void Extract_CM_Output_Txtbx_Copy_Click(object sender, EventArgs e)
        {
            if (Extract_Output_Txtbx.SelectedText.Length > 0) { Clipboard.SetText(Extract_Output_Txtbx.SelectedText); }
        }

        private void Extract_CM_Output_Txtbx_CopyAll_Click(object sender, EventArgs e)
        {
            if (Extract_Output_Txtbx.Text.Length > 0) { Clipboard.SetText(Extract_Output_Txtbx.Text); }

        }

        private void Extract_CM_Output_Txtbx_Clear_Click(object sender, EventArgs e)
        {
            Extract_Output_Txtbx.Text = string.Empty;
        }

        private void Extract_Output_Txtbx_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }
        private void Extract_Output_Txtbx_DragDrop(object sender, DragEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Extract_Output_Txtbx.Text = string.Empty;
            Sharp_VaM_Tools.Extract_Var_Names.dependencies.Clear();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                var opts = new SharpCompress.Readers.ReaderOptions();
                opts.ArchiveEncoding.Default = encoding;
                if (file.ToLower().EndsWith(".var"))
                {
                    using (Stream stream = System.IO.File.OpenRead(file))
                    using (var archive = ReaderFactory.Open(stream, opts))
                    {
                        while (archive.MoveToNextEntry())
                        {
                            if (archive.Entry.Key.ToLower().Equals("meta.json"))
                            {
                                goto skip;
                            }
                            if (Regex.IsMatch(archive.Entry.Key.ToLower(), "\\.(json|vap|vaj|clothingplugins)$"))
                            {
                                using (var streamReader = new StreamReader(archive.OpenEntryStream()))
                                {
                                    Sharp_VaM_Tools.Extract_Var_Names.Extract_json(streamReader.ReadToEnd());
                                }
                            }
                        skip:;
                        }
                    }

                }
                if (Regex.IsMatch(file, "\\.(txt|json|vap|vaj|clothingplugins)$"))
                {
                    string content = System.IO.File.ReadAllText(file, encoding);

                    //if it's meta.json parse it normally, if it's scene.json or .vap parse only lines with ":/"
                    if (file.EndsWith("meta.json"))
                    {
                        int index_start = content.IndexOf("\"dependencies\"");
                        int index_end = content.Length;
                        if (content.Contains("customOptions"))
                        {
                            index_end = content.IndexOf("\"customOptions\"");

                        }
                        Sharp_VaM_Tools.Extract_Var_Names.Extract_Var_names(content.Substring(index_start, index_end - index_start), Settings_ExCreators_Txtbx.Text);
                    }
                    else { Sharp_VaM_Tools.Extract_Var_Names.Extract_json(content); }
                }

            }


            foreach (string dependency in Sharp_VaM_Tools.Extract_Var_Names.dependencies)
            {
                if (dependency.Length > 0)
                {
                    Extract_Output_Txtbx.AppendText(dependency + Environment.NewLine);
                }
            }
            if (Extract_Output_Txtbx.Text.Length > 0)
            {
                Extract_GenerateDependecies_BTN.Visible = true; Extract_Generate_metajson_BTN.Visible = true;
                Sharp_VaM_Tools.Extract_Var_Names.dependencies.Clear();
            }
            Cursor.Current = Cursors.Default;
        }

        /// ******** Extract End ******** ///   

        /// ******** Missing from F95 Start ******** ///   
        private void MissingFromF95_Browse_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog fdialog = new CommonOpenFileDialog();
            fdialog.InitialDirectory = "C:\\";
            fdialog.IsFolderPicker = true;
            if (fdialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                List<string> lines = MissingFromF95_CreatorPaths_Txtbx.Text.ToLower().Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!(lines.Contains(fdialog.FileName.ToLower())))
                {
                    if (!MissingFromF95_CreatorPaths_Txtbx.Text.EndsWith("\n"))
                    {
                        MissingFromF95_CreatorPaths_Txtbx.AppendText(Environment.NewLine);
                    }
                    MissingFromF95_CreatorPaths_Txtbx.AppendText(fdialog.FileName + Environment.NewLine);
                }

            }
        }

        private void MissingFromF95_ExtractVarNames_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Sharp_VaM_Tools.Extract_Var_Names.dependencies.Clear();
                Sharp_VaM_Tools.Extract_Var_Names.Extract_Var_names(MissingFromF95_IncludedModelsAssets_Txtbx.Text, Settings_ExCreators_Txtbx.Text);
                MissingFromF95_IncludedModelsAssets_Txtbx.Clear();
                foreach (string file in Sharp_VaM_Tools.Extract_Var_Names.dependencies)
                {
                    if (file.Length > 0) { MissingFromF95_IncludedModelsAssets_Txtbx.AppendText(file + Environment.NewLine); }
                }

                string CreatorName = MissingFromF95_IncludedModelsAssets_Txtbx.Lines[0].Substring(0, MissingFromF95_IncludedModelsAssets_Txtbx.Lines[0].IndexOf(".")).Trim();
                List<string> lines = new List<string>(MissingFromF95_CreatorPaths_Txtbx.Lines);
                MissingFromF95_CreatorPaths_Txtbx.Clear();
                foreach (string line in lines)
                {
                    try
                    {
                        DirectoryInfo creator_folder = new DirectoryInfo(line);
                        MissingFromF95_CreatorPaths_Txtbx.AppendText(line.Replace(creator_folder.Name, CreatorName) + Environment.NewLine);
                    }
                    catch { }
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Missing from F95" + "\r\n" + ex.Message + Environment.NewLine);
            }
        }

        private CancellationTokenSource Cancel_Search_F95 = new CancellationTokenSource();

        private List<string> Creator_vars = new List<string>();
        private async void MissingFromF95_Search_BTN_Click(object sender, EventArgs e)
        {
            if (MissingFromF95_Search_BTN.Text == "Searching...")
            {
                Cancel_Search_F95.Cancel();
                return;
            }
            MissingFromF95_Search_BTN.Text = "Searching...";
            Cancel_Search_F95 = new CancellationTokenSource();
            var cancellationToken = Cancel_Search_F95.Token;

            if (MissingFromF95_IncludedModelsAssets_Txtbx.Text.Contains(".var")) { MessageBox.Show("Extract var names first then search."); MissingFromF95_Search_BTN.Text = "Search"; return; }

            try
            {
                Creator_vars.Clear(); MissingFromF95_dataGridView.Rows.Clear();
                string[] creator_dirs = MissingFromF95_CreatorPaths_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                string[] F95_extracted_vars = MissingFromF95_IncludedModelsAssets_Txtbx.Text.ToLower().Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries); ;

                foreach (string dir in creator_dirs)
                {
                    if (Directory.Exists(dir))
                    {
                        string[] vars = Directory.GetFiles(dir.Trim(), "*.var", SearchOption.AllDirectories);
                        foreach (string var in vars)
                        {
                            //ignore duplicate vars: (1) copy.var, 1_1.var ..etc
                            if (Regex.IsMatch(System.IO.Path.GetFileName(var), "\\..*?\\.[0-9]+.var$")) { Creator_vars.Add(var); }
                        }
                    }
                }

                foreach (string var in Creator_vars)
                {
                    string var_name = string.Empty;
                    await Task.Run(() =>
                    {
                        var_name = Regex.Replace(System.IO.Path.GetFileName(var), @"(\.var$)", string.Empty);
                    }, Cancel_Search_F95.Token);


                    if (!F95_extracted_vars.Contains(var_name.ToLower()))
                    {
                        MissingFromF95_dataGridView.Rows.Add(var_name, "Not Shared on F95");
                    }
                }

                hero.Visible = false; Fine_PIC.Visible = true; Boss_Fine_PIC.Visible = true;
                if (MissingFromF95_dataGridView.Rows.Count > 0)
                {
                    string creator = MissingFromF95_IncludedModelsAssets_Txtbx.Lines[0].Substring(0, MissingFromF95_IncludedModelsAssets_Txtbx.Lines[0].IndexOf(".")).Trim();
                    MissingFromF95_ZipSavePath_Txtbx.Text = System.IO.Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.Personal)); MissingFromF95_ZipSavePath_Txtbx.Text = System.IO.Path.Combine(MissingFromF95_ZipSavePath_Txtbx.Text, "Downloads" + "\\" + creator + "_Col_Update-" + DateTime.Now.ToString("yyyy-MM-dd") + ".zip");
                    Fine_PIC.Visible = false; Boss_Fine_PIC.Visible = false;
                }
                else
                {
                    MessageBox.Show("All is good, nothing is missing.");
                }

            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Missing from F95 Search" + "\r\n" + ex.Message + Environment.NewLine);
            }
            MissingFromF95_Search_BTN.Text = "3) Search";

        }

        private async void MissingFromF95_zipButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MissingFromF95_dataGridView.Rows.Count == 0 || MissingFromF95_ZipSavePath_Txtbx.Text.Length == 0) { return; }
                List<string> vars_to_zip = new List<string>();
                foreach (DataGridViewRow row in MissingFromF95_dataGridView.Rows)
                {
                    string missing_var = null;
                    try
                    {
                        missing_var = Creator_vars.FirstOrDefault(x => x.EndsWith(row.Cells[0].Value.ToString() + ".var"));
                    }
                    catch { }
                    if (!vars_to_zip.Any(x => x.EndsWith(System.IO.Path.GetFileName(missing_var))))

                    {
                        vars_to_zip.Add(missing_var);
                        if (MissingFromF95_IncludeVarImages_Chkbx.Checked)
                        {
                            if (System.IO.File.Exists(Regex.Replace(missing_var, @"\.var$", ".jpg")))
                            {
                                vars_to_zip.Add(Regex.Replace(missing_var, @"\.var$", ".jpg"));
                            }
                            if (System.IO.File.Exists(Regex.Replace(missing_var, @"\.var$", ".jpeg")))
                            {
                                vars_to_zip.Add(Regex.Replace(missing_var, @"\.var$", ".jpeg"));
                            }
                            if (System.IO.File.Exists(Regex.Replace(missing_var, @"\.var$", ".png")))
                            {
                                vars_to_zip.Add(Regex.Replace(missing_var, @"\.var$", ".png"));
                            }
                        }
                    }
                }

                hero.Visible = true; Fine_PIC.Visible = false; Boss_Fine_PIC.Visible = false;
                Cursor.Current = Cursors.WaitCursor;

                if (System.IO.File.Exists(MissingFromF95_ZipSavePath_Txtbx.Text)) { File.Delete(MissingFromF95_ZipSavePath_Txtbx.Text); }
                var writerOptions = new WriterOptions(CompressionType.None) { LeaveStreamOpen = true };
                writerOptions.ArchiveEncoding.Default = encoding;
                using (Stream stream = File.OpenWrite(MissingFromF95_ZipSavePath_Txtbx.Text))
                {
                    using (var writer = WriterFactory.Open(stream, ArchiveType.Zip, writerOptions))
                    {
                        foreach (var file in vars_to_zip)
                        {
                            if (System.IO.File.Exists(file))
                            {
                                using (System.IO.Stream fstream = System.IO.File.Open(file, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                                {
                                    writer.Write(System.IO.Path.GetFileName(file), fstream);
                                }
                            }
                        }
                    }
                }

                if (MissingFromF95_PixeldrainUpload_Chkbx.Checked)
                {
                    MissingFromF95_YingYang_PixelDrain.Visible = true;
                    await PostFile_Pixeldrain();
                    MissingFromF95_YingYang_PixelDrain.Visible = false;

                    if (MissingFromF95_DeleteZipAfterUploading_Chkbx.Checked)
                    {
                        File.Delete(MissingFromF95_ZipSavePath_Txtbx.Text);
                    }
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private async Task PostFile_Pixeldrain()
        {
            try
            {
                using (var fileStream = File.OpenRead(MissingFromF95_ZipSavePath_Txtbx.Text))
                {
                    MissingFromF95_Pixeldrain_Txtbx.Text = "uploading, please wait .....";
                    HttpClient client = new HttpClient();
                    client.Timeout = TimeSpan.FromMilliseconds(Timeout.Infinite);

                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Put, "https://pixeldrain.com/api/file/" + System.IO.Path.GetFileName(MissingFromF95_ZipSavePath_Txtbx.Text));

                    request.Headers.Add("Authorization", "Basic " + Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(":" + Settings_PixeldrainApi_Txtbx.Text.Replace("\n", ""))));

                    request.Content = new StreamContent(fileStream);
                    HttpResponseMessage response = await client.SendAsync(request);

                    response.EnsureSuccessStatusCode();
                    string pixel_response = await response.Content.ReadAsStringAsync();

                    JavaScriptSerializer serializer = new JavaScriptSerializer();
                    dynamic fileid = serializer.Deserialize<object>(pixel_response);
                    MissingFromF95_Pixeldrain_Txtbx.Text = "https://pixeldrain.com/u/" + fileid["id"];
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("401 (Unauthorized)")) { MissingFromF95_Pixeldrain_Txtbx.Text = "Incorrect API Key in Settings: " + ex.Message; }
                else { MissingFromF95_Pixeldrain_Txtbx.Text = ex.Message; }
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Pixeldrain Upload" + "\r\n" + ex.Message + Environment.NewLine);
            }

        }

        private void MissingFromF95_BrowseZip_BTN_Click(object sender, EventArgs e)
        {
            var SaveFileDialog = new SaveFileDialog();
            SaveFileDialog.Filter = "Zip File|*.zip";
            if (SaveFileDialog.ShowDialog() != DialogResult.OK)
                return;
            MissingFromF95_ZipSavePath_Txtbx.Text = SaveFileDialog.FileName;
        }

        private void MissingFromF95_CM_IncludedModelsAssets_CopyAll_Click(object sender, EventArgs e)
        {
            if (MissingFromF95_IncludedModelsAssets_Txtbx.Text.Length > 0) { Clipboard.SetText(MissingFromF95_IncludedModelsAssets_Txtbx.Text); }

        }

        private void MissingFromF95_CM_IncludedModelsAssets_CopySelected_Click(object sender, EventArgs e)
        {
            if (MissingFromF95_IncludedModelsAssets_Txtbx.Text.Length > 0) { Clipboard.SetText(MissingFromF95_IncludedModelsAssets_Txtbx.SelectedText); }

        }

        private void MissingFromF95_CM_IncludedModelsAssets_Paste_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetText().Length > 0) { MissingFromF95_IncludedModelsAssets_Txtbx.Text = Clipboard.GetText(); }
        }

        private void MissingFromF95_CM_IncludedModelsAssets_ClearAll_Click(object sender, EventArgs e)
        {
            MissingFromF95_IncludedModelsAssets_Txtbx.Text = string.Empty;
        }

        private void MissingFromF95_CM_dataGridView_Copy_Click(object sender, EventArgs e)
        {
            if (MissingFromF95_dataGridView.Rows.Count > 0 && MissingFromF95_dataGridView.CurrentCell.Value.ToString().Length > 0)
            { Clipboard.SetDataObject(MissingFromF95_dataGridView.GetClipboardContent()); }
        }
        /// ******** Missing from F95 End ******** ///   

        /// ******** Search Inside Vars Start ******** ///   

        private void SearchInsideVars_Browse_BTN_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog fdialog = new CommonOpenFileDialog();
            fdialog.InitialDirectory = "C:\\";
            fdialog.IsFolderPicker = true;
            if (fdialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                List<string> lines = SearchInsideVars_VarPaths_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!(lines.Contains(fdialog.FileName)))
                {
                    if (!(SearchInsideVars_VarPaths_Txtbx.Text.EndsWith("\n")))
                    {
                        SearchInsideVars_VarPaths_Txtbx.AppendText(Environment.NewLine);
                    }

                    SearchInsideVars_VarPaths_Txtbx.AppendText(fdialog.FileName + Environment.NewLine);

                }
            }
        }

        private CancellationTokenSource Cancel_Building_DB = new CancellationTokenSource();

        private List<string> bookmarks = new List<string>();
        private async void SearchInsideVars_BuildDatabase_BTN_Click(object sender, EventArgs e)
        {
            if (SearchInsideVars_BuildDatabase_BTN.Text == "Building...")
            {
                Cancel_Building_DB.Cancel();
                SearchInsideVars_BuildingDone_Lbl.Text = "Building Canceled!";
                return;
            }

            bookmarks.Clear();
            SearchInsideVars_BuildDatabase_BTN.Text = "Building..."; SearchInsideVars_BuildingDone_Lbl.Visible = false; SearchInsideVars_BuildingDone_Lbl.Text = "Building Done!"; SearchInsideVars_YingYangBuildDB_Pic.Visible = true;
            if (System.IO.File.Exists(SearchInsideVars_db_Path_Txtbx.Text.Replace(".txt", string.Empty) + "_Backup.txt"))
            {
                System.IO.File.Delete(SearchInsideVars_db_Path_Txtbx.Text.Replace(".txt", string.Empty) + "_Backup.txt");
            }

            if (System.IO.File.Exists(SearchInsideVars_db_Path_Txtbx.Text))
            {
                System.IO.File.Copy(SearchInsideVars_db_Path_Txtbx.Text, SearchInsideVars_db_Path_Txtbx.Text.Replace(".txt", string.Empty) + "_Backup.txt");
            }

            if (!System.IO.File.Exists(SearchInsideVars_db_Path_Txtbx.Text))
            {
                System.IO.File.Create(SearchInsideVars_db_Path_Txtbx.Text);
            }
            try
            {
                if (SearchInsideVars_KeepBookmarks_Chkbx.Checked)
                {
                    using (StreamReader reader = new StreamReader(SearchInsideVars_db_Path_Txtbx.Text, encoding))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line.StartsWith("[B]"))
                            {
                                bookmarks.Add(line);
                            }
                        }

                    }
                }

                if (SearchInsideVars_Append_Chkbx.Checked)
                {
                    await Build_db_task();
                }
                else
                {

                    System.IO.File.WriteAllText(SearchInsideVars_db_Path_Txtbx.Text, "");
                    await Build_db_task();

                }
                SearchInsideVars_BuildingDone_Lbl.Visible = true; SearchInsideVars_YingYangBuildDB_Pic.Visible = false;
            }
            catch (Exception ex)
            {
                SearchInsideVars_BuildingDone_Lbl.Text = "Building Failed!";
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Building Database" + "\r\n" + ex.Message + Environment.NewLine);
            }
            SearchInsideVars_BuildDatabase_BTN.Text = "Build Database";
        }


        private async Task Build_db_task()
        {

            Cancel_Building_DB.Cancel();
            Cancel_Building_DB = new CancellationTokenSource();
            var cancellationToken = Cancel_Building_DB.Token;

            try

            {
                string[] locations_to_search_in = SearchInsideVars_VarPaths_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string dir in locations_to_search_in)
                {
                    int i = Array.IndexOf(locations_to_search_in, locations_to_search_in.Where(x => x.Contains(dir)).FirstOrDefault()) + 1;

                    string[] vars = Directory.GetFiles(dir.Trim(), "*.var", SearchOption.AllDirectories);
                    foreach (string var in vars)
                    {
                        await Task.Run(() =>
                        {
                            try
                            {
                                var opts = new SharpCompress.Readers.ReaderOptions();
                                opts.ArchiveEncoding.Default = encoding;
                                using (Stream stream = System.IO.File.OpenRead(var))
                                using (var reader = ReaderFactory.Open(stream, opts))
                                {
                                    while (reader.MoveToNextEntry())
                                    {
                                        if (!reader.Entry.IsDirectory)
                                        {
                                            string entry_txt = "[" + i + "] " + reader.Entry.Crc.ToString("X8") + "   " + Regex.Replace(System.IO.Path.GetFileName(var), @"\.var$", string.Empty) + ":/" + reader.Entry.Key;
                                            if (SearchInsideVars_KeepBookmarks_Chkbx.Checked)
                                            {
                                                foreach (string bookmark in bookmarks)
                                                {
                                                    if (bookmark.Contains(entry_txt))
                                                    {
                                                        System.IO.File.AppendAllText(SearchInsideVars_db_Path_Txtbx.Text, bookmark + Environment.NewLine, encoding);
                                                        goto done;
                                                    }
                                                }
                                            }
                                            System.IO.File.AppendAllText(SearchInsideVars_db_Path_Txtbx.Text, entry_txt + Environment.NewLine, encoding);
                                        }
                                    done:;
                                    }
                                }

                            }
                            catch (Exception ex)
                            {
                                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Building Database Task: " + var + "\r\n" + ex.Message + Environment.NewLine);
                            }
                        }, Cancel_Building_DB.Token);
                    }

                }

            }
            catch (OperationCanceledException) { }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Building Database Task" + "\r\n" + ex.Message + Environment.NewLine);
            }
        }

        private List<string> morphs_vars = new List<string>
        {
            "Do_Not_Distribute.", "KdollMASTA.", "ascorad.", "Morph.Morphs_Mega_Pack.1", "Spacedog.", "Oeshii.ReloadedMorphs.1", "CheesyFX",
            "kemenate.Morphs", "UniversalMorphCollection", "AshAuryn.", "klphgz.", "MacGruber.", "everlaster.", "DillDoe.", "SupaRioAmateur."
        };

        private void SearchInsideVars_SearchDatabase_BTN_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(SearchInsideVars_db_Path_Txtbx.Text)) { MessageBox.Show("Can't find database file, check database path or build a new one."); return; }

            SearchInsideVars_dataGridView.Rows.Clear();
            Cursor.Current = Cursors.WaitCursor;
            string[] strings_to_search = SearchInsideVars_SearchStrings_Txtbx.Text.Split(new string[] { ";", " ;", " ; " }, StringSplitOptions.None);
            using (StreamReader sr = new StreamReader(SearchInsideVars_db_Path_Txtbx.Text, encoding))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    foreach (string string_to_search in strings_to_search)
                    {
                        string subfilter = SearchInsideVars_SearchSubfilter_Txtbx.Text;
                        if (SearchInsideVars_IsMorph_Chkbx.Checked && !SearchInsideVars_UseSubfilter_Chkbx.Checked)
                        {
                            if ((Regex.IsMatch(line, Regex.Escape(string_to_search.Trim()), RegexOptions.IgnoreCase)) && (morphs_vars.Any(line.Contains)))
                            {
                                SearchInsideVars_dataGridView.Rows.Add(string_to_search.Trim(), line);
                            }
                            goto done;
                        }
                        if (SearchInsideVars_IsMorph_Chkbx.Checked && SearchInsideVars_UseSubfilter_Chkbx.Checked)
                        {
                            if ((Regex.IsMatch(line, Regex.Escape(string_to_search.Trim()), RegexOptions.IgnoreCase)) && (morphs_vars.Any(line.Contains)) && (line.Contains(subfilter)))
                            {
                                SearchInsideVars_dataGridView.Rows.Add(string_to_search.Trim(), line);
                            }
                            goto done;
                        }
                        if (!SearchInsideVars_IsMorph_Chkbx.Checked && SearchInsideVars_UseSubfilter_Chkbx.Checked)
                        {
                            if ((Regex.IsMatch(line, Regex.Escape(string_to_search.Trim()), RegexOptions.IgnoreCase)) && (line.Contains(subfilter)))
                            {
                                SearchInsideVars_dataGridView.Rows.Add(string_to_search.Trim(), line);
                            }
                            goto done;
                        }

                        if (Regex.IsMatch(line, Regex.Escape(string_to_search.Trim()), RegexOptions.IgnoreCase))
                        {
                            SearchInsideVars_dataGridView.Rows.Add(string_to_search.Trim(), line);
                        }
                    done:;
                    }
                }

            }
            SearchInsideVars_dataGridView.Sort(SearchInsideVars_dataGridView.Columns[1], ListSortDirection.Ascending);
            foreach (DataGridViewRow row in SearchInsideVars_dataGridView.Rows)
            {
                if (row.Cells[1].Value.ToString().Trim().StartsWith("[B]"))
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    SearchInsideVars_dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                }
                if (row.Cells[1].Value.ToString().Trim().ToLower().Contains("/male/"))
                {
                    row.DefaultCellStyle.BackColor = Color.HotPink;
                    SearchInsideVars_dataGridView.FirstDisplayedScrollingRowIndex = row.Index;
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private CancellationTokenSource Cancel_Search_Inside_Vars = new CancellationTokenSource();

        private void SearchInsideVars_Cancel_BTN_Click(object sender, EventArgs e)
        {
            Cancel_Search_Inside_Vars.Cancel();
        }
        private async void SearchInsideVars_SearchFolders_BTN_Click(object sender, EventArgs e)
        {
            Cancel_Search_Inside_Vars.Cancel();
            Cancel_Search_Inside_Vars = new CancellationTokenSource();
            var cancellationToken = Cancel_Search_Inside_Vars.Token;

            SearchInsideVars_SearchFolders_BTN.Text = "Searching...";
            SearchInsideVars_dataGridView.Rows.Clear();
            string[] locations_to_search_in = SearchInsideVars_VarPaths_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            string[] keywords = SearchInsideVars_SearchStrings_Txtbx.Text.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string dir in locations_to_search_in)
            {
                string[] vars = Directory.GetFiles(dir.Trim(), "*.var", SearchOption.AllDirectories);
                foreach (string var in vars)
                {
                    try
                    {
                        string path = string.Empty; string key_word = string.Empty;
                        await Task.Run(() =>
                        {

                            var opts = new SharpCompress.Readers.ReaderOptions();
                            opts.ArchiveEncoding.Default = encoding;
                            using (Stream stream = System.IO.File.OpenRead(var))
                            using (var reader = ReaderFactory.Open(stream, opts))
                            {
                                while (reader.MoveToNextEntry())
                                {
                                    foreach (string keyword in keywords)
                                    {
                                        if (reader.Entry.Key.Contains(keyword.Trim()) || reader.Entry.Crc.ToString("X8").Contains(keyword.Trim()))
                                        {
                                            path = Regex.Replace(System.IO.Path.GetFileName(var), @"\.var$", string.Empty) + ":/" + reader.Entry.Key;
                                            key_word = keyword;
                                        }
                                    }
                                }
                            }

                        }, Cancel_Search_Inside_Vars.Token);
                        if (path.Length > 0 && key_word.Length > 0) { SearchInsideVars_dataGridView.Rows.Add(key_word, path); SearchInsideVars_dataGridView.FirstDisplayedScrollingRowIndex = SearchInsideVars_dataGridView.Rows.Count - 1; }
                    }
                    catch (OperationCanceledException) { }
                    catch (Exception ex) { System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Search inside: " + var + "\r\n" + ex.Message + Environment.NewLine); }

                }
            }
            SearchInsideVars_SearchFolders_BTN.Text = "Search Folders";
        }

        private void var_to_crc_and_path_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private async void SearchInsideVars_CM_VarToCRCAndPaths_Browse_Click(object sender, EventArgs e)
        {
            var filedlg = new OpenFileDialog();
            filedlg.Filter = "var|*.var";
            filedlg.Multiselect = true;
            if (filedlg.ShowDialog() != DialogResult.OK)
                return;

            Cancel_VarToCRCAndPaths.Cancel();
            Cancel_VarToCRCAndPaths = new CancellationTokenSource();
            SearchInsideVars_VarToCRCAndPaths_Txtbx.Clear();
            SearchInsideVars_AnalyzeVars_YinYang_Pic.Visible = true;
            try
            {
                foreach (var var in filedlg.FileNames)
                {
                    await Task.Run(() =>
                    {
                        Sharp_VaM_Tools.Analyze_Var.Anal_CRC = string.Empty;
                        Sharp_VaM_Tools.Analyze_Var.Anal_Warnings = string.Empty;
                        Sharp_VaM_Tools.Analyze_Var.analyze_var(var, false, false, false, false, false, false, true,
                                                                     false, false, false, false);
                    }, Cancel_VarToCRCAndPaths.Token);
                    SearchInsideVars_VarToCRCAndPaths_Txtbx.AppendText(var + Environment.NewLine + Sharp_VaM_Tools.Analyze_Var.Anal_CRC + Environment.NewLine);
                }
            }
            catch (OperationCanceledException)
            {
                SearchInsideVars_VarToCRCAndPaths_Txtbx.AppendText("[+] Stopped All Operations" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Analyze vars (CRC & Paths): " + "\r\n" + ex.Message + Environment.NewLine);
            }
            SearchInsideVars_AnalyzeVars_YinYang_Pic.Visible = false;
        }
        private async void SearchInsideVars_VarToCRCAndPaths_Txtbx_DragDrop(object sender, DragEventArgs e)
        {
            Cancel_VarToCRCAndPaths.Cancel();
            Cancel_VarToCRCAndPaths = new CancellationTokenSource();

            SearchInsideVars_AnalyzeVars_YinYang_Pic.Visible = true;
            try
            {
                SearchInsideVars_VarToCRCAndPaths_Txtbx.Clear();
                List<string> vars = new List<string>();
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string path in files)
                {
                    await Task.Run(() =>
                    {
                        if (System.IO.File.Exists(path) && path.EndsWith(".var"))
                        {
                            vars.Add(path);
                        }

                        if (System.IO.Directory.Exists(path))
                        {
                            string[] vars_in_dir = Directory.GetFiles(path, "*.var", SearchOption.AllDirectories);
                            vars.AddRange(vars_in_dir);
                        }
                    }, Cancel_VarToCRCAndPaths.Token);

                    foreach (string var in vars)
                    {
                        await Task.Run(() =>
                        {
                            Sharp_VaM_Tools.Analyze_Var.Anal_CRC = string.Empty;
                            Sharp_VaM_Tools.Analyze_Var.Anal_Warnings = string.Empty;
                            Sharp_VaM_Tools.Analyze_Var.analyze_var(var, false, false, false, false, false, false, true,
                                                                         false, false, false, false);
                        }, Cancel_VarToCRCAndPaths.Token);
                        SearchInsideVars_VarToCRCAndPaths_Txtbx.AppendText(var + Environment.NewLine + Sharp_VaM_Tools.Analyze_Var.Anal_CRC + Environment.NewLine);
                    }
                }
            }
            catch (OperationCanceledException)
            {
                SearchInsideVars_VarToCRCAndPaths_Txtbx.AppendText("[+] Stopped All Operations" + Environment.NewLine);
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Analyze vars (CRC & Paths): " + "\r\n" + ex.Message + Environment.NewLine);
            }
            SearchInsideVars_AnalyzeVars_YinYang_Pic.Visible = false;
        }
        private void SearchInsideVars_SearchVarToCRCAndPathsTxtbx_TextChanged(object sender, EventArgs e)
        {
            if (SearchInsideVars_SearchVarToCRCAndPathsTxtbx.Text.Trim().Length >= 3 && SearchInsideVars_VarToCRCAndPaths_Txtbx.Text.Length > 0)
            {
                SearchInsideVars_VarToCRCAndPaths_Txtbx.SelectAll(); SearchInsideVars_VarToCRCAndPaths_Txtbx.SelectionColor = Color.Black; SearchInsideVars_VarToCRCAndPaths_Txtbx.DeselectAll();
                //escaping (S),+ in file names
                Regex regex = new Regex(SearchInsideVars_SearchVarToCRCAndPathsTxtbx.Text.Replace("(", "\\(").Replace(")", "\\)").Replace("+", "\\+"), RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(SearchInsideVars_VarToCRCAndPaths_Txtbx.Text);
                if (matches.Count > 0)
                {
                    foreach (Match m in matches)
                    {
                        SearchInsideVars_VarToCRCAndPaths_Txtbx.Select(m.Index, m.Length);
                        SearchInsideVars_VarToCRCAndPaths_Txtbx.SelectionColor = Color.Red;
                    }
                    SearchInsideVars_VarToCRCAndPaths_Txtbx.Select(matches[0].Index, matches[0].Length);
                    SearchInsideVars_VarToCRCAndPaths_Txtbx.ScrollToCaret();
                }
            }
        }

        private void SearchInsideVars_CM_dataGridView_CopyPathJsonLatest_Click(object sender, EventArgs e)
        {

            if (SearchInsideVars_dataGridView.Rows.Count > 0 && SearchInsideVars_dataGridView.CurrentCell.Value.ToString().Length > 0)
            {
                int row_index = SearchInsideVars_dataGridView.CurrentCell.RowIndex;
                string value = SearchInsideVars_dataGridView.Rows[row_index].Cells[1].Value.ToString();
                value = Regex.Replace(value, @".*\s\s\s", string.Empty);
                value = Regex.Replace(value, @"\.[0-9]+:", ".latest:");
                Clipboard.SetDataObject(value);
            }

        }

        private void SearchInsideVars_CM_dataGridView_CopyCrc_Click(object sender, EventArgs e)
        {
            if (SearchInsideVars_dataGridView.Rows.Count > 0 && SearchInsideVars_dataGridView.CurrentCell.Value.ToString().Length > 0)
            {
                int row_index = SearchInsideVars_dataGridView.CurrentCell.RowIndex;
                string value = SearchInsideVars_dataGridView.Rows[row_index].Cells[1].Value.ToString();
                value = Regex.Replace(value, @"(\s\s\s.*|.*]\s)", string.Empty);
                Clipboard.SetDataObject(value);
            }
        }

        private void SearchInsideVars_CM_dataGridView_OpenVarLocation_Click(object sender, EventArgs e)
        {
            try
            {
                string[] dirs = SearchInsideVars_VarPaths_Txtbx.Text.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                if (SearchInsideVars_dataGridView.Rows.Count > 0 && SearchInsideVars_dataGridView.CurrentCell.Value.ToString().Length > 0)
                {
                    int row_index = SearchInsideVars_dataGridView.CurrentCell.RowIndex;
                    string value = SearchInsideVars_dataGridView.Rows[row_index].Cells[1].Value.ToString();
                    value = Regex.Replace(value, @"(.*\s\s\s|:/.*)", string.Empty) + ".var";
                    foreach (string dir in dirs)
                    {
                        string[] var_locations = System.IO.Directory.GetFiles(dir, value, SearchOption.AllDirectories);
                        foreach (string var_location in var_locations)
                        {
                            System.Diagnostics.Process.Start("C:\\Windows\\explorer.exe", "/select, \"" + var_location + "\"");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Open Var Location" + "\r\n" + ex.Message + Environment.NewLine);
            }

        }
        private void SearchInsideVars_CM_VarToCRCAndPaths_CopySelected_Click(object sender, EventArgs e)
        {
            if (SearchInsideVars_VarToCRCAndPaths_Txtbx.SelectedText.Length > 0)
            {
                Clipboard.SetText(SearchInsideVars_VarToCRCAndPaths_Txtbx.SelectedText);
            }
        }

        private void SearchInsideVars_CM_VarToCRCAndPaths_CopyAll_Click(object sender, EventArgs e)
        {
            if (SearchInsideVars_VarToCRCAndPaths_Txtbx.Text.Length > 0)
            {
                Clipboard.SetText(SearchInsideVars_VarToCRCAndPaths_Txtbx.Text);
            }
        }

        private void SearchInsideVars_CM_VarToCRCAndPaths_ClearAll_Click(object sender, EventArgs e)
        {
            SearchInsideVars_VarToCRCAndPaths_Txtbx.Text = string.Empty;
        }

        private void SearchInsideVars_CM_dataGridView_Copy_Click(object sender, EventArgs e)
        {
            if (SearchInsideVars_dataGridView.Rows.Count > 0)
            { Clipboard.SetDataObject(SearchInsideVars_dataGridView.GetClipboardContent()); }
        }

        private void SearchInsideVars_CM_dataGridView_CopyPathJson_Click(object sender, EventArgs e)
        {
            if (SearchInsideVars_dataGridView.Rows.Count > 0 && SearchInsideVars_dataGridView.CurrentCell.Value.ToString().Length > 0)
            { Clipboard.SetDataObject(Regex.Replace(SearchInsideVars_dataGridView.CurrentCell.Value.ToString(), @".*\s\s\s", string.Empty)); }
        }

        private void SearchInsideVars_CM_dataGridView_Bookmark_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string[] db_text = (System.IO.File.ReadAllText(SearchInsideVars_db_Path_Txtbx.Text, encoding).Split(new string[] { "\n", "\r", "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
                List<string> Replace = new List<string>();

                foreach (DataGridViewCell cell in SearchInsideVars_dataGridView.SelectedCells)
                {
                    if (cell.Value.ToString().Length > 0 && !cell.Value.ToString().StartsWith("[B]"))
                    {
                        int row_index = cell.RowIndex;
                        string old_value = SearchInsideVars_dataGridView.Rows[row_index].Cells[1].Value.ToString();
                        if (!old_value.StartsWith("[B] "))
                        {
                            SearchInsideVars_dataGridView.Rows[row_index].Cells[1].Value = "[B] " + old_value;
                            SearchInsideVars_dataGridView.Rows[row_index].DefaultCellStyle.BackColor = Color.Green;
                            Replace.Add(old_value);
                        }
                    }
                }

                using (StreamWriter sw = new StreamWriter(SearchInsideVars_db_Path_Txtbx.Text, false, encoding))
                {
                    foreach (string line in db_text)
                    {
                        if (Replace.Contains(line)) { sw.WriteLine("[B] " + line); }
                        else { sw.WriteLine(line); }
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Bookmark" + "\r\n" + ex.Message + Environment.NewLine);
            }
        }

        private void SearchInsideVars_CM_dataGridView_RemoveBookmark_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                string[] db_text = (System.IO.File.ReadAllText(SearchInsideVars_db_Path_Txtbx.Text, encoding).Split(new string[] { "\n", "\r", "\r\n" }, StringSplitOptions.RemoveEmptyEntries));
                List<string> Replace = new List<string>();

                foreach (DataGridViewCell cell in SearchInsideVars_dataGridView.SelectedCells)
                {
                    if (cell.Value.ToString().StartsWith("[B]"))
                    {
                        int row_index = cell.RowIndex;
                        string old_value = SearchInsideVars_dataGridView.Rows[row_index].Cells[1].Value.ToString();
                        if (old_value.StartsWith("[B] "))
                        {
                            SearchInsideVars_dataGridView.Rows[row_index].Cells[1].Value = old_value.Replace("[B] ", string.Empty);
                            SearchInsideVars_dataGridView.Rows[row_index].DefaultCellStyle.BackColor = Color.White;
                            Replace.Add(old_value);
                        }
                    }
                }
                using (StreamWriter sw = new StreamWriter(SearchInsideVars_db_Path_Txtbx.Text, false, encoding))
                {
                    foreach (string line in db_text)
                    {
                        if (Replace.Contains(line)) { sw.WriteLine(line.Replace("[B] ", string.Empty)); }
                        else { sw.WriteLine(line); }
                    }
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Remove Bookmark" + "\r\n" + ex.Message + Environment.NewLine);
            }

        }

        private CancellationTokenSource Cancel_VarToCRCAndPaths = new CancellationTokenSource();
        private void SearchInsideVars_CM_VarToCRCAndPaths_CancelAll_Click(object sender, EventArgs e)
        {
            Cancel_VarToCRCAndPaths.Cancel();
        }


        /// ******** Search Inside Vars End ******** ///   

        /// ******** Analyze Vars Start ******** /// 

        private void AnalyzeVars_Result_Txtbx_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private CancellationTokenSource AnalyzeVars_Cancel = new CancellationTokenSource();

        private async Task Analyze_Var(string var)
        {
            try
            {
                bool Anal_metajson = AnalyzeVars_metaJson_Chkbx.Checked;
                bool Anal_LocalRef = AnalyzeVars_LocalReferences_Chkbx.Checked;
                bool Anal_DeserializeJson = AnalyzeVars_DeserializeJson_Chkbx.Checked;
                bool Anal_Morphs = AnalyzeVars_Morphs_Chkbx.Checked;
                bool Anal_BloatedVar = AnalyzeVars_BloatedVar_Chkbx.Checked;
                bool Anal_Plugins = AnalyzeVars_DetectPlugins_Chkbx.Checked;
                bool Anal_ListVarsContent = AnalyzeVars_ListVarsContent_Chkbx.Checked;

                //trackers
                bool Anal_TamperedwithVar = AnalyzeVars_TamperedwithVar_Chkbx.Checked;
                bool Anal_NonVamImages = AnalyzeVars_NonVamImages_Chkbx.Checked;
                bool Anal_ExtractImagesExif = AnalyzeVars_ExtractImagesExif_Chkbx.Checked;
                bool Anal_ImagesMISC = AnalyzeVars_ImagesMISC_Chkbx.Checked;

                Sharp_VaM_Tools.Analyze_Var.Anal_CRC = string.Empty;
                Sharp_VaM_Tools.Analyze_Var.Anal_Warnings = string.Empty;
                await Task.Run(() =>
                {
                    Sharp_VaM_Tools.Analyze_Var.analyze_var(var, Anal_metajson, Anal_LocalRef, Anal_DeserializeJson, Anal_Morphs, Anal_BloatedVar, Anal_Plugins, Anal_ListVarsContent,
                                                                 Anal_TamperedwithVar, Anal_NonVamImages, Anal_ExtractImagesExif, Anal_ImagesMISC);
                }, AnalyzeVars_Cancel.Token);


                AnalyzeVars_Result_Txtbx.AppendText(var + Environment.NewLine);
                if (Anal_ListVarsContent == true)
                {
                    AnalyzeVars_Result_Txtbx.AppendText(Sharp_VaM_Tools.Analyze_Var.Anal_CRC + Environment.NewLine);
                }

                if (!Sharp_VaM_Tools.Analyze_Var.Anal_Warnings.Contains("[!] Warning"))
                {
                    AnalyzeVars_Result_Txtbx.AppendText("[+] var is good, no warnings: " + System.IO.Path.GetFileName(var) + Environment.NewLine + Environment.NewLine);
                }
                else
                {
                    AnalyzeVars_Result_Txtbx.AppendText(Sharp_VaM_Tools.Analyze_Var.Anal_Warnings + Environment.NewLine + Environment.NewLine);
                }
                //AnalyzeVars_Colorize_Result_Txtbx(); //very intensive, better off colorize after everything is done.
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Analyze Vars: " + "\r\n" + ex.Message + Environment.NewLine);
            }
        }
        private async void AnalyzeVars_Result_Txtbx_DragDrop(object sender, DragEventArgs e)
        {
            AnalyzeVars_Cancel.Cancel();
            AnalyzeVars_Cancel = new CancellationTokenSource();
            AnalyzeVars_Cencel_BTN.Visible = true;
            AnalyzeVars_YingYang_PIC.Visible = true;

            AnalyzeVars_Current_Txtbx = null;
            AnalyzeVars_Result_Txtbx.Text = "[+] -------------------- Analyzing Vars Started -------------------- [+]" + Environment.NewLine + Environment.NewLine;

            AnalyzeVars_YingYang_PIC.Visible = true;
            try
            {
                List<string> vars = new List<string>();
                string[] Dropped_Paths = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string path in Dropped_Paths)
                {
                    if (System.IO.File.Exists(path) && path.EndsWith(".var"))
                    {
                        vars.Add(path);
                    }

                    if (System.IO.Directory.Exists(path))
                    {
                        string[] vars_in_dir = System.IO.Directory.GetFiles(path, "*.var", SearchOption.AllDirectories);
                        vars.AddRange(vars_in_dir);
                    }
                }

                foreach (string var in vars)
                {
                    if (!AnalyzeVars_Cancel.IsCancellationRequested)
                    {
                        await Analyze_Var(var);
                    }

                }

            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Analyze Vars: " + "\r\n" + ex.Message + Environment.NewLine);
            }
            AnalyzeVars_YingYang_PIC.Visible = false;
            AnalyzeVars_Result_Txtbx.AppendText("[+] -------------------- Analyzing Vars Ended --------------------- [+]");
            AnalyzeVars_Colorize_Result_Txtbx();
        }

        private void AnalyzeVars_Colorize_Result_Txtbx()
        {
            Regex regex_Yellow = new Regex("\\[!\\] Warning.*", RegexOptions.IgnoreCase);
            MatchCollection matches_Yellow = regex_Yellow.Matches(AnalyzeVars_Result_Txtbx.Text);
            if (matches_Yellow.Count > 0)
            {
                foreach (Match m in matches_Yellow)
                {
                    AnalyzeVars_Result_Txtbx.Select(m.Index, m.Length);
                    AnalyzeVars_Result_Txtbx.SelectionColor = Color.Yellow;
                }
                AnalyzeVars_Result_Txtbx.Select(matches_Yellow[0].Index, matches_Yellow[0].Length);
            }

            Regex regex_Green = new Regex("\\[\\+\\] var is good.*", RegexOptions.IgnoreCase);
            MatchCollection matches_Green = regex_Green.Matches(AnalyzeVars_Result_Txtbx.Text);
            if (matches_Green.Count > 0)
            {
                foreach (Match m in matches_Green)
                {
                    AnalyzeVars_Result_Txtbx.Select(m.Index, m.Length);
                    AnalyzeVars_Result_Txtbx.SelectionColor = Color.Green;
                }
                AnalyzeVars_Result_Txtbx.Select(matches_Green[0].Index, matches_Green[0].Length);
            }
        }
        private async void AnalyzeVars_Browse_BTN_Click(object sender, EventArgs e)
        {
            var filedlg = new OpenFileDialog();
            filedlg.Filter = "var|*.var";
            filedlg.Multiselect = true;
            if (filedlg.ShowDialog() != DialogResult.OK)
                return;

            AnalyzeVars_Current_Txtbx = null;
            AnalyzeVars_Cancel.Cancel();
            AnalyzeVars_Cancel = new CancellationTokenSource();
            AnalyzeVars_Cencel_BTN.Visible = true;
            AnalyzeVars_YingYang_PIC.Visible = true;

            AnalyzeVars_Result_Txtbx.Text = "[+] -------------------- Analyzing Vars Started -------------------- [+]" + Environment.NewLine + Environment.NewLine;
            try
            {
                foreach (string var in filedlg.FileNames)
                {
                    if (!AnalyzeVars_Cancel.IsCancellationRequested)
                    {
                        await Analyze_Var(var);
                    }
                }
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Analyze Vars: " + "\r\n" + ex.Message + Environment.NewLine);
            }
            AnalyzeVars_YingYang_PIC.Visible = false;
            AnalyzeVars_Result_Txtbx.AppendText("[+] -------------------- Analyzing Vars Ended --------------------- [+]");

            AnalyzeVars_Colorize_Result_Txtbx();

        }

        private void AnalyzeVars_Cencel_BTN_Click(object sender, EventArgs e)
        {
            AnalyzeVars_Cancel.Cancel();
            AnalyzeVars_Result_Txtbx.Text += "[!] Stopping all operations, please wait." + Environment.NewLine;
            AnalyzeVars_Cencel_BTN.Visible = false;
        }

        private void AnalyzeVars_Search_Txtbx_TextChanged(object sender, EventArgs e)
        {
            if (AnalyzeVars_Search_Txtbx.Text.Trim().Length >= 3 && AnalyzeVars_Result_Txtbx.Text.Length > 0)
            {
                AnalyzeVars_Result_Txtbx.SelectAll(); AnalyzeVars_Result_Txtbx.SelectionColor = Color.White; AnalyzeVars_Result_Txtbx.DeselectAll();
                //escaping (,),+ in file names
                Regex regex = new Regex(AnalyzeVars_Search_Txtbx.Text.Replace("(", "\\(").Replace(")", "\\)").Replace("+", "\\+"), RegexOptions.IgnoreCase);
                MatchCollection matches = regex.Matches(AnalyzeVars_Result_Txtbx.Text);
                if (matches.Count > 0)
                {
                    foreach (Match m in matches)
                    {
                        AnalyzeVars_Result_Txtbx.Select(m.Index, m.Length);
                        AnalyzeVars_Result_Txtbx.SelectionColor = Color.Yellow;
                    }
                    AnalyzeVars_Result_Txtbx.Select(matches[0].Index, matches[0].Length);
                    AnalyzeVars_Result_Txtbx.ScrollToCaret();
                }
            }
        }

        private string AnalyzeVars_Current_Txtbx = null;
        private void AnalyzeVars_CM_Result_Txtbx_ShowWarnings_Click(object sender, EventArgs e)
        {
            AnalyzeVars_Current_Txtbx = AnalyzeVars_Result_Txtbx.Text;
            if (AnalyzeVars_Result_Txtbx.Text.Contains("[!] Warning"))
            {
                string[] lines = AnalyzeVars_Result_Txtbx.Text.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                AnalyzeVars_Result_Txtbx.Clear();
                foreach (string line in lines)
                {
                    if (line.StartsWith("[!] "))
                    {
                        AnalyzeVars_Result_Txtbx.AppendText(line + Environment.NewLine);
                    }
                }

            }
            else
            {
                AnalyzeVars_Result_Txtbx.Text = "[+] No warnings, everything is good.";
            }
            AnalyzeVars_Colorize_Result_Txtbx();
        }

        private void AnalyzeVars_CM_Result_Txtbx_CopyWarnings_Click(object sender, EventArgs e)
        {
            string Warnings = string.Empty;
            if (AnalyzeVars_Result_Txtbx.Text.Contains("[!] Warning"))
            {
                string[] lines = AnalyzeVars_Result_Txtbx.Text.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string line in lines)
                {
                    if (line.StartsWith("[!] "))
                    {
                        Warnings += line + Environment.NewLine;
                    }

                }
                Clipboard.SetText(Warnings);
            }
        }

        private void AnalyzeVars_CM_Result_Txtbx_GoBack_Click(object sender, EventArgs e)
        {
            AnalyzeVars_Result_Txtbx.Clear();
            AnalyzeVars_Result_Txtbx.Text = AnalyzeVars_Current_Txtbx;
            AnalyzeVars_Colorize_Result_Txtbx();
        }

        private void AnalyzeVars_CM_Result_Txtbx_CopySelected_Click(object sender, EventArgs e)
        {
            if (AnalyzeVars_Result_Txtbx.SelectedText.Length > 0)
            {
                Clipboard.SetText(AnalyzeVars_Result_Txtbx.SelectedText);
            }
        }

        private void AnalyzeVars_CM_Result_Txtbx_CopyAllText_Click(object sender, EventArgs e)
        {
            if (AnalyzeVars_Result_Txtbx.Text.Length > 0)
            {
                Clipboard.SetText(AnalyzeVars_Result_Txtbx.Text);
            }
        }

        private void AnalyzeVars_CM_Result_Txtbx_Clear_Click(object sender, EventArgs e)
        {
            AnalyzeVars_Result_Txtbx.Clear();
        }

        /// ******** Analyze Vars End ******** /// 

        /// ******** Security Start ******** ///   
        private void Security_Browse_BTN_Click(object sender, EventArgs e)
        {
            var OpenFileDialog = new OpenFileDialog();
            OpenFileDialog.Multiselect = true;
            OpenFileDialog.Filter = "Var|*.var|Zip|*.zip|Rar|*.rar";
            if (OpenFileDialog.ShowDialog() != DialogResult.OK)
                return;

            List<string> lines = Security_VarsToScan_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
            foreach (string file in OpenFileDialog.FileNames)
            {
                if (!lines.Contains(file))
                {
                    if (!Security_VarsToScan_Txtbx.Text.EndsWith("\n")) { SearchMyFolders_VarsLocations_Txtbx.AppendText(Environment.NewLine); }
                    Security_VarsToScan_Txtbx.AppendText(file + Environment.NewLine);
                }
            }

        }

        private void Security_CM_VarsToScan_Txtbx_Clear_Click(object sender, EventArgs e)
        {
            Security_VarsToScan_Txtbx.Clear();
        }

        private CancellationTokenSource Cancel_SecurityScan = new CancellationTokenSource();

        private void Security_Scan_Colorize_Txtbx()
        {
            Regex regex_Green = new Regex("(Var contains clean plugins|Var does not contain any plugins)", RegexOptions.IgnoreCase);
            MatchCollection matches_Green = regex_Green.Matches(Security_ScanResultSuspecious_Txtbx.Text);
            if (matches_Green.Count > 0)
            {
                foreach (Match m in matches_Green)
                {
                    Security_ScanResultSuspecious_Txtbx.Select(m.Index, m.Length);
                    Security_ScanResultSuspecious_Txtbx.SelectionColor = Color.Green;
                }
                Security_ScanResultSuspecious_Txtbx.Select(matches_Green[0].Index, matches_Green[0].Length);

            }

            Regex regex_Sus = new Regex("(Keyword:.*)", RegexOptions.IgnoreCase);
            MatchCollection matches_Sus = regex_Sus.Matches(Security_ScanResultSuspecious_Txtbx.Text);
            if (matches_Sus.Count > 0)
            {
                foreach (Match m in matches_Sus)
                {
                    Security_ScanResultSuspecious_Txtbx.Select(m.Index, m.Length);
                    Security_ScanResultSuspecious_Txtbx.SelectionColor = Color.Red;
                }
                Security_ScanResultSuspecious_Txtbx.Select(matches_Sus[0].Index, matches_Sus[0].Length);

            }
            Regex regex_Malware = new Regex("(Keyword:.*|Clean)", RegexOptions.IgnoreCase);
            MatchCollection matches_Malware = regex_Malware.Matches(Security_ScanResultMalware_Txtbx.Text);
            if (matches_Malware.Count > 0)
            {
                foreach (Match m in matches_Malware)
                {
                    Security_ScanResultMalware_Txtbx.Select(m.Index, m.Length);
                    Security_ScanResultMalware_Txtbx.SelectionColor = Color.Black;
                }
                Security_ScanResultMalware_Txtbx.Select(matches_Malware[0].Index, matches_Malware[0].Length);
            }
        }
        private async void Security_Scan_BTN_Click(object sender, EventArgs e)
        {
            Boss_Fine_PIC.Visible = Fine_PIC.Visible = false;
            if (!Directory.Exists("C:\\Windows\\temp\\SharpVamTools\\"))
            {
                try
                {
                    System.IO.Directory.CreateDirectory("C:\\Windows\\temp\\SharpVamTools\\");
                }
                catch (Exception ex)
                {
                    Security_ScanResultMalware_Txtbx.Text = ex.Message + Environment.NewLine;
                    return;
                }
            }

            if (Security_Scan_BTN.Text == "Scanning...")
            {
                Cancel_SecurityScan.Cancel();
                Security_Scan_BTN.Text = "Scan";
                return;
            }
            Cancel_SecurityScan.Cancel();
            Cancel_SecurityScan = new CancellationTokenSource();
            var cancellationToken = Cancel_SecurityScan.Token;

            Security_Scan_BTN.Text = "Scanning...";
            Security_YinYang_Scan.Visible = true;
            try
            {
                Security_ScanResultSuspecious_Txtbx.Text = Security_ScanResultMalware_Txtbx.Text = "[+] =============== Scan Started at: " + DateTime.Now + " =============== [+]" + Environment.NewLine + Environment.NewLine;
                string[] vars = Security_VarsToScan_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

                bool escape_ApplicationURL = Security_escape_ApplicationOpenURL_Chkbx.Checked;
                bool escape_FileMangementSecure = Security_escape_FileMangementSecure_Chkbx.Checked;
                bool escape_EventTrigger = Security_escape_EventTrigger_Chkbx.Checked;
                bool escape_assetbundles = Security_escape_Assetbundles_Chkbx.Checked;

                foreach (string var in vars)
                {
                    if (!cancellationToken.IsCancellationRequested)
                    {
                        await Sharp_VaM_Tools.Security.Security_Scan(var, escape_ApplicationURL, escape_FileMangementSecure, escape_EventTrigger, escape_assetbundles);
                        Security_ScanResultSuspecious_Txtbx.AppendText(Environment.NewLine + "################## Scanning: " + System.IO.Path.GetFileName(var) + " ##################" + Environment.NewLine + Environment.NewLine);
                        Security_ScanResultSuspecious_Txtbx.Text += Sharp_VaM_Tools.Security.Result_Suspicious;
                        if (!Security_EscapeClean_Chkbx.Checked)
                        {
                            Security_ScanResultMalware_Txtbx.AppendText(Environment.NewLine + "################## Scanning: " + System.IO.Path.GetFileName(var) + " ##################" + Environment.NewLine + Environment.NewLine);
                            Security_ScanResultMalware_Txtbx.Text += Sharp_VaM_Tools.Security.Result_Malware;
                        }
                        if (Security_EscapeClean_Chkbx.Checked && !Sharp_VaM_Tools.Security.Result_Malware.StartsWith("[+] Clean"))
                        {
                            Security_ScanResultMalware_Txtbx.AppendText(Environment.NewLine + "################## Scanning: " + System.IO.Path.GetFileName(var) + " ##################" + Environment.NewLine + Environment.NewLine);
                            Security_ScanResultMalware_Txtbx.Text += Sharp_VaM_Tools.Security.Result_Malware;
                        }

                        //Security_Scan_Colorize_Txtbx();
                    }
                }
                Security_ScanResultSuspecious_Txtbx.Text += "[+] =============== Scan Ended at: " + DateTime.Now + " =============== [+]";
                Security_ScanResultMalware_Txtbx.Text += "\r\n[+] =============== Scan Ended at: " + DateTime.Now + " =============== [+]";



            }
            catch (OperationCanceledException) { Security_Scan_BTN.Text = "Scan"; }
            catch (Exception ex)
            {
                Security_ScanResultSuspecious_Txtbx.Text += ex.Message + Environment.NewLine;
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= Security Scan (" + DateTime.Now + ")" + "\r\n" + ex.Message + Environment.NewLine + Environment.NewLine);
            }
            Security_Scan_BTN.Text = "Scan";
            Security_YinYang_Scan.Visible = false;
            Security_Scan_Colorize_Txtbx();
        }

        private void MISC_CM_Output_Txtbx_Clear_Click(object sender, EventArgs e)
        {
            MISC_Output_Txtbx.Text = string.Empty;
        }

        private void Security_CM_ScanResultSuspecious_Txtbx_CopySelected_Click(object sender, EventArgs e)
        {
            if (Security_ScanResultSuspecious_Txtbx.Text.Length > 0) { Clipboard.SetText(Security_ScanResultSuspecious_Txtbx.SelectedText); }

        }

        private void Security_CM_ScanResultSuspecious_Txtbx_CopyAll_Click(object sender, EventArgs e)
        {
            if (Security_ScanResultSuspecious_Txtbx.Text.Length > 0) { Clipboard.SetText(Security_ScanResultSuspecious_Txtbx.Text); }

        }

        private void Security_CM_ScanResultSuspecious_Txtbx_ClearAll_Click(object sender, EventArgs e)
        {
            Security_ScanResultSuspecious_Txtbx.Text = string.Empty;
        }


        private void Security_CM_ScanResultMalware_Txtbx_CopySelected_Click(object sender, EventArgs e)
        {
            if (Security_ScanResultMalware_Txtbx.Text.Length > 0) { Clipboard.SetText(Security_ScanResultMalware_Txtbx.SelectedText); }

        }

        private void Security_CM_ScanResultMalware_Txtbx_CopyAll_Click(object sender, EventArgs e)
        {
            if (Security_ScanResultMalware_Txtbx.Text.Length > 0) { Clipboard.SetText(Security_ScanResultMalware_Txtbx.Text); }

        }

        private void Security_CM_ScanResultMalware_Txtbx_ClearAll_Click(object sender, EventArgs e)
        {
            Security_ScanResultMalware_Txtbx.Text = string.Empty;

        }

        private void Security_VarsToScan_Txtbx_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void Security_VarsToScan_Txtbx_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                if (Directory.Exists(file))
                {
                    string[] vars_in_dir = Directory.GetFiles(file, "*.var", SearchOption.AllDirectories);
                    foreach (string var in vars_in_dir) { Security_VarsToScan_Txtbx.AppendText((var) + Environment.NewLine); }
                }

                if (file.EndsWith(".var") || file.EndsWith(".zip") || file.EndsWith(".rar") || file.EndsWith(".vac"))
                {
                    Security_VarsToScan_Txtbx.AppendText(file + Environment.NewLine);
                }
            }
        }

        /// ******** Security End ******** ///   

        /// ******** MISC Start ******** ///   
        /// 

        private void MoveToRecyclebin(string file)
        {
            FileSystem.DeleteFile(file, Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
                                    Microsoft.VisualBasic.FileIO.RecycleOption.SendToRecycleBin,
                                    Microsoft.VisualBasic.FileIO.UICancelOption.ThrowException);
        }
        private CancellationTokenSource MISC_Cancel = new CancellationTokenSource();
        private void MISC_Stop_BTN_Click(object sender, EventArgs e)
        {
            MISC_Cancel.Cancel();
            MISC_Output_Txtbx.Text += "[!] Stopping all operations, please wait." + Environment.NewLine;
            MISC_Stop_BTN.Visible = false;
            foreach (var process in Process.GetProcessesByName("bz"))
            {
                process.Kill();
            }
        }

        private async void MISC_DeleteDuplicateVars_BTN_Click(object sender, EventArgs e)
        {
            MISC_Cancel.Cancel(); MISC_Stop_BTN.Visible = true;
            MISC_Cancel = new CancellationTokenSource();
            var cancellationToken = MISC_Cancel.Token;
            MISC_YingYang0_PIC.Visible = true; MISC_YingYang1_PIC.Visible = true;

            MISC_Output_Txtbx.Text = "[+] -------------------- Removing Duplicate Vars Started -------------------- [+]" + Environment.NewLine;
            string[] Paths = MISC_Paths_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            List<string> vars = new List<string>();
            List<string> vars_no_duplicates = new List<string>();

            foreach (string path in Paths)
            {
                if (MISC_Cancel.IsCancellationRequested) { break; }
                await Task.Run(() =>
                {
                    vars.Clear(); vars_no_duplicates.Clear();
                    vars.AddRange(Directory.GetFiles(path, "*.var", SearchOption.AllDirectories).ToList<string>());
                });


                foreach (string var in vars)
                {
                    try
                    {
                        if (MISC_Cancel.IsCancellationRequested) { break; }
                        string log = string.Empty;
                        await Task.Run(() =>
                        {
                            if (!Regex.IsMatch(System.IO.Path.GetFileName(var), @"\..*?\.[0-9]+.var"))
                            {
                                try
                                {
                                    //System.IO.File.Delete(var);
                                    MoveToRecyclebin(var);
                                    if (File.Exists(Regex.Replace(var, @"\.var$", ".jpg"))) { MoveToRecyclebin(Regex.Replace(var, @"\.var$", ".jpg")); }
                                    if (File.Exists(Regex.Replace(var, @"\.var$", ".jpeg"))) { MoveToRecyclebin(Regex.Replace(var, @"\.var$", ".jpeg")); }
                                    if (File.Exists(Regex.Replace(var, @"\.var$", ".png"))) { MoveToRecyclebin(Regex.Replace(var, @"\.var$", ".png")); }
                                    log = "[+] Deleted (Moved to Recyclebin): " + var + Environment.NewLine;
                                }
                                catch (Exception ex)
                                {
                                    log = "[!] Unable to delete: " + var + Environment.NewLine + ex.Message + Environment.NewLine;
                                }
                                goto done;
                            }

                            if (!vars_no_duplicates.Any(v => v.EndsWith(System.IO.Path.GetFileName(var))))
                            {
                                vars_no_duplicates.Add(var);
                            }
                            else
                            {
                                string var_in_list2 = vars_no_duplicates.First(v => v.EndsWith(System.IO.Path.GetFileName(var)));
                                string Creator = System.IO.Path.GetFileName(var).Substring(0, System.IO.Path.GetFileName(var).IndexOf(".")).Trim();

                                if (var.EndsWith(Creator + "\\" + System.IO.Path.GetFileName(var)))
                                {
                                    try
                                    {

                                        log += "[+] Deleted (Moved to Recyclebin): " + var_in_list2 + Environment.NewLine;
                                        // System.IO.File.Delete(var_in_list2);
                                        MoveToRecyclebin(var_in_list2);
                                        if (File.Exists(Regex.Replace(var_in_list2, @"\.var$", ".jpg"))) { MoveToRecyclebin(Regex.Replace(var_in_list2, @"\.var$", ".jpg")); }
                                        if (File.Exists(Regex.Replace(var_in_list2, @"\.var$", ".jpeg"))) { MoveToRecyclebin(Regex.Replace(var_in_list2, @"\.var$", ".jpeg")); }
                                        if (File.Exists(Regex.Replace(var_in_list2, @"\.var$", ".png"))) { MoveToRecyclebin(Regex.Replace(var_in_list2, @"\.var$", ".png")); }
                                    }
                                    catch (Exception ex)
                                    {
                                        log += "[+] Can't delete: " + var_in_list2 + Environment.NewLine + ex.Message + Environment.NewLine;

                                    }
                                    goto done;
                                }
                                if (var_in_list2.EndsWith(Creator + "\\" + System.IO.Path.GetFileName(var)) || var_in_list2.EndsWith("_MIXED_VARs" + "\\" + System.IO.Path.GetFileName(var)))
                                {
                                    try
                                    {
                                        //System.IO.File.Delete(var);
                                        MoveToRecyclebin(var);
                                        if (File.Exists(Regex.Replace(var, @"\.var$", ".jpg"))) { MoveToRecyclebin(Regex.Replace(var, @"\.var$", ".jpg")); }
                                        if (File.Exists(Regex.Replace(var, @"\.var$", ".jpeg"))) { MoveToRecyclebin(Regex.Replace(var, @"\.var$", ".jpeg")); }
                                        if (File.Exists(Regex.Replace(var, @"\.var$", ".png"))) { MoveToRecyclebin(Regex.Replace(var, @"\.var$", ".png")); }
                                        log += "[+] Deleted (Moved to Recyclebin): " + var + Environment.NewLine;
                                    }
                                    catch (Exception ex)
                                    {
                                        log += "[+] Can't delete: " + var + Environment.NewLine + ex.Message + Environment.NewLine;
                                    }
                                    goto done;
                                }

                                else
                                {
                                    try
                                    {
                                        //System.IO.File.Delete(var);
                                        MoveToRecyclebin(var);
                                        if (File.Exists(Regex.Replace(var, @"\.var$", ".jpg"))) { MoveToRecyclebin(Regex.Replace(var, @"\.var$", ".jpg")); }
                                        if (File.Exists(Regex.Replace(var, @"\.var$", ".jpeg"))) { MoveToRecyclebin(Regex.Replace(var, @"\.var$", ".jpeg")); }
                                        if (File.Exists(Regex.Replace(var, @"\.var$", ".png"))) { MoveToRecyclebin(Regex.Replace(var, @"\.var$", ".png")); }
                                        log += "[+] Deleted: " + var + Environment.NewLine;
                                    }
                                    catch (Exception ex)
                                    {
                                        log += "[+] Can't delete: " + var + Environment.NewLine + ex.Message + Environment.NewLine;
                                    }
                                }
                            }
                        done:;

                        });
                        if (log != String.Empty)
                        {
                            MISC_Output_Txtbx.AppendText(log);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Removing Duplicate Vars: " + var + "\r\n" + ex.Message + Environment.NewLine);
                    }
                }

            }
            MISC_Output_Txtbx.AppendText("[+] -------------------- Removing Duplicate Vars Ended --------------------- [+]" + Environment.NewLine);
            MISC_YingYang0_PIC.Visible = false; MISC_YingYang1_PIC.Visible = false;
            MISC_Stop_BTN.Visible = false;
        }

        private async void MISC_MoveVars_BTN_Click(object sender, EventArgs e)
        {
            MISC_Cancel.Cancel(); MISC_Stop_BTN.Visible = true;
            MISC_Cancel = new CancellationTokenSource();
            var cancellationToken = MISC_Cancel.Token;
            MISC_YingYang0_PIC.Visible = true; MISC_YingYang1_PIC.Visible = true;

            MISC_Output_Txtbx.Text = "[+] -------------------- Moving Vars Started -------------------- [+]" + Environment.NewLine;
            string[] Paths = MISC_Paths_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string path in Paths)
            {
                if (MISC_Cancel.IsCancellationRequested) { break; }
                string path_Fixed = path;
                if (path.EndsWith("\\")) { path_Fixed = path.Remove(path.LastIndexOf("\\")); }
                if (System.IO.Directory.Exists(path_Fixed + "\\Addonpackages")) { path_Fixed = path_Fixed + "\\Addonpackages"; }

                foreach (string var_path in Directory.GetFiles(path_Fixed, "*.var", SearchOption.AllDirectories))
                {
                    if (MISC_Cancel.IsCancellationRequested) { break; }
                    string log = string.Empty;
                    await Task.Run(() =>
                    {
                        string var_path_Fixed = var_path.ToLower();
                        string var_name = System.IO.Path.GetFileName(var_path);
                        string creator = var_name.Substring(0, var_name.IndexOf(".")).Trim();
                        if (System.IO.Directory.Exists(path_Fixed + "\\" + creator) && !var_path_Fixed.Contains("\\" + creator.ToLower() + "\\"))
                        {
                            try
                            {
                                Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(var_path, path_Fixed + "\\" + creator + "\\" + var_name, true);

                                //Move Images
                                if (System.IO.File.Exists(Regex.Replace(var_path, @"\.var$", ".jpg")))
                                {
                                    Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(Regex.Replace(var_path, @"\.var$", ".jpg"), path_Fixed + "\\" + creator + "\\" + Regex.Replace(var_name, @"\.var$", ".jpg"), true);
                                }
                                if (System.IO.File.Exists(Regex.Replace(var_path, @"\.var$", ".jpeg")))
                                {

                                    Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(Regex.Replace(var_path, @"\.var$", ".jpeg"), path_Fixed + "\\" + creator + "\\" + Regex.Replace(var_name, @"\.var$", ".jpeg"), true);
                                }
                                if (System.IO.File.Exists(Regex.Replace(var_path, @"\.var$", ".png")))
                                {
                                    Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(Regex.Replace(var_path, @"\.var$", ".png"), path_Fixed + "\\" + creator + "\\" + Regex.Replace(var_name, @"\.var$", ".png"), true);
                                }
                                if (System.IO.File.Exists(Regex.Replace(var_path, @"\.var$", ".var.disabled")))
                                {
                                    Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(Regex.Replace(var_path, @"\.var$", ".var.disabled"), path_Fixed + "\\" + creator + "\\" + Regex.Replace(var_name, @"\.var$", ".var.disabled"), true);
                                }
                                //System.IO.File.Move(var_path, path_Fixed + "\\" + creator + "\\" + var_name);
                                log = "[+] Moved: " + var_path + " ---> " + path_Fixed + "\\" + creator + "\\" + var_name + Environment.NewLine;
                            }
                            catch (Exception ex)
                            {
                                log = "[!] Can't move: " + var_path + Environment.NewLine + ex.Message + Environment.NewLine;
                            }

                        }

                        if (System.IO.Directory.Exists(path_Fixed + "\\_MIXED_VARs") && !System.IO.Directory.Exists(path_Fixed + "\\" + creator) && var_path_Fixed.EndsWith("\\addonpackages\\" + var_name.ToLower()))
                        {
                            try
                            {
                                Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(var_path, path_Fixed + "\\_MIXED_VARs\\" + var_name, true);
                                if (System.IO.File.Exists(Regex.Replace(var_path, @"\.var$", ".jpg")))
                                {

                                    Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(Regex.Replace(var_path, @"\.var$", ".jpg"), path_Fixed + "\\_MIXED_VARs\\" + Regex.Replace(var_name, @"\.var$", ".jpg"), true);
                                }
                                if (System.IO.File.Exists(Regex.Replace(var_path, @"\.var$", ".jpeg")))
                                {

                                    Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(Regex.Replace(var_path, @"\.var$", ".jpeg"), path_Fixed + "\\_MIXED_VARs\\" + Regex.Replace(var_name, @"\.var$", ".jpeg"), true);
                                }
                                if (System.IO.File.Exists(Regex.Replace(var_path, @"\.var$", ".png")))
                                {
                                    Microsoft.VisualBasic.FileIO.FileSystem.MoveFile(Regex.Replace(var_path, @"\.var$", ".jpeg"), path_Fixed + "\\_MIXED_VARs\\" + Regex.Replace(var_name, @"\.var$", ".jpeg"), true);
                                }

                                log = "[+] Moved: " + var_path + " ---> " + path_Fixed + "\\_MIXED_VARs\\" + var_name + Environment.NewLine;
                            }
                            catch (Exception ex)
                            {
                                log = "[!] Can't move: " + var_path + Environment.NewLine + ex.Message + Environment.NewLine;
                            }
                        }

                    });
                    MISC_Output_Txtbx.AppendText(log);
                }
            }
            MISC_Output_Txtbx.AppendText("[+] -------------------- Moving Vars Ended --------------------- [+]");
            MISC_YingYang0_PIC.Visible = false; MISC_YingYang1_PIC.Visible = false;
            MISC_Stop_BTN.Visible = false;

        }

        private void MISC_Browse_BTN_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog fdialog = new CommonOpenFileDialog();
            fdialog.InitialDirectory = "C:\\";
            fdialog.IsFolderPicker = true;
            if (fdialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                List<string> lines = MISC_Paths_Txtbx.Text.ToLower().Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!lines.Contains(fdialog.FileName.ToLower()))
                {
                    if (!(MISC_Paths_Txtbx.Text.EndsWith("\n")))
                    {
                        MISC_Paths_Txtbx.AppendText(Environment.NewLine);
                    }

                    MISC_Paths_Txtbx.AppendText(fdialog.FileName + Environment.NewLine);
                }
            }

        }

        private async void MISC_ExtractImagesScene1_BTN_Click(object sender, EventArgs e)
        {
            MISC_Cancel.Cancel(); MISC_Stop_BTN.Visible = true;
            MISC_Cancel = new CancellationTokenSource();
            var cancellationToken = MISC_Cancel.Token;

            MISC_Output_Txtbx.Text = "[+] -------------------- Extracting Images Started -------------------- [+]" + Environment.NewLine;
            string[] Paths = MISC_Paths_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string path in Paths)
            {
                foreach (string var in Directory.GetFiles(path, "*.var", SearchOption.AllDirectories))
                {
                    if (!MISC_OverwriteImages_Chkbx.Checked && (System.IO.File.Exists(var.Substring(0, var.LastIndexOf(".")) + ".jpg")))
                    {
                        goto skip;
                    }
                    try
                    {
                        if (MISC_Cancel.IsCancellationRequested) { break; }
                        string log = string.Empty;
                        await Task.Run(() =>
                        {
                            var opts = new SharpCompress.Readers.ReaderOptions();
                            opts.ArchiveEncoding.Default = encoding;
                            string Scenejson_entry = string.Empty;
                            using (Stream stream = System.IO.File.OpenRead(var))
                            using (var reader = ReaderFactory.Open(stream, opts))
                            {
                                while (reader.MoveToNextEntry())
                                {
                                    if (reader.Entry.Key.EndsWith(".json") && reader.Entry.Key.ToLower().Contains("saves/"))
                                    {
                                        Scenejson_entry = reader.Entry.Key;
                                        break;
                                    }
                                }
                            }
                            using (Stream stream = System.IO.File.OpenRead(var))
                            using (var reader = ReaderFactory.Open(stream, opts))
                            {
                                while (reader.MoveToNextEntry())
                                {
                                    if (reader.Entry.Key.Equals(Regex.Replace(Scenejson_entry, @"\.json$", ".jpg")))
                                    {
                                        try
                                        {
                                            reader.WriteEntryToFile(Regex.Replace(var, @"\.var$", ".jpg"));
                                            log = "[+] " + Regex.Replace(var, @"\.var$", ".jpg") + Environment.NewLine;
                                        }
                                        catch (Exception ex)
                                        {
                                            log = "[!] Error extracting image: " + Regex.Replace(var, @"\.var$", ".jpg") + Environment.NewLine + ex + Environment.NewLine;
                                        }
                                    }
                                }

                            }
                        });
                        MISC_Output_Txtbx.AppendText(log);
                    }
                    catch (Exception ex)
                    {
                        System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Extracting Images: " + var + "\r\n" + ex.Message + Environment.NewLine);
                    }
                skip:;
                }

            }
            MISC_Output_Txtbx.AppendText("[+] -------------------- Extracting Images Ended --------------------- [+]");
            MISC_Stop_BTN.Visible = false;
        }



        private async void MISC_DeleteCorruptedVars_BTN_Click(object sender, EventArgs e)
        {
            MISC_Cancel.Cancel(); MISC_Stop_BTN.Visible = true;
            MISC_Cancel = new CancellationTokenSource();
            var cancellationToken = MISC_Cancel.Token;
            MISC_YingYang0_PIC.Visible = true; MISC_YingYang1_PIC.Visible = true;

            MISC_Output_Txtbx.Text = "[+] -------------------- Deleting Corrupted / Empty Vars Started -------------------- [+]" + Environment.NewLine;
            string[] Paths = MISC_Paths_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string path in Paths)
            {
                foreach (string var in Directory.GetFiles(path, "*.var", SearchOption.AllDirectories))
                {
                    string log = string.Empty;
                    int Entries = 0;
                    try
                    {
                        if (MISC_Cancel.IsCancellationRequested) { break; }
                        await Task.Run(() =>
                        {

                            var opts = new SharpCompress.Readers.ReaderOptions();
                            opts.ArchiveEncoding.Default = encoding;
                            string Scenejson_entry = string.Empty;
                            using (Stream stream = System.IO.File.OpenRead(var))
                            using (var reader = ReaderFactory.Open(stream, opts))
                            {
                                while (reader.MoveToNextEntry())
                                {
                                    //var must have either custom or saves dirs and at least 1 file inside
                                    if (Regex.IsMatch(reader.Entry.Key, @"(^custom/.*\.|^saves/.*\.)", RegexOptions.IgnoreCase))
                                    {
                                        Entries++;
                                    }
                                }
                            }
                            if (Entries == 0)
                            {
                                //System.IO.File.Delete(var);
                                MoveToRecyclebin(var);
                                log = "[!] Moved empty var to recyclebin: " + var + Environment.NewLine;
                            }
                        });
                    }
                    catch (Exception ex)
                    {
                        //System.IO.File.Delete(var);
                        MoveToRecyclebin(var);
                        log = "[!] Moved bad/corrupted var to recyclebin: " + var + Environment.NewLine + "[!] Reason ---> " + ex.Message + Environment.NewLine;
                    }
                    MISC_Output_Txtbx.AppendText(log);
                }
            }
            MISC_Output_Txtbx.AppendText("[+] -------------------- Deleting Corrupted / Empty Vars Ended --------------------- [+]");
            MISC_YingYang0_PIC.Visible = false; MISC_YingYang1_PIC.Visible = false;
            MISC_Stop_BTN.Visible = false;

        }

        private async void MISC_ExtractChineseArchives_BTN_Click(object sender, EventArgs e)
        {
            var filedlg = new OpenFileDialog();
            filedlg.Filter = "Archives|*.zip;*.rar;*.7z";
            filedlg.Multiselect = true;
            if (filedlg.ShowDialog() != DialogResult.OK)
                return;

            MISC_Cancel.Cancel(); MISC_Stop_BTN.Visible = true;
            MISC_Cancel = new CancellationTokenSource();
            var cancellationToken = MISC_Cancel.Token;
            MISC_Output_Txtbx.Text = "[+] -------------------- Extracting Chinese Archives Started -------------------- [+]" + Environment.NewLine;
            MISC_YingYang0_PIC.Visible = true; MISC_YingYang1_PIC.Visible = true;


            string archivesPassword = Microsoft.VisualBasic.Interaction.InputBox("Enter password, leave it empty if there is no password", "Password", "");

            foreach (var file in filedlg.FileNames)
            {
                string log = string.Empty;
                try
                {
                    if (MISC_Cancel.IsCancellationRequested) { break; }
                    await Task.Run(() =>
                    {
                        string dir = System.IO.Path.GetDirectoryName(file);
                        Process p = new Process();
                        p.StartInfo.UseShellExecute = false;
                        p.StartInfo.RedirectStandardOutput = true;
                        p.StartInfo.StandardOutputEncoding = Encoding.GetEncoding("GB2312");
                        p.StartInfo.CreateNoWindow = true;
                        p.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\_Tools\\bandizip\\bz.exe";
                        if (archivesPassword.Length > 0)
                        {
                            p.StartInfo.Arguments = "x -y -aoa -cp:936 -p:\"" + archivesPassword + "\"" + " \"" + file + "\" " + "\"" + dir + "\"";

                        }
                        else
                        {
                            p.StartInfo.Arguments = "x -y -aoa -cp:936" + " \"" + file + "\" " + "\"" + dir + "\"";
                        }
                        p.Start();
                        while (!p.HasExited)
                        {
                            log = p.StandardOutput.ReadToEnd();
                        }
                    });
                    MISC_Output_Txtbx.AppendText(log + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    log = "[!] Error While Extracting Chinese Archive: " + file + Environment.NewLine + "[!] Reason ---> " + ex.Message + Environment.NewLine;
                }
            }
            MISC_Output_Txtbx.AppendText("[+] -------------------- Extracting Chinese Archives Ended --------------------- [+]");
            MISC_Stop_BTN.Visible = false;
            MISC_YingYang0_PIC.Visible = false; MISC_YingYang1_PIC.Visible = false;
        }

        private async void MISC_ExtractImagesScene2_BTN_Click(object sender, EventArgs e)
        {
            MISC_Cancel.Cancel(); MISC_Stop_BTN.Visible = true;
            MISC_Cancel = new CancellationTokenSource();
            var cancellationToken = MISC_Cancel.Token;
            MISC_YingYang0_PIC.Visible = true; MISC_YingYang1_PIC.Visible = true;
            MISC_Output_Txtbx.Text = "[+] -------------------- Extracting Images (Scene #2) Started -------------------- [+]" + Environment.NewLine + Environment.NewLine;
            string[] Paths = MISC_Paths_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string path in Paths)
            {
                foreach (string var in Directory.GetFiles(path, "*.var", SearchOption.AllDirectories))
                {
                    if (!MISC_OverwriteImages_Chkbx.Checked && (System.IO.File.Exists(var.Substring(0, var.LastIndexOf(".")) + ".jpg")))
                    {
                        goto skip;
                    }
                    try
                    {
                        if (MISC_Cancel.IsCancellationRequested) { break; }
                        string log = string.Empty;
                        await Task.Run(() =>
                        {
                            var opts = new SharpCompress.Readers.ReaderOptions();
                            opts.ArchiveEncoding.Default = encoding;
                            List<string> Scene_entries = new List<string>();

                            using (Stream stream = System.IO.File.OpenRead(var))
                            using (var reader = ReaderFactory.Open(stream, opts))
                            {
                                while (reader.MoveToNextEntry())
                                {
                                    if ((reader.Entry.Key.ToLower().EndsWith(".json")) && (reader.Entry.Key.ToLower().Contains("saves/scene")))
                                    {
                                        Scene_entries.Add(reader.Entry.Key);
                                    }
                                }
                            }

                            string tmp_dir = System.IO.Path.GetDirectoryName(var) + "\\tmp_SceneImages";
                            System.IO.Directory.CreateDirectory(tmp_dir);

                            foreach (string entry in Scene_entries)
                            {
                                using (Stream stream = System.IO.File.OpenRead(var))
                                using (var reader = ReaderFactory.Open(stream, opts))
                                {
                                    while (reader.MoveToNextEntry())
                                    {
                                        if (reader.Entry.Key.Equals(Regex.Replace(entry, @"\.json$", ".jpg")))
                                        {
                                            try
                                            {
                                                reader.WriteEntryToFile(tmp_dir + "\\" + reader.Entry.Key.Substring(reader.Entry.Key.LastIndexOf("/") + 1));
                                            }
                                            catch (Exception ex)
                                            {
                                                log += "[!] Error extracting images for: " + var + Environment.NewLine + ex + Environment.NewLine;
                                            }
                                        }
                                    }

                                }
                            }

                            string[] jpegs = Directory.GetFiles(tmp_dir, "*.jpg");
                            if (jpegs.Count() == 0)
                            {
                                log += "[!] Couldn't find scene preview images for: " + var + Environment.NewLine;
                                goto done;
                            }

                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\_Tools\\ImageMagick\\montage.exe";
                            p.StartInfo.Arguments = "-geometry 600x600+3+3 -frame 6 -title " + "\"" + System.IO.Path.GetFileName(var) + "\"" + " -font \"Microsoft-JhengHei-Bold-&-Microsoft-JhengHei-UI-Bold\"" + " \"" + tmp_dir + "\\*.jpg\" " + "\"" + System.IO.Path.GetDirectoryName(var) + "\\" + System.IO.Path.GetFileNameWithoutExtension(var) + ".jpg\"";
                            p.Start();
                            while (!p.HasExited)
                            {
                            }
                            if (System.IO.File.Exists(System.IO.Path.GetDirectoryName(var) + "\\" + System.IO.Path.GetFileNameWithoutExtension(var) + ".jpg"))
                            {
                                log += "[+] " + System.IO.Path.GetDirectoryName(var) + "\\" + System.IO.Path.GetFileNameWithoutExtension(var) + ".jpg" + Environment.NewLine;
                            }

                        done:;
                            System.IO.Directory.Delete(tmp_dir, true);
                        });
                        if (log.Length > 0)
                        {
                            MISC_Output_Txtbx.AppendText(log + Environment.NewLine);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Extracting Images (Scene #2): " + var + "\r\n" + ex.Message + Environment.NewLine);
                    }
                skip:;
                }

            }
            MISC_Output_Txtbx.AppendText("[+] -------------------- Extracting Images (Scene #2) Ended --------------------- [+]" + Environment.NewLine);
            MISC_Stop_BTN.Visible = false;
            MISC_YingYang0_PIC.Visible = false; MISC_YingYang1_PIC.Visible = false;
        }

        private async void MISC_ExtractImagesMontage_BTN_Click(object sender, EventArgs e)
        {
            MISC_Cancel.Cancel(); MISC_Stop_BTN.Visible = true;
            MISC_Cancel = new CancellationTokenSource();
            var cancellationToken = MISC_Cancel.Token;
            MISC_YingYang0_PIC.Visible = true; MISC_YingYang1_PIC.Visible = true;
            MISC_Output_Txtbx.Text = "[+] -------------------- Extracting Images (All/Montage) Started -------------------- [+]" + Environment.NewLine;
            string[] Paths = MISC_Paths_Txtbx.Text.Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string path in Paths)
            {
                foreach (string var in Directory.GetFiles(path, "*.var", SearchOption.AllDirectories))
                {
                    if (!MISC_OverwriteImages_Chkbx.Checked && (System.IO.File.Exists(var.Substring(0, var.LastIndexOf(".")) + ".jpeg")))
                    {
                        goto skip;
                    }
                    if (MISC_IfJpgExistsNoJpeg_Chkbx.Checked && System.IO.File.Exists(var.Substring(0, var.LastIndexOf(".")) + ".jpg"))
                    {
                        goto skip;
                    }
                    try
                    {
                        if (MISC_Cancel.IsCancellationRequested) { break; }
                        string log = string.Empty;
                        await Task.Run(() =>
                        {
                            var opts = new SharpCompress.Readers.ReaderOptions();
                            opts.ArchiveEncoding.Default = encoding;
                            List<string> Entries = new List<string>();

                            using (Stream stream = System.IO.File.OpenRead(var))
                            using (var reader = ReaderFactory.Open(stream, opts))
                            {
                                while (reader.MoveToNextEntry())
                                {
                                    if (Regex.IsMatch(reader.Entry.Key, "\\.(json|vaj|vap|vam|assetbundle)$", RegexOptions.IgnoreCase))
                                    {
                                        Entries.Add(reader.Entry.Key);
                                    }
                                }
                            }

                            string tmp_Saves_Scene = System.IO.Path.GetDirectoryName(var) + "\\tmp_Saves_Scene";
                            string tmp_Custom_SubScene = System.IO.Path.GetDirectoryName(var) + "\\tmp_Custom_SubScene";
                            string tmp_Custom_Clothing = System.IO.Path.GetDirectoryName(var) + "\\tmp_Custom_Clothing";
                            string tmp_Custom_Hair = System.IO.Path.GetDirectoryName(var) + "\\tmp_Custom_Hair";
                            string tmp_Custom_Preset = System.IO.Path.GetDirectoryName(var) + "\\tmp_Custom_Preset";
                            string tmp_Custom_Assets = System.IO.Path.GetDirectoryName(var) + "\\tmp_Custom_Assets";
                            System.IO.Directory.CreateDirectory(tmp_Saves_Scene);
                            System.IO.Directory.CreateDirectory(tmp_Custom_SubScene);
                            System.IO.Directory.CreateDirectory(tmp_Custom_Clothing);
                            System.IO.Directory.CreateDirectory(tmp_Custom_Hair);
                            System.IO.Directory.CreateDirectory(tmp_Custom_Preset);
                            System.IO.Directory.CreateDirectory(tmp_Custom_Assets);

                            foreach (string entry in Entries)
                            {

                                using (Stream stream = System.IO.File.OpenRead(var))
                                using (var reader = ReaderFactory.Open(stream, opts))
                                {
                                    while (reader.MoveToNextEntry())
                                    {
                                        if (!reader.Entry.IsDirectory && reader.Entry.Key.Contains("."))
                                        {
                                            string Entry_withoutExtension = entry.Substring(0, entry.LastIndexOf("."));
                                            if (reader.Entry.Key.Equals(Entry_withoutExtension + ".jpg") && Entry_withoutExtension.ToLower().Contains("saves/scene"))
                                            {
                                                try
                                                {
                                                    reader.WriteEntryToFile(tmp_Saves_Scene + "\\" + reader.Entry.Key.Substring(reader.Entry.Key.LastIndexOf("/") + 1).Replace(".jpg", " (Scene)"));
                                                }
                                                catch (Exception ex)
                                                {
                                                    log += "[!] Error extracting images for: " + var + Environment.NewLine + ex + Environment.NewLine;
                                                }
                                            }
                                            if (reader.Entry.Key.Equals(Entry_withoutExtension + ".jpg") && Entry_withoutExtension.ToLower().Contains("custom/subscene"))
                                            {
                                                try
                                                {
                                                    reader.WriteEntryToFile(tmp_Custom_SubScene + "\\" + reader.Entry.Key.Substring(reader.Entry.Key.LastIndexOf("/") + 1).Replace(".jpg", " (SubScene)"));
                                                }
                                                catch (Exception ex)
                                                {
                                                    log += "[!] Error extracting images for: " + var + Environment.NewLine + ex + Environment.NewLine;
                                                }
                                            }
                                            if (reader.Entry.Key.Equals(Entry_withoutExtension + ".jpg") && Entry_withoutExtension.ToLower().Contains("custom/clothing"))
                                            {
                                                try
                                                {
                                                    reader.WriteEntryToFile(tmp_Custom_Clothing + "\\" + reader.Entry.Key.Substring(reader.Entry.Key.LastIndexOf("/") + 1).Replace(".jpg", " (Clothing)"));
                                                }
                                                catch (Exception ex)
                                                {
                                                    log += "[!] Error extracting images for: " + var + Environment.NewLine + ex + Environment.NewLine;
                                                }
                                            }
                                            if (reader.Entry.Key.Equals(Entry_withoutExtension + ".jpg") && Entry_withoutExtension.ToLower().Contains("custom/hair"))
                                            {
                                                try
                                                {
                                                    reader.WriteEntryToFile(tmp_Custom_Hair + "\\" + reader.Entry.Key.Substring(reader.Entry.Key.LastIndexOf("/") + 1).Replace(".jpg", " (Hair)"));
                                                }
                                                catch (Exception ex)
                                                {
                                                    log += "[!] Error extracting images for: " + var + Environment.NewLine + ex + Environment.NewLine;
                                                }
                                            }
                                            if (reader.Entry.Key.Equals(Entry_withoutExtension + ".jpg") && ((Entry_withoutExtension.ToLower().Contains("custom/atom/person")) || Entry_withoutExtension.ToLower().Contains("saves/person/appearance")))
                                            {
                                                try
                                                {
                                                    reader.WriteEntryToFile(tmp_Custom_Preset + "\\" + reader.Entry.Key.Substring(reader.Entry.Key.LastIndexOf("/") + 1).Replace(".jpg", " (Preset)"));
                                                }
                                                catch (Exception ex)
                                                {
                                                    log += "[!] Error extracting images for: " + var + Environment.NewLine + ex + Environment.NewLine;
                                                }
                                            }
                                            if (reader.Entry.Key.Equals(Entry_withoutExtension + ".jpg") && Entry_withoutExtension.ToLower().Contains("custom/assets"))
                                            {
                                                try
                                                {
                                                    reader.WriteEntryToFile(tmp_Custom_Assets + "\\" + reader.Entry.Key.Substring(reader.Entry.Key.LastIndexOf("/") + 1).Replace(".jpg", " (Asset)"));
                                                }
                                                catch (Exception ex)
                                                {
                                                    log += "[!] Error extracting images for: " + var + Environment.NewLine + ex + Environment.NewLine;
                                                }
                                            }
                                        }

                                    }

                                }
                            }

                            Process p = new Process();
                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.CreateNoWindow = true;
                            p.StartInfo.FileName = Directory.GetCurrentDirectory() + "\\_Tools\\ImageMagick\\montage.exe";
                            p.StartInfo.Arguments = "-label %f -pointsize 18 -shadow -bordercolor none -geometry 900x600+3+3 -frame 6 -title " + "\"" + System.IO.Path.GetFileName(var) + "\"" + " -font \"Microsoft-JhengHei-Bold-&-Microsoft-JhengHei-UI-Bold\""
                            + " \"" + tmp_Saves_Scene + "\\*\" "
                            + " \"" + tmp_Custom_SubScene + "\\*\" "
                            + " \"" + tmp_Custom_Clothing + "\\*\" "
                            + " \"" + tmp_Custom_Hair + "\\*\" "
                            + " \"" + tmp_Custom_Preset + "\\*\" "
                            + " \"" + tmp_Custom_Assets + "\\*\" "
                            + "\"" + System.IO.Path.GetDirectoryName(var) + "\\" + System.IO.Path.GetFileNameWithoutExtension(var) + ".jpeg\"";
                            p.Start();
                            while (!p.HasExited)
                            {
                            }
                            if (System.IO.File.Exists(System.IO.Path.GetDirectoryName(var) + "\\" + System.IO.Path.GetFileNameWithoutExtension(var) + ".jpeg"))
                            {
                                log += "[+] " + System.IO.Path.GetDirectoryName(var) + "\\" + System.IO.Path.GetFileNameWithoutExtension(var) + ".jpeg";
                            }
                            else
                            {
                                log += "[!] Couldn't find any preview images for: " + var;
                            }

                            System.IO.Directory.Delete(tmp_Saves_Scene, true);
                            System.IO.Directory.Delete(tmp_Custom_SubScene, true);
                            System.IO.Directory.Delete(tmp_Custom_Clothing, true);
                            System.IO.Directory.Delete(tmp_Custom_Hair, true);
                            System.IO.Directory.Delete(tmp_Custom_Preset, true);
                            System.IO.Directory.Delete(tmp_Custom_Assets, true);

                        });
                        if (log.Length > 0)
                        {
                            MISC_Output_Txtbx.AppendText(log + Environment.NewLine);
                        }
                    }
                    catch (Exception ex)
                    {
                        System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Extracting Images (All/Montage): " + var + "\r\n" + ex.Message + Environment.NewLine);
                    }
                skip:;
                }

            }
            MISC_Output_Txtbx.AppendText("[+] -------------------- Extracting Images (All/Montage) Ended --------------------- [+]");
            MISC_Stop_BTN.Visible = false;
            MISC_YingYang0_PIC.Visible = false; MISC_YingYang1_PIC.Visible = false;
        }
        /// ******** MISC End ******** ///   

        /// ******** Settings Start ******** /// 
        private void Settings_SaveExCreators_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                //remove duplicate/empty lines & sort before saving
                Settings_ExCreators_Txtbx.Text = Regex.Replace(Settings_ExCreators_Txtbx.Text, @"^(.+)$(?=[\s\S]*^(\1)$[\s\S]*)", string.Empty, RegexOptions.Multiline).TrimEnd();
                Settings_ExCreators_Txtbx.Text = Regex.Replace(Settings_ExCreators_Txtbx.Text, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd();
                Settings_ExCreators_Txtbx.Lines = Settings_ExCreators_Txtbx.Lines.OrderBy(l => l).ToArray();

                string text = System.IO.File.ReadAllText("_Settings.txt", encoding);

                int ex_creators_index_start = text.IndexOf("[Exceptional Creators]");
                int ex_creators_index_end = text.IndexOf("[/Exceptional Creators]");

                if (ex_creators_index_end != -1)
                {
                    string text_before = text.Substring(ex_creators_index_start, ex_creators_index_end - ex_creators_index_start) + "[/Exceptional Creators]";
                    string text_after = "[Exceptional Creators]" + "\n" + Settings_ExCreators_Txtbx.Text + "\n" + "[/Exceptional Creators]";
                    System.IO.File.WriteAllText("_Settings.txt", text.Replace(text_before, text_after), encoding);
                }
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Save Ex-Creators:" + "\r\n" + ex.Message + Environment.NewLine);
            }
        }

        private void Settings_SavePixeldrainApi_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                string text = System.IO.File.ReadAllText("_Settings.txt", encoding);

                int pixeldrain_api_start = text.IndexOf("[pixeldrain_api]");
                int pixeldrain_api_end = text.IndexOf("[/pixeldrain_api]");

                if (pixeldrain_api_end != -1)
                {
                    string text_before = text.Substring(pixeldrain_api_start, pixeldrain_api_end - pixeldrain_api_start) + "[/pixeldrain_api]";
                    string text_after = "[pixeldrain_api]" + "\n" + Settings_PixeldrainApi_Txtbx.Text.Replace("\n", "") + "\n" + "[/pixeldrain_api]";
                    System.IO.File.WriteAllText("_Settings.txt", text.Replace(text_before, text_after), encoding);

                }
            }
            catch (Exception ex)
            {

                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Save Pixeldrain API Key" + "\r\n" + ex.Message + Environment.NewLine);
            }
        }
        private void Settings_GB2312_Chkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (Settings_GB2312_Chkbx.Checked == true)
            {
                Settings_UTF8_Chkbx.Checked = false;
                encoding = Encoding.GetEncoding("GB2312");
            }
        }

        private void Settings_UTF8_Chkbx_CheckedChanged(object sender, EventArgs e)
        {
            if (Settings_UTF8_Chkbx.Checked == true)
            {
                Settings_GB2312_Chkbx.Checked = false;
                encoding = Encoding.UTF8;
            }
        }

        private void Settings_SaveEncoding_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                string text = System.IO.File.ReadAllText("_Settings.txt", encoding);

                int Encoding_start = text.IndexOf("[Encoding]");
                int Encoding_end = text.IndexOf("[/Encoding]");

                if (Encoding_end != -1)
                {
                    string text_before = text.Substring(Encoding_start, Encoding_end - Encoding_start) + "[/Encoding]";


                    if (Settings_GB2312_Chkbx.Checked == true)
                    {
                        string text_after = "[Encoding]" + "\n" + "GB2312" + "\n" + "[/Encoding]";
                        System.IO.File.WriteAllText("_Settings.txt", text.Replace(text_before, text_after), encoding);
                    }

                    if (Settings_UTF8_Chkbx.Checked == true)
                    {
                        string text_after = "[Encoding]" + "\n" + "UTF-8" + "\n" + "[/Encoding]";
                        System.IO.File.WriteAllText("_Settings.txt", text.Replace(text_before, text_after), encoding);

                    }
                }

            }
            catch (Exception ex)
            {

                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Save Encoding" + "\r\n" + ex.Message + Environment.NewLine);
            }
        }

        private void Settings_OpenVamErrorLog_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("C:\\Windows\\notepad.exe", "C:\\Users\\" + Environment.UserName + "\\AppData\\LocalLow\\MeshedVR\\VaM\\output_log.txt");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Settings_OpenSharpVamErrorLog_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("C:\\Windows\\notepad.exe", Directory.GetCurrentDirectory() + "\\_Error_log.txt");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Settings_OpenDownloadLinksFolder_BTN_Click(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists(Directory.GetCurrentDirectory() + "\\Download_Links"))
            {
                System.Diagnostics.Process.Start("C:\\Windows\\explorer.exe", Directory.GetCurrentDirectory() + "\\Download_Links");
            }
            else
            {
                MessageBox.Show("Download links folder doesn't exist!");
            }
        }
        private void Settings_SetFontSize_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                Font font = new Font("Microsoft Sans Serif", float.Parse(Settings_FontSize_Txtbx.Text.Trim()));
                var c = GetAll(this);
                foreach (var ctrl in c)
                {
                    ctrl.Font = font;
                }
            }
            catch
            {
                MessageBox.Show("Enter valid font size in numbers!");
            }

        }
        private IEnumerable<Control> GetAll(Control control)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl))
                                      .Concat(controls);
        }
        private void Settings_Theme_ComboBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Settings_Theme_ComboBX.SelectedIndex)
            {
                case 0:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
                    var c = GetAll(this);
                    foreach (var ctrl in c)
                    {
                        if (ctrl.GetType().ToString().EndsWith(".GroupBox"))
                        {
                            ctrl.ForeColor = Color.White;
                        }
                    }
                    break;
                case 1:
                    metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Light;
                    var cc = GetAll(this);
                    foreach (var ctrl in cc)
                    {
                        if (ctrl.GetType().ToString().EndsWith(".GroupBox"))
                        {
                            ctrl.ForeColor = Color.Black;
                        }
                    }
                    break;
            }
        }

        private void Settings_ThemeStyle_ComboBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            metroStyleManager1.Style = (MetroFramework.MetroColorStyle)Convert.ToInt32(Settings_ThemeStyle_ComboBX.SelectedIndex);

        }

        private void Settings_SaveAppearance_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                string text = System.IO.File.ReadAllText("_Settings.txt", encoding);

                if (!text.Contains("[Appearance]"))
                {
                    text += Environment.NewLine + "[Appearance]" + Environment.NewLine + "Theme=" + Settings_Theme_ComboBX.SelectedItem + Environment.NewLine +
                            "Style=" + Settings_ThemeStyle_ComboBX.SelectedItem + Environment.NewLine +
                            "FontSize=" + Settings_FontSize_Txtbx.Text + Environment.NewLine + "[/Appearance]";

                    System.IO.File.WriteAllText("_Settings.txt", text, encoding);
                }
                else
                {
                    int Start = text.IndexOf("[Appearance]");
                    int End = text.IndexOf("[/Appearance]");

                    if (End != -1)
                    {
                        string text_before = text.Substring(Start, End - Start) + "[/Appearance]";
                        string text_after = "[Appearance]" + Environment.NewLine + "Theme=" + Settings_Theme_ComboBX.SelectedItem + Environment.NewLine +
                                "Style=" + Settings_ThemeStyle_ComboBX.SelectedItem + Environment.NewLine +
                                "FontSize=" + Settings_FontSize_Txtbx.Text + Environment.NewLine + "[/Appearance]";
                        System.IO.File.WriteAllText("_Settings.txt", text.Replace(text_before, text_after), encoding);
                    }
                }
            }
            catch (Exception ex)
            {

                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Save Appearance" + "\r\n" + ex.Message + Environment.NewLine);
            }
        }
        /// ******** Settings End ******** /// 

        private void F95_PIC_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://f95zone.to/threads/241571/");
        }

        private void MISC_DeleteOldVersions_BTN_Click(object sender, EventArgs e)
        {
            /*
            foreach (string var in Directory.GetFiles(MISC_Paths_Txtbx.Lines[0].ToString(), "*.var", SearchOption.AllDirectories))
            {

            }
            */
            MISC_Output_Txtbx.Text = "[+] Stay tuned, will be added soon.";
        }


    }
}
