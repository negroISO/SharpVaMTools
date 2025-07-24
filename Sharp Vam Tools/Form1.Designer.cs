namespace Sharp_VaM_Tools
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TapsControl = new MetroFramework.Controls.MetroTabControl();
            this.Tab_Search_My_Folders = new MetroFramework.Controls.MetroTabPage();
            this.SearchMyFolders_Search_DataGridView = new MetroFramework.Controls.MetroTextBox();
            this.SearchMyFolders_SaveLocations_BTN = new MetroFramework.Controls.MetroButton();
            this.SearchMyFolders_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Var = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchMyFolders_CM_datagridview1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.SearchMyFolders_CM_datagridview1_CopySelected = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_datagridview1_SearchMissingVars = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_datagridview1_DownloadHub = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_datagridview1_MalwareScan = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_datagridview1_SearchTorrent = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_datagridview1_SearchF95 = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_datagridview1_SaveResultcsv = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_datagridview1_SaveDownloadLinksTxt = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_datagridview1_OpenVarLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_datagridview1_CopyVarsToPath = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_datagridview1_MoveVarsToPath = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_datagridview1_CancelAll = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_Browse_BTN = new MetroFramework.Controls.MetroButton();
            this.SearchMyFolders_VarsList_Txtbx = new System.Windows.Forms.RichTextBox();
            this.SearchMyFolders_CM_VarsList_Txtbx = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.SearchMyFolders_CM_VarsList_Txtbx_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_VarsList_Txtbx_CopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_VarsList_Txtbx_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_VarsList_Txtbx_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_VarsList_Txtbx_Extract = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_CM_VarsList_Txtbx_ExtractVAMMissingDependencies = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchMyFolders_VarsLocations_Txtbx = new System.Windows.Forms.RichTextBox();
            this.SearchMyFolders_Gbx1 = new System.Windows.Forms.GroupBox();
            this.SearchMyFolders_Gbx2 = new System.Windows.Forms.GroupBox();
            this.SearchMyFolder_Browse2_BTN = new MetroFramework.Controls.MetroButton();
            this.SearchMyFolders_AutoDownload_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.SearchMyFolders_AutoSearch_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.SearchMyFolders_ExtractOnly_metajson_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.SearchMyFolders_ExtractVarNamesFirst_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.SearchMyFolders_Ignore_metajson_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.SearchMyFolders_StartSearching_BTN = new MetroFramework.Controls.MetroButton();
            this.SearchMyFolders_Gbx3 = new System.Windows.Forms.GroupBox();
            this.SearchMyFolders_SkipHubCheck_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.Tab_Extract = new MetroFramework.Controls.MetroTabPage();
            this.Extract_DownloadLinks_BTN = new MetroFramework.Controls.MetroButton();
            this.Extract_GenerateDependecies_BTN = new MetroFramework.Controls.MetroButton();
            this.Extract_Generate_metajson_BTN = new MetroFramework.Controls.MetroButton();
            this.Extract_VarNames_BTN = new MetroFramework.Controls.MetroButton();
            this.Extract_Output_Txtbx = new System.Windows.Forms.RichTextBox();
            this.Extract_CM_Output_Txtbx = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.Extract_CM_Output_Txtbx_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Extract_CM_Output_Txtbx_CopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Extract_CM_Output_Txtbx_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.Extract_Gbx1 = new System.Windows.Forms.GroupBox();
            this.Extract_Isjson_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.Extract_Input_Txtbx = new System.Windows.Forms.RichTextBox();
            this.Extract_CM_Input_Txtbx = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.Extract_CM_Input_Txtbx_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.Extract_CM_Input_Txtbx_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.Extract_CM_Input_Txtbx_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.Extract_Gbx2 = new System.Windows.Forms.GroupBox();
            this.Extract_GetSubDependencies_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.Extract_LicenseType_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.Tab_Missing_from_F95 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.MissingFromF95_DeleteZipAfterUploading_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.MissingFromF95_ExtractVarNames_BTN = new MetroFramework.Controls.MetroButton();
            this.MissingFromF95_Browse_BTN = new MetroFramework.Controls.MetroButton();
            this.MissingFromF95_Pixeldrain_Txtbx = new MetroFramework.Controls.MetroTextBox();
            this.MissingFromF95_PixeldrainUpload_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.MissingFromF95_IncludeVarImages_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.MissingFromF95_BrowseZip_BTN = new MetroFramework.Controls.MetroButton();
            this.MissingFromF95_ZipSavePath_Txtbx = new MetroFramework.Controls.MetroTextBox();
            this.MissingFromF95_zip_BTN = new MetroFramework.Controls.MetroButton();
            this.MissingFromF95_dataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MissingFromF95_CM_dataGridView = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.MissingFromF95_CM_dataGridView_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.MissingFromF95_Search_BTN = new MetroFramework.Controls.MetroButton();
            this.MissingFromF95_IncludedModelsAssets_Txtbx = new System.Windows.Forms.RichTextBox();
            this.MissingFromF95_CM_IncludedModelsAssets_Txtbx = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.MissingFromF95_CM_IncludedModelsAssets_CopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MissingFromF95_CM_IncludedModelsAssets_CopySelected = new System.Windows.Forms.ToolStripMenuItem();
            this.MissingFromF95_CM_IncludedModelsAssets_Paste = new System.Windows.Forms.ToolStripMenuItem();
            this.MissingFromF95_CM_IncludedModelsAssets_ClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.MissingFromF95_Gbx1 = new System.Windows.Forms.GroupBox();
            this.MissingFromF95_CreatorPaths_Txtbx = new System.Windows.Forms.RichTextBox();
            this.MissingFromF95_Gbx2 = new System.Windows.Forms.GroupBox();
            this.MissingFromF95_Gbx3 = new System.Windows.Forms.GroupBox();
            this.MissingFromF95_Gbx4 = new System.Windows.Forms.GroupBox();
            this.MissingFromF95_YingYang_PixelDrain = new System.Windows.Forms.PictureBox();
            this.Tab_Search_Inside_vars = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.SearchInsideVars_Browse_BTN = new MetroFramework.Controls.MetroButton();
            this.SearchInsideVars_BuildingDone_Lbl = new MetroFramework.Controls.MetroLabel();
            this.SearchInsideVars_KeepBookmarks_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.SearchInsideVars_Append_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.SearchInsideVars_db_Path_Txtbx = new MetroFramework.Controls.MetroTextBox();
            this.SearchInsideVars_BuildDatabase_BTN = new MetroFramework.Controls.MetroButton();
            this.SearchInsideVars_dataGridView = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchInsideVars_CM_dataGridView = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.SearchInsideVars_CM_dataGridView_Copy = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInsideVars_CM_dataGridView_CopyCrc = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInsideVars_CM_dataGridView_CopyPathJson = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInsideVars_CM_dataGridView_CopyPathJsonLatest = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInsideVars_CM_dataGridView_Bookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInsideVars_CM_dataGridView_RemoveBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInsideVars_CM_dataGridView_OpenVarLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInsideVars_SearchStrings_Txtbx = new MetroFramework.Controls.MetroTextBox();
            this.SearchInsideVars_VarPaths_Txtbx = new System.Windows.Forms.RichTextBox();
            this.SearchInsideVars_YingYangBuildDB_Pic = new System.Windows.Forms.PictureBox();
            this.SearchInsideVars_Gbx1 = new System.Windows.Forms.GroupBox();
            this.SearchInsideVars_Gbx2 = new System.Windows.Forms.GroupBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.SearchInsideVars_UseSubfilter_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.SearchInsideVars_Cancel_BTN = new MetroFramework.Controls.MetroButton();
            this.SearchInsideVars_IsMorph_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.SearchInsideVars_SearchSubfilter_Txtbx = new MetroFramework.Controls.MetroTextBox();
            this.SearchInsideVars_SearchDatabase_BTN = new MetroFramework.Controls.MetroButton();
            this.SearchInsideVars_SearchFolders_BTN = new MetroFramework.Controls.MetroButton();
            this.SearchInsideVars_Gbx3 = new System.Windows.Forms.GroupBox();
            this.SearchInsideVars_AnalyzeVars_YinYang_Pic = new System.Windows.Forms.PictureBox();
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx = new MetroFramework.Controls.MetroTextBox();
            this.SearchInsideVars_VarToCRCAndPaths_Txtbx = new System.Windows.Forms.RichTextBox();
            this.SearchInsideVars_CM_VarToCRCAndPaths = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.SearchInsideVars_CM_VarToCRCAndPaths_Browse = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInsideVars_CM_VarToCRCAndPaths_CopySelected = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInsideVars_CM_VarToCRCAndPaths_CopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInsideVars_CM_VarToCRCAndPaths_ClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchInsideVars_CM_VarToCRCAndPaths_CancelAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab_Analyze_Vars = new MetroFramework.Controls.MetroTabPage();
            this.AnalyzeVars_GBX4 = new System.Windows.Forms.GroupBox();
            this.AnalyzeVars_Search_Txtbx = new MetroFramework.Controls.MetroTextBox();
            this.AnalyzeVars_Cencel_BTN = new MetroFramework.Controls.MetroButton();
            this.AnalyzeVars_Gbx2 = new System.Windows.Forms.GroupBox();
            this.AnalyzeVars_ListVarsContent_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.AnalyzeVars_DetectPlugins_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.AnalyzeVars_LocalReferences_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.AnalyzeVars_BloatedVar_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.AnalyzeVars_Morphs_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.AnalyzeVars_DeserializeJson_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.AnalyzeVars_metaJson_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.AnalyzeVars_Gbx3 = new System.Windows.Forms.GroupBox();
            this.AnalyzeVars_YingYang_PIC = new System.Windows.Forms.PictureBox();
            this.AnalyzeVars_ExtractImagesExif_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.AnalyzeVars_NonVamImages_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.AnalyzeVars_ImagesMISC_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.AnalyzeVars_TamperedwithVar_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.AnalyzeVars_Browse_BTN = new MetroFramework.Controls.MetroButton();
            this.AnalyzeVars_Result_Txtbx = new System.Windows.Forms.RichTextBox();
            this.AnalyzeVars_CM_Result_Txtbx = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.AnalyzeVars_CM_Result_Txtbx_ShowWarnings = new System.Windows.Forms.ToolStripMenuItem();
            this.AnalyzeVars_CM_Result_Txtbx_CopyWarnings = new System.Windows.Forms.ToolStripMenuItem();
            this.AnalyzeVars_CM_Result_Txtbx_GoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.AnalyzeVars_CM_Result_Txtbx_CopySelected = new System.Windows.Forms.ToolStripMenuItem();
            this.AnalyzeVars_CM_Result_Txtbx_CopyAllText = new System.Windows.Forms.ToolStripMenuItem();
            this.AnalyzeVars_CM_Result_Txtbx_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.Tab_Security_MalwareScan = new MetroFramework.Controls.MetroTabPage();
            this.Security_ScanResultMalware_Txtbx = new System.Windows.Forms.RichTextBox();
            this.Security_CM_ScanResultMalware_Txtbx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Security_CM_ScanResultMalware_Txtbx_CopySelected = new System.Windows.Forms.ToolStripMenuItem();
            this.Security_CM_ScanResultMalware_Txtbx_CopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Security_CM_ScanResultMalware_Txtbx_ClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Security_ScanResultSuspecious_Txtbx = new System.Windows.Forms.RichTextBox();
            this.Security_CM_ScanResultSuspecious_Txtbx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Security_CM_ScanResultSuspecious_Txtbx_CopySelected = new System.Windows.Forms.ToolStripMenuItem();
            this.Security_CM_ScanResultSuspecious_Txtbx_CopyAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Security_CM_ScanResultSuspecious_Txtbx_ClearAll = new System.Windows.Forms.ToolStripMenuItem();
            this.Security_VarsToScan_Txtbx = new System.Windows.Forms.RichTextBox();
            this.Security_CM_VarsToScan_Txtbx = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.Security_CM_VarsToScan_Txtbx_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.Security_Gbx1 = new System.Windows.Forms.GroupBox();
            this.Security_EscapeClean_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.Security_Scan_BTN = new MetroFramework.Controls.MetroButton();
            this.Security_YinYang_Scan = new System.Windows.Forms.PictureBox();
            this.Security_escape_Assetbundles_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.Security_escape_EventTrigger_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.Security_Browse_BTN = new MetroFramework.Controls.MetroButton();
            this.Security_escape_ApplicationOpenURL_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.Security_escape_FileMangementSecure_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.Security_Gbx2 = new System.Windows.Forms.GroupBox();
            this.Security_Gbx3 = new System.Windows.Forms.GroupBox();
            this.Tab_MISC = new MetroFramework.Controls.MetroTabPage();
            this.MISC_Browse_BTN = new MetroFramework.Controls.MetroButton();
            this.MISC_Output_Txtbx = new System.Windows.Forms.RichTextBox();
            this.MISC_CM_Output_Txtbx = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.MISC_CM_Output_Txtbx_Clear = new System.Windows.Forms.ToolStripMenuItem();
            this.MISC_Paths_Txtbx = new System.Windows.Forms.RichTextBox();
            this.MISC_Gbx1 = new System.Windows.Forms.GroupBox();
            this.MISC_Gbx2 = new System.Windows.Forms.GroupBox();
            this.MISC_MoveUnusedVars_BTN = new MetroFramework.Controls.MetroButton();
            this.MISC_ExtractImagesScene2_BTN = new MetroFramework.Controls.MetroButton();
            this.MISC_YingYang0_PIC = new System.Windows.Forms.PictureBox();
            this.MISC_YingYang1_PIC = new System.Windows.Forms.PictureBox();
            this.MISC_ExtractChineseArchives_BTN = new MetroFramework.Controls.MetroButton();
            this.MISC_DeleteCorruptedVars_BTN = new MetroFramework.Controls.MetroButton();
            this.MISC_Stop_BTN = new MetroFramework.Controls.MetroButton();
            this.MISC_ExtractImagesMontage_BTN = new MetroFramework.Controls.MetroButton();
            this.MISC_DeleteDuplicateVars_BTN = new MetroFramework.Controls.MetroButton();
            this.MISC_MoveVars_BTN = new MetroFramework.Controls.MetroButton();
            this.MISC_ExtractImagesScene1_BTN = new MetroFramework.Controls.MetroButton();
            this.MISC_Gbx3 = new System.Windows.Forms.GroupBox();
            this.MISC_IfJpgExistsNoJpeg_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.MISC_OverwriteImages_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.Tab_Settings = new MetroFramework.Controls.MetroTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Settings_SaveAppearance_BTN = new MetroFramework.Controls.MetroButton();
            this.Settings_ThemeStyle_ComboBX = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.Settings_Theme_ComboBX = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.Settings_FontSize_Txtbx = new MetroFramework.Controls.MetroTextBox();
            this.Settings_SetFontSize_BTN = new MetroFramework.Controls.MetroButton();
            this.Settings_Gbx4 = new System.Windows.Forms.GroupBox();
            this.Settings_OpenDownloadLinksFolder_BTN = new MetroFramework.Controls.MetroButton();
            this.Settings_OpenSharpVamErrorLog_BTN = new MetroFramework.Controls.MetroButton();
            this.Settings_OpenVamErrorLog_BTN = new MetroFramework.Controls.MetroButton();
            this.Settings_Pixeldrain_Gbx = new System.Windows.Forms.GroupBox();
            this.Settings_SavePixeldrainApi_BTN = new MetroFramework.Controls.MetroButton();
            this.Settings_PixeldrainApi_Txtbx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.Settings_Encoding_Gbx = new System.Windows.Forms.GroupBox();
            this.Settings_SaveEncoding_BTN = new MetroFramework.Controls.MetroButton();
            this.Settings_GB2312_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.Settings_UTF8_Chkbx = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.Settings_ExCreators_Gbx = new System.Windows.Forms.GroupBox();
            this.Settings_ExCreators_Txtbx = new System.Windows.Forms.RichTextBox();
            this.ex_label1 = new MetroFramework.Controls.MetroLabel();
            this.Settings_SaveExCreators_BTN = new MetroFramework.Controls.MetroButton();
            this.hero = new System.Windows.Forms.PictureBox();
            this.Fine_PIC = new System.Windows.Forms.PictureBox();
            this.Boss_Fine_PIC = new System.Windows.Forms.PictureBox();
            this.F95_PIC = new System.Windows.Forms.PictureBox();
            this.Boss_Smoking_Gif = new System.Windows.Forms.PictureBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.TapsControl.SuspendLayout();
            this.Tab_Search_My_Folders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchMyFolders_dataGridView1)).BeginInit();
            this.SearchMyFolders_CM_datagridview1.SuspendLayout();
            this.SearchMyFolders_CM_VarsList_Txtbx.SuspendLayout();
            this.SearchMyFolders_Gbx2.SuspendLayout();
            this.SearchMyFolders_Gbx3.SuspendLayout();
            this.Tab_Extract.SuspendLayout();
            this.Extract_CM_Output_Txtbx.SuspendLayout();
            this.Extract_Gbx1.SuspendLayout();
            this.Extract_CM_Input_Txtbx.SuspendLayout();
            this.Extract_Gbx2.SuspendLayout();
            this.Tab_Missing_from_F95.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MissingFromF95_dataGridView)).BeginInit();
            this.MissingFromF95_CM_dataGridView.SuspendLayout();
            this.MissingFromF95_CM_IncludedModelsAssets_Txtbx.SuspendLayout();
            this.MissingFromF95_Gbx1.SuspendLayout();
            this.MissingFromF95_Gbx4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MissingFromF95_YingYang_PixelDrain)).BeginInit();
            this.Tab_Search_Inside_vars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchInsideVars_dataGridView)).BeginInit();
            this.SearchInsideVars_CM_dataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchInsideVars_YingYangBuildDB_Pic)).BeginInit();
            this.SearchInsideVars_Gbx2.SuspendLayout();
            this.SearchInsideVars_Gbx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchInsideVars_AnalyzeVars_YinYang_Pic)).BeginInit();
            this.SearchInsideVars_CM_VarToCRCAndPaths.SuspendLayout();
            this.Tab_Analyze_Vars.SuspendLayout();
            this.AnalyzeVars_GBX4.SuspendLayout();
            this.AnalyzeVars_Gbx2.SuspendLayout();
            this.AnalyzeVars_Gbx3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnalyzeVars_YingYang_PIC)).BeginInit();
            this.AnalyzeVars_CM_Result_Txtbx.SuspendLayout();
            this.Tab_Security_MalwareScan.SuspendLayout();
            this.Security_CM_ScanResultMalware_Txtbx.SuspendLayout();
            this.Security_CM_ScanResultSuspecious_Txtbx.SuspendLayout();
            this.Security_CM_VarsToScan_Txtbx.SuspendLayout();
            this.Security_Gbx1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Security_YinYang_Scan)).BeginInit();
            this.Tab_MISC.SuspendLayout();
            this.MISC_CM_Output_Txtbx.SuspendLayout();
            this.MISC_Gbx2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MISC_YingYang0_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MISC_YingYang1_PIC)).BeginInit();
            this.MISC_Gbx3.SuspendLayout();
            this.Tab_Settings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Settings_Gbx4.SuspendLayout();
            this.Settings_Pixeldrain_Gbx.SuspendLayout();
            this.Settings_Encoding_Gbx.SuspendLayout();
            this.Settings_ExCreators_Gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fine_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boss_Fine_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.F95_PIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boss_Smoking_Gif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // TapsControl
            // 
            this.TapsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TapsControl.Controls.Add(this.Tab_Search_My_Folders);
            this.TapsControl.Controls.Add(this.Tab_Extract);
            this.TapsControl.Controls.Add(this.Tab_Missing_from_F95);
            this.TapsControl.Controls.Add(this.Tab_Search_Inside_vars);
            this.TapsControl.Controls.Add(this.Tab_Analyze_Vars);
            this.TapsControl.Controls.Add(this.Tab_Security_MalwareScan);
            this.TapsControl.Controls.Add(this.Tab_MISC);
            this.TapsControl.Controls.Add(this.Tab_Settings);
            this.TapsControl.Location = new System.Drawing.Point(23, 63);
            this.TapsControl.Name = "TapsControl";
            this.TapsControl.SelectedIndex = 0;
            this.TapsControl.Size = new System.Drawing.Size(932, 771);
            this.TapsControl.TabIndex = 0;
            this.TapsControl.UseSelectable = true;
            // 
            // Tab_Search_My_Folders
            // 
            this.Tab_Search_My_Folders.Controls.Add(this.SearchMyFolders_Search_DataGridView);
            this.Tab_Search_My_Folders.Controls.Add(this.SearchMyFolders_SaveLocations_BTN);
            this.Tab_Search_My_Folders.Controls.Add(this.SearchMyFolders_dataGridView1);
            this.Tab_Search_My_Folders.Controls.Add(this.SearchMyFolders_Browse_BTN);
            this.Tab_Search_My_Folders.Controls.Add(this.SearchMyFolders_VarsList_Txtbx);
            this.Tab_Search_My_Folders.Controls.Add(this.SearchMyFolders_VarsLocations_Txtbx);
            this.Tab_Search_My_Folders.Controls.Add(this.SearchMyFolders_Gbx1);
            this.Tab_Search_My_Folders.Controls.Add(this.SearchMyFolders_Gbx2);
            this.Tab_Search_My_Folders.Controls.Add(this.SearchMyFolders_Gbx3);
            this.Tab_Search_My_Folders.HorizontalScrollbarBarColor = true;
            this.Tab_Search_My_Folders.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab_Search_My_Folders.HorizontalScrollbarSize = 10;
            this.Tab_Search_My_Folders.Location = new System.Drawing.Point(4, 38);
            this.Tab_Search_My_Folders.Name = "Tab_Search_My_Folders";
            this.Tab_Search_My_Folders.Size = new System.Drawing.Size(924, 729);
            this.Tab_Search_My_Folders.TabIndex = 0;
            this.Tab_Search_My_Folders.Text = "Search My Folders";
            this.Tab_Search_My_Folders.VerticalScrollbarBarColor = true;
            this.Tab_Search_My_Folders.VerticalScrollbarHighlightOnWheel = false;
            this.Tab_Search_My_Folders.VerticalScrollbarSize = 10;
            // 
            // SearchMyFolders_Search_DataGridView
            // 
            // 
            // 
            // 
            this.SearchMyFolders_Search_DataGridView.CustomButton.Image = null;
            this.SearchMyFolders_Search_DataGridView.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.SearchMyFolders_Search_DataGridView.CustomButton.Name = "";
            this.SearchMyFolders_Search_DataGridView.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.SearchMyFolders_Search_DataGridView.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchMyFolders_Search_DataGridView.CustomButton.TabIndex = 1;
            this.SearchMyFolders_Search_DataGridView.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchMyFolders_Search_DataGridView.CustomButton.UseSelectable = true;
            this.SearchMyFolders_Search_DataGridView.CustomButton.Visible = false;
            this.SearchMyFolders_Search_DataGridView.Lines = new string[] {
        "Search..."};
            this.SearchMyFolders_Search_DataGridView.Location = new System.Drawing.Point(793, 452);
            this.SearchMyFolders_Search_DataGridView.MaxLength = 32767;
            this.SearchMyFolders_Search_DataGridView.Name = "SearchMyFolders_Search_DataGridView";
            this.SearchMyFolders_Search_DataGridView.PasswordChar = '\0';
            this.SearchMyFolders_Search_DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchMyFolders_Search_DataGridView.SelectedText = "";
            this.SearchMyFolders_Search_DataGridView.SelectionLength = 0;
            this.SearchMyFolders_Search_DataGridView.SelectionStart = 0;
            this.SearchMyFolders_Search_DataGridView.ShortcutsEnabled = true;
            this.SearchMyFolders_Search_DataGridView.Size = new System.Drawing.Size(120, 21);
            this.SearchMyFolders_Search_DataGridView.TabIndex = 16;
            this.SearchMyFolders_Search_DataGridView.Text = "Search...";
            this.SearchMyFolders_Search_DataGridView.UseSelectable = true;
            this.SearchMyFolders_Search_DataGridView.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchMyFolders_Search_DataGridView.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchMyFolders_Search_DataGridView.TextChanged += new System.EventHandler(this.SearchMyFolders_Search_DataGridView_TextChanged);
            // 
            // SearchMyFolders_SaveLocations_BTN
            // 
            this.SearchMyFolders_SaveLocations_BTN.Location = new System.Drawing.Point(659, 9);
            this.SearchMyFolders_SaveLocations_BTN.Name = "SearchMyFolders_SaveLocations_BTN";
            this.SearchMyFolders_SaveLocations_BTN.Size = new System.Drawing.Size(123, 24);
            this.SearchMyFolders_SaveLocations_BTN.TabIndex = 11;
            this.SearchMyFolders_SaveLocations_BTN.Text = "Save Locations";
            this.SearchMyFolders_SaveLocations_BTN.UseSelectable = true;
            this.SearchMyFolders_SaveLocations_BTN.Click += new System.EventHandler(this.SearchMyFolders_SaveLocations_BTN_Click);
            // 
            // SearchMyFolders_dataGridView1
            // 
            this.SearchMyFolders_dataGridView1.AllowUserToAddRows = false;
            this.SearchMyFolders_dataGridView1.AllowUserToOrderColumns = true;
            this.SearchMyFolders_dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.SearchMyFolders_dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchMyFolders_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchMyFolders_dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Var,
            this.Result,
            this.Path});
            this.SearchMyFolders_dataGridView1.ContextMenuStrip = this.SearchMyFolders_CM_datagridview1;
            this.SearchMyFolders_dataGridView1.Location = new System.Drawing.Point(12, 452);
            this.SearchMyFolders_dataGridView1.Name = "SearchMyFolders_dataGridView1";
            this.SearchMyFolders_dataGridView1.Size = new System.Drawing.Size(900, 231);
            this.SearchMyFolders_dataGridView1.TabIndex = 10;
            // 
            // Var
            // 
            this.Var.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Var.HeaderText = "Var";
            this.Var.Name = "Var";
            this.Var.Width = 48;
            // 
            // Result
            // 
            this.Result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.Width = 62;
            // 
            // Path
            // 
            this.Path.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Path.HeaderText = "Path / URL";
            this.Path.Name = "Path";
            this.Path.Width = 87;
            // 
            // SearchMyFolders_CM_datagridview1
            // 
            this.SearchMyFolders_CM_datagridview1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchMyFolders_CM_datagridview1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchMyFolders_CM_datagridview1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchMyFolders_CM_datagridview1_CopySelected,
            this.SearchMyFolders_CM_datagridview1_SearchMissingVars,
            this.SearchMyFolders_CM_datagridview1_DownloadHub,
            this.SearchMyFolders_CM_datagridview1_MalwareScan,
            this.SearchMyFolders_CM_datagridview1_SearchTorrent,
            this.SearchMyFolders_CM_datagridview1_SearchF95,
            this.SearchMyFolders_CM_datagridview1_SaveResultcsv,
            this.SearchMyFolders_CM_datagridview1_SaveDownloadLinksTxt,
            this.SearchMyFolders_CM_datagridview1_OpenVarLocation,
            this.SearchMyFolders_CM_datagridview1_CopyVarsToPath,
            this.SearchMyFolders_CM_datagridview1_MoveVarsToPath,
            this.SearchMyFolders_CM_datagridview1_CancelAll});
            this.SearchMyFolders_CM_datagridview1.Name = "ContextMenu2_datagridview1";
            this.SearchMyFolders_CM_datagridview1.Size = new System.Drawing.Size(373, 316);
            // 
            // SearchMyFolders_CM_datagridview1_CopySelected
            // 
            this.SearchMyFolders_CM_datagridview1_CopySelected.Name = "SearchMyFolders_CM_datagridview1_CopySelected";
            this.SearchMyFolders_CM_datagridview1_CopySelected.Size = new System.Drawing.Size(372, 26);
            this.SearchMyFolders_CM_datagridview1_CopySelected.Text = "Copy Selected (text)";
            this.SearchMyFolders_CM_datagridview1_CopySelected.Click += new System.EventHandler(this.SearchMyFolders_CM_datagridview1_CopySelected_Click);
            // 
            // SearchMyFolders_CM_datagridview1_SearchMissingVars
            // 
            this.SearchMyFolders_CM_datagridview1_SearchMissingVars.Name = "SearchMyFolders_CM_datagridview1_SearchMissingVars";
            this.SearchMyFolders_CM_datagridview1_SearchMissingVars.Size = new System.Drawing.Size(372, 26);
            this.SearchMyFolders_CM_datagridview1_SearchMissingVars.Text = "Search for Missing Vars (Hub / Pixel)";
            this.SearchMyFolders_CM_datagridview1_SearchMissingVars.Click += new System.EventHandler(this.SearchMyFolders_CM_datagridview1_SearchMissingVars_Click);
            // 
            // SearchMyFolders_CM_datagridview1_DownloadHub
            // 
            this.SearchMyFolders_CM_datagridview1_DownloadHub.Name = "SearchMyFolders_CM_datagridview1_DownloadHub";
            this.SearchMyFolders_CM_datagridview1_DownloadHub.Size = new System.Drawing.Size(372, 26);
            this.SearchMyFolders_CM_datagridview1_DownloadHub.Text = "Download Missing Vars";
            this.SearchMyFolders_CM_datagridview1_DownloadHub.Click += new System.EventHandler(this.SearchMyFolders_CM_datagridview1_DownloadHub_Click);
            // 
            // SearchMyFolders_CM_datagridview1_MalwareScan
            // 
            this.SearchMyFolders_CM_datagridview1_MalwareScan.Name = "SearchMyFolders_CM_datagridview1_MalwareScan";
            this.SearchMyFolders_CM_datagridview1_MalwareScan.Size = new System.Drawing.Size(372, 26);
            this.SearchMyFolders_CM_datagridview1_MalwareScan.Text = "Send Selected Var/s to Malware Scan";
            this.SearchMyFolders_CM_datagridview1_MalwareScan.Click += new System.EventHandler(this.SearchMyFolders_CM_datagridview1_MalwareScan_Click);
            // 
            // SearchMyFolders_CM_datagridview1_SearchTorrent
            // 
            this.SearchMyFolders_CM_datagridview1_SearchTorrent.Name = "SearchMyFolders_CM_datagridview1_SearchTorrent";
            this.SearchMyFolders_CM_datagridview1_SearchTorrent.Size = new System.Drawing.Size(372, 26);
            this.SearchMyFolders_CM_datagridview1_SearchTorrent.Text = "Search Torrents for Missing Vars";
            this.SearchMyFolders_CM_datagridview1_SearchTorrent.Click += new System.EventHandler(this.SearchMyFolders_CM_datagridview1_SearchTorrent_Click);
            // 
            // SearchMyFolders_CM_datagridview1_SearchF95
            // 
            this.SearchMyFolders_CM_datagridview1_SearchF95.Name = "SearchMyFolders_CM_datagridview1_SearchF95";
            this.SearchMyFolders_CM_datagridview1_SearchF95.Size = new System.Drawing.Size(372, 26);
            this.SearchMyFolders_CM_datagridview1_SearchF95.Text = "Search for this Var on F95";
            this.SearchMyFolders_CM_datagridview1_SearchF95.Click += new System.EventHandler(this.SearchMyFolders_CM_datagridview1_SearchF95_Click);
            // 
            // SearchMyFolders_CM_datagridview1_SaveResultcsv
            // 
            this.SearchMyFolders_CM_datagridview1_SaveResultcsv.Name = "SearchMyFolders_CM_datagridview1_SaveResultcsv";
            this.SearchMyFolders_CM_datagridview1_SaveResultcsv.Size = new System.Drawing.Size(372, 26);
            this.SearchMyFolders_CM_datagridview1_SaveResultcsv.Text = "Save Result (.csv)";
            this.SearchMyFolders_CM_datagridview1_SaveResultcsv.Click += new System.EventHandler(this.SearchMyFolders_CM_datagridview1_SaveResultcsv_Click);
            // 
            // SearchMyFolders_CM_datagridview1_SaveDownloadLinksTxt
            // 
            this.SearchMyFolders_CM_datagridview1_SaveDownloadLinksTxt.Name = "SearchMyFolders_CM_datagridview1_SaveDownloadLinksTxt";
            this.SearchMyFolders_CM_datagridview1_SaveDownloadLinksTxt.Size = new System.Drawing.Size(372, 26);
            this.SearchMyFolders_CM_datagridview1_SaveDownloadLinksTxt.Text = "Save Download Links (.txt)";
            this.SearchMyFolders_CM_datagridview1_SaveDownloadLinksTxt.Click += new System.EventHandler(this.SearchMyFolders_CM_datagridview1_SaveDownloadLinksTxt_Click);
            // 
            // SearchMyFolders_CM_datagridview1_OpenVarLocation
            // 
            this.SearchMyFolders_CM_datagridview1_OpenVarLocation.Name = "SearchMyFolders_CM_datagridview1_OpenVarLocation";
            this.SearchMyFolders_CM_datagridview1_OpenVarLocation.Size = new System.Drawing.Size(372, 26);
            this.SearchMyFolders_CM_datagridview1_OpenVarLocation.Text = "Open Var|URL|File Location";
            this.SearchMyFolders_CM_datagridview1_OpenVarLocation.Click += new System.EventHandler(this.SearchMyFolders_CM_datagridview1_OpenVarLocation_Click);
            // 
            // SearchMyFolders_CM_datagridview1_CopyVarsToPath
            // 
            this.SearchMyFolders_CM_datagridview1_CopyVarsToPath.Name = "SearchMyFolders_CM_datagridview1_CopyVarsToPath";
            this.SearchMyFolders_CM_datagridview1_CopyVarsToPath.Size = new System.Drawing.Size(372, 26);
            this.SearchMyFolders_CM_datagridview1_CopyVarsToPath.Text = "Copy Selected Var(s) To Different Location";
            this.SearchMyFolders_CM_datagridview1_CopyVarsToPath.Click += new System.EventHandler(this.SearchMyFolders_CM_datagridview1_CopyVarsToPath_Click);
            // 
            // SearchMyFolders_CM_datagridview1_MoveVarsToPath
            // 
            this.SearchMyFolders_CM_datagridview1_MoveVarsToPath.Name = "SearchMyFolders_CM_datagridview1_MoveVarsToPath";
            this.SearchMyFolders_CM_datagridview1_MoveVarsToPath.Size = new System.Drawing.Size(372, 26);
            this.SearchMyFolders_CM_datagridview1_MoveVarsToPath.Text = "Move Selected Var(s) To Different Location";
            this.SearchMyFolders_CM_datagridview1_MoveVarsToPath.Click += new System.EventHandler(this.SearchMyFolders_CM_datagridview1_MoveVarsToPath_Click);
            // 
            // SearchMyFolders_CM_datagridview1_CancelAll
            // 
            this.SearchMyFolders_CM_datagridview1_CancelAll.Name = "SearchMyFolders_CM_datagridview1_CancelAll";
            this.SearchMyFolders_CM_datagridview1_CancelAll.Size = new System.Drawing.Size(372, 26);
            this.SearchMyFolders_CM_datagridview1_CancelAll.Text = "Cancel All Operations";
            this.SearchMyFolders_CM_datagridview1_CancelAll.Click += new System.EventHandler(this.SearchMyFolders_CM_datagridview1_CancelAll_Click);
            // 
            // SearchMyFolders_Browse_BTN
            // 
            this.SearchMyFolders_Browse_BTN.Location = new System.Drawing.Point(793, 9);
            this.SearchMyFolders_Browse_BTN.Name = "SearchMyFolders_Browse_BTN";
            this.SearchMyFolders_Browse_BTN.Size = new System.Drawing.Size(120, 24);
            this.SearchMyFolders_Browse_BTN.TabIndex = 9;
            this.SearchMyFolders_Browse_BTN.Text = "Browse";
            this.SearchMyFolders_Browse_BTN.UseSelectable = true;
            this.SearchMyFolders_Browse_BTN.Click += new System.EventHandler(this.SearchMyFolders_Browse_BTN_Click);
            // 
            // SearchMyFolders_VarsList_Txtbx
            // 
            this.SearchMyFolders_VarsList_Txtbx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchMyFolders_VarsList_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchMyFolders_VarsList_Txtbx.ContextMenuStrip = this.SearchMyFolders_CM_VarsList_Txtbx;
            this.SearchMyFolders_VarsList_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMyFolders_VarsList_Txtbx.Location = new System.Drawing.Point(12, 183);
            this.SearchMyFolders_VarsList_Txtbx.Name = "SearchMyFolders_VarsList_Txtbx";
            this.SearchMyFolders_VarsList_Txtbx.Size = new System.Drawing.Size(900, 208);
            this.SearchMyFolders_VarsList_Txtbx.TabIndex = 5;
            this.SearchMyFolders_VarsList_Txtbx.Text = "";
            this.SearchMyFolders_VarsList_Txtbx.WordWrap = false;
            // 
            // SearchMyFolders_CM_VarsList_Txtbx
            // 
            this.SearchMyFolders_CM_VarsList_Txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchMyFolders_CM_VarsList_Txtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchMyFolders_CM_VarsList_Txtbx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchMyFolders_CM_VarsList_Txtbx_Copy,
            this.SearchMyFolders_CM_VarsList_Txtbx_CopyAll,
            this.SearchMyFolders_CM_VarsList_Txtbx_Paste,
            this.SearchMyFolders_CM_VarsList_Txtbx_Clear,
            this.SearchMyFolders_CM_VarsList_Txtbx_Extract,
            this.SearchMyFolders_CM_VarsList_Txtbx_ExtractVAMMissingDependencies});
            this.SearchMyFolders_CM_VarsList_Txtbx.Name = "ContextMenu_Vars_List_Txtbx";
            this.SearchMyFolders_CM_VarsList_Txtbx.Size = new System.Drawing.Size(321, 160);
            // 
            // SearchMyFolders_CM_VarsList_Txtbx_Copy
            // 
            this.SearchMyFolders_CM_VarsList_Txtbx_Copy.Name = "SearchMyFolders_CM_VarsList_Txtbx_Copy";
            this.SearchMyFolders_CM_VarsList_Txtbx_Copy.Size = new System.Drawing.Size(320, 26);
            this.SearchMyFolders_CM_VarsList_Txtbx_Copy.Text = "Copy";
            this.SearchMyFolders_CM_VarsList_Txtbx_Copy.Click += new System.EventHandler(this.SearchMyFolders_CM_VarsList_Txtbx_Copy_Click);
            // 
            // SearchMyFolders_CM_VarsList_Txtbx_CopyAll
            // 
            this.SearchMyFolders_CM_VarsList_Txtbx_CopyAll.Name = "SearchMyFolders_CM_VarsList_Txtbx_CopyAll";
            this.SearchMyFolders_CM_VarsList_Txtbx_CopyAll.Size = new System.Drawing.Size(320, 26);
            this.SearchMyFolders_CM_VarsList_Txtbx_CopyAll.Text = "Copy All";
            this.SearchMyFolders_CM_VarsList_Txtbx_CopyAll.Click += new System.EventHandler(this.SearchMyFolders_CM_VarsList_Txtbx_CopyAll_Click);
            // 
            // SearchMyFolders_CM_VarsList_Txtbx_Paste
            // 
            this.SearchMyFolders_CM_VarsList_Txtbx_Paste.Name = "SearchMyFolders_CM_VarsList_Txtbx_Paste";
            this.SearchMyFolders_CM_VarsList_Txtbx_Paste.Size = new System.Drawing.Size(320, 26);
            this.SearchMyFolders_CM_VarsList_Txtbx_Paste.Text = "Paste";
            this.SearchMyFolders_CM_VarsList_Txtbx_Paste.Click += new System.EventHandler(this.SearchMyFolders_CM_VarsList_Txtbx_Paste_Click);
            // 
            // SearchMyFolders_CM_VarsList_Txtbx_Clear
            // 
            this.SearchMyFolders_CM_VarsList_Txtbx_Clear.Name = "SearchMyFolders_CM_VarsList_Txtbx_Clear";
            this.SearchMyFolders_CM_VarsList_Txtbx_Clear.Size = new System.Drawing.Size(320, 26);
            this.SearchMyFolders_CM_VarsList_Txtbx_Clear.Text = "Clear";
            this.SearchMyFolders_CM_VarsList_Txtbx_Clear.Click += new System.EventHandler(this.SearchMyFolders_CM_VarsList_Txtbx_Clear_Click);
            // 
            // SearchMyFolders_CM_VarsList_Txtbx_Extract
            // 
            this.SearchMyFolders_CM_VarsList_Txtbx_Extract.Name = "SearchMyFolders_CM_VarsList_Txtbx_Extract";
            this.SearchMyFolders_CM_VarsList_Txtbx_Extract.Size = new System.Drawing.Size(320, 26);
            this.SearchMyFolders_CM_VarsList_Txtbx_Extract.Text = "Extract Var Names from Text";
            this.SearchMyFolders_CM_VarsList_Txtbx_Extract.Click += new System.EventHandler(this.SearchMyFolders_CM_VarsList_Txtbx_Extract_Click);
            // 
            // SearchMyFolders_CM_VarsList_Txtbx_ExtractVAMMissingDependencies
            // 
            this.SearchMyFolders_CM_VarsList_Txtbx_ExtractVAMMissingDependencies.Name = "SearchMyFolders_CM_VarsList_Txtbx_ExtractVAMMissingDependencies";
            this.SearchMyFolders_CM_VarsList_Txtbx_ExtractVAMMissingDependencies.Size = new System.Drawing.Size(320, 26);
            this.SearchMyFolders_CM_VarsList_Txtbx_ExtractVAMMissingDependencies.Text = "Extract VaM Missing Dependencies";
            this.SearchMyFolders_CM_VarsList_Txtbx_ExtractVAMMissingDependencies.Click += new System.EventHandler(this.SearchMyFolders_CM_VarsList_Txtbx_ExtractVAMMissingDependencies_Click);
            // 
            // SearchMyFolders_VarsLocations_Txtbx
            // 
            this.SearchMyFolders_VarsLocations_Txtbx.BackColor = System.Drawing.Color.Silver;
            this.SearchMyFolders_VarsLocations_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchMyFolders_VarsLocations_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.SearchMyFolders_VarsLocations_Txtbx.Location = new System.Drawing.Point(12, 39);
            this.SearchMyFolders_VarsLocations_Txtbx.Name = "SearchMyFolders_VarsLocations_Txtbx";
            this.SearchMyFolders_VarsLocations_Txtbx.Size = new System.Drawing.Size(900, 90);
            this.SearchMyFolders_VarsLocations_Txtbx.TabIndex = 3;
            this.SearchMyFolders_VarsLocations_Txtbx.Text = "";
            this.SearchMyFolders_VarsLocations_Txtbx.WordWrap = false;
            // 
            // SearchMyFolders_Gbx1
            // 
            this.SearchMyFolders_Gbx1.BackColor = System.Drawing.Color.Transparent;
            this.SearchMyFolders_Gbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMyFolders_Gbx1.Location = new System.Drawing.Point(3, 10);
            this.SearchMyFolders_Gbx1.Name = "SearchMyFolders_Gbx1";
            this.SearchMyFolders_Gbx1.Size = new System.Drawing.Size(918, 127);
            this.SearchMyFolders_Gbx1.TabIndex = 17;
            this.SearchMyFolders_Gbx1.TabStop = false;
            this.SearchMyFolders_Gbx1.Text = "Var Locations (Repos/Addonpackages Folder)";
            // 
            // SearchMyFolders_Gbx2
            // 
            this.SearchMyFolders_Gbx2.BackColor = System.Drawing.Color.Transparent;
            this.SearchMyFolders_Gbx2.Controls.Add(this.SearchMyFolder_Browse2_BTN);
            this.SearchMyFolders_Gbx2.Controls.Add(this.SearchMyFolders_AutoDownload_Chkbx);
            this.SearchMyFolders_Gbx2.Controls.Add(this.SearchMyFolders_AutoSearch_Chkbx);
            this.SearchMyFolders_Gbx2.Controls.Add(this.SearchMyFolders_ExtractOnly_metajson_Chkbx);
            this.SearchMyFolders_Gbx2.Controls.Add(this.SearchMyFolders_ExtractVarNamesFirst_Chkbx);
            this.SearchMyFolders_Gbx2.Controls.Add(this.SearchMyFolders_Ignore_metajson_Chkbx);
            this.SearchMyFolders_Gbx2.Controls.Add(this.SearchMyFolders_StartSearching_BTN);
            this.SearchMyFolders_Gbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMyFolders_Gbx2.Location = new System.Drawing.Point(6, 153);
            this.SearchMyFolders_Gbx2.Name = "SearchMyFolders_Gbx2";
            this.SearchMyFolders_Gbx2.Size = new System.Drawing.Size(915, 262);
            this.SearchMyFolders_Gbx2.TabIndex = 18;
            this.SearchMyFolders_Gbx2.TabStop = false;
            this.SearchMyFolders_Gbx2.Text = "Vars List (Drag and drop .var | .json | .vap | .vaj | .txt | .7z | .rar | .zip | " +
    "copy paste any text with var names)";
            // 
            // SearchMyFolder_Browse2_BTN
            // 
            this.SearchMyFolder_Browse2_BTN.Location = new System.Drawing.Point(787, 0);
            this.SearchMyFolder_Browse2_BTN.Name = "SearchMyFolder_Browse2_BTN";
            this.SearchMyFolder_Browse2_BTN.Size = new System.Drawing.Size(119, 24);
            this.SearchMyFolder_Browse2_BTN.TabIndex = 18;
            this.SearchMyFolder_Browse2_BTN.Text = "Browse";
            this.SearchMyFolder_Browse2_BTN.UseSelectable = true;
            this.SearchMyFolder_Browse2_BTN.Click += new System.EventHandler(this.SearchMyFolder_Browse2_BTN_Click);
            // 
            // SearchMyFolders_AutoDownload_Chkbx
            // 
            this.SearchMyFolders_AutoDownload_Chkbx.Location = new System.Drawing.Point(98, 243);
            this.SearchMyFolders_AutoDownload_Chkbx.Name = "SearchMyFolders_AutoDownload_Chkbx";
            this.SearchMyFolders_AutoDownload_Chkbx.Size = new System.Drawing.Size(106, 15);
            this.SearchMyFolders_AutoDownload_Chkbx.TabIndex = 17;
            this.SearchMyFolders_AutoDownload_Chkbx.Text = "Auto Download";
            this.SearchMyFolders_AutoDownload_Chkbx.UseSelectable = true;
            // 
            // SearchMyFolders_AutoSearch_Chkbx
            // 
            this.SearchMyFolders_AutoSearch_Chkbx.Checked = true;
            this.SearchMyFolders_AutoSearch_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchMyFolders_AutoSearch_Chkbx.Location = new System.Drawing.Point(7, 243);
            this.SearchMyFolders_AutoSearch_Chkbx.Name = "SearchMyFolders_AutoSearch_Chkbx";
            this.SearchMyFolders_AutoSearch_Chkbx.Size = new System.Drawing.Size(87, 15);
            this.SearchMyFolders_AutoSearch_Chkbx.TabIndex = 16;
            this.SearchMyFolders_AutoSearch_Chkbx.Text = "Auto Search";
            this.SearchMyFolders_AutoSearch_Chkbx.UseSelectable = true;
            // 
            // SearchMyFolders_ExtractOnly_metajson_Chkbx
            // 
            this.SearchMyFolders_ExtractOnly_metajson_Chkbx.Location = new System.Drawing.Point(653, 243);
            this.SearchMyFolders_ExtractOnly_metajson_Chkbx.Name = "SearchMyFolders_ExtractOnly_metajson_Chkbx";
            this.SearchMyFolders_ExtractOnly_metajson_Chkbx.Size = new System.Drawing.Size(103, 15);
            this.SearchMyFolders_ExtractOnly_metajson_Chkbx.TabIndex = 14;
            this.SearchMyFolders_ExtractOnly_metajson_Chkbx.Text = "Only meta.json";
            this.SearchMyFolders_ExtractOnly_metajson_Chkbx.UseSelectable = true;
            this.SearchMyFolders_ExtractOnly_metajson_Chkbx.CheckedChanged += new System.EventHandler(this.SearchMyFolders_ExtractOnly_metajson_Chkbx_CheckedChanged);
            // 
            // SearchMyFolders_ExtractVarNamesFirst_Chkbx
            // 
            this.SearchMyFolders_ExtractVarNamesFirst_Chkbx.Location = new System.Drawing.Point(762, 243);
            this.SearchMyFolders_ExtractVarNamesFirst_Chkbx.Name = "SearchMyFolders_ExtractVarNamesFirst_Chkbx";
            this.SearchMyFolders_ExtractVarNamesFirst_Chkbx.Size = new System.Drawing.Size(144, 15);
            this.SearchMyFolders_ExtractVarNamesFirst_Chkbx.TabIndex = 13;
            this.SearchMyFolders_ExtractVarNamesFirst_Chkbx.Text = "Extract var names first?";
            this.SearchMyFolders_ExtractVarNamesFirst_Chkbx.UseSelectable = true;
            // 
            // SearchMyFolders_Ignore_metajson_Chkbx
            // 
            this.SearchMyFolders_Ignore_metajson_Chkbx.Checked = true;
            this.SearchMyFolders_Ignore_metajson_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchMyFolders_Ignore_metajson_Chkbx.Location = new System.Drawing.Point(535, 242);
            this.SearchMyFolders_Ignore_metajson_Chkbx.Name = "SearchMyFolders_Ignore_metajson_Chkbx";
            this.SearchMyFolders_Ignore_metajson_Chkbx.Size = new System.Drawing.Size(112, 15);
            this.SearchMyFolders_Ignore_metajson_Chkbx.TabIndex = 15;
            this.SearchMyFolders_Ignore_metajson_Chkbx.Text = "Ignore meta.json";
            this.SearchMyFolders_Ignore_metajson_Chkbx.UseSelectable = true;
            this.SearchMyFolders_Ignore_metajson_Chkbx.CheckedChanged += new System.EventHandler(this.SearchMyFolders_Ignore_metajson_Chkbx_CheckedChanged);
            // 
            // SearchMyFolders_StartSearching_BTN
            // 
            this.SearchMyFolders_StartSearching_BTN.Location = new System.Drawing.Point(653, 0);
            this.SearchMyFolders_StartSearching_BTN.Name = "SearchMyFolders_StartSearching_BTN";
            this.SearchMyFolders_StartSearching_BTN.Size = new System.Drawing.Size(123, 24);
            this.SearchMyFolders_StartSearching_BTN.TabIndex = 8;
            this.SearchMyFolders_StartSearching_BTN.Text = "Search";
            this.SearchMyFolders_StartSearching_BTN.UseSelectable = true;
            this.SearchMyFolders_StartSearching_BTN.Click += new System.EventHandler(this.SearchMyFolders_StartSearching_BTN_Click);
            // 
            // SearchMyFolders_Gbx3
            // 
            this.SearchMyFolders_Gbx3.BackColor = System.Drawing.Color.Transparent;
            this.SearchMyFolders_Gbx3.Controls.Add(this.SearchMyFolders_SkipHubCheck_Chkbx);
            this.SearchMyFolders_Gbx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMyFolders_Gbx3.Location = new System.Drawing.Point(6, 427);
            this.SearchMyFolders_Gbx3.Name = "SearchMyFolders_Gbx3";
            this.SearchMyFolders_Gbx3.Size = new System.Drawing.Size(915, 284);
            this.SearchMyFolders_Gbx3.TabIndex = 19;
            this.SearchMyFolders_Gbx3.TabStop = false;
            this.SearchMyFolders_Gbx3.Text = "Result";
            // 
            // SearchMyFolders_SkipHubCheck_Chkbx
            // 
            this.SearchMyFolders_SkipHubCheck_Chkbx.Location = new System.Drawing.Point(6, 261);
            this.SearchMyFolders_SkipHubCheck_Chkbx.Name = "SearchMyFolders_SkipHubCheck_Chkbx";
            this.SearchMyFolders_SkipHubCheck_Chkbx.Size = new System.Drawing.Size(107, 15);
            this.SearchMyFolders_SkipHubCheck_Chkbx.TabIndex = 0;
            this.SearchMyFolders_SkipHubCheck_Chkbx.Text = "Skip Hub Check";
            this.SearchMyFolders_SkipHubCheck_Chkbx.UseSelectable = true;
            // 
            // Tab_Extract
            // 
            this.Tab_Extract.Controls.Add(this.Extract_DownloadLinks_BTN);
            this.Tab_Extract.Controls.Add(this.Extract_GenerateDependecies_BTN);
            this.Tab_Extract.Controls.Add(this.Extract_Generate_metajson_BTN);
            this.Tab_Extract.Controls.Add(this.Extract_VarNames_BTN);
            this.Tab_Extract.Controls.Add(this.Extract_Output_Txtbx);
            this.Tab_Extract.Controls.Add(this.Extract_Gbx1);
            this.Tab_Extract.Controls.Add(this.Extract_Gbx2);
            this.Tab_Extract.HorizontalScrollbarBarColor = true;
            this.Tab_Extract.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab_Extract.HorizontalScrollbarSize = 10;
            this.Tab_Extract.Location = new System.Drawing.Point(4, 35);
            this.Tab_Extract.Name = "Tab_Extract";
            this.Tab_Extract.Size = new System.Drawing.Size(924, 732);
            this.Tab_Extract.TabIndex = 2;
            this.Tab_Extract.Text = "Extract";
            this.Tab_Extract.VerticalScrollbarBarColor = true;
            this.Tab_Extract.VerticalScrollbarHighlightOnWheel = false;
            this.Tab_Extract.VerticalScrollbarSize = 10;
            // 
            // Extract_DownloadLinks_BTN
            // 
            this.Extract_DownloadLinks_BTN.Location = new System.Drawing.Point(293, 307);
            this.Extract_DownloadLinks_BTN.Name = "Extract_DownloadLinks_BTN";
            this.Extract_DownloadLinks_BTN.Size = new System.Drawing.Size(141, 24);
            this.Extract_DownloadLinks_BTN.TabIndex = 14;
            this.Extract_DownloadLinks_BTN.Text = "Extract Download Links";
            this.Extract_DownloadLinks_BTN.UseSelectable = true;
            this.Extract_DownloadLinks_BTN.Click += new System.EventHandler(this.Extract_DownloadLinks_BTN_Click);
            // 
            // Extract_GenerateDependecies_BTN
            // 
            this.Extract_GenerateDependecies_BTN.Location = new System.Drawing.Point(293, 689);
            this.Extract_GenerateDependecies_BTN.Name = "Extract_GenerateDependecies_BTN";
            this.Extract_GenerateDependecies_BTN.Size = new System.Drawing.Size(141, 24);
            this.Extract_GenerateDependecies_BTN.TabIndex = 9;
            this.Extract_GenerateDependecies_BTN.Text = "Generate dependecies";
            this.Extract_GenerateDependecies_BTN.UseSelectable = true;
            this.Extract_GenerateDependecies_BTN.Visible = false;
            this.Extract_GenerateDependecies_BTN.Click += new System.EventHandler(this.Extract_GenerateDependecies_BTN_Click);
            // 
            // Extract_Generate_metajson_BTN
            // 
            this.Extract_Generate_metajson_BTN.Location = new System.Drawing.Point(477, 689);
            this.Extract_Generate_metajson_BTN.Name = "Extract_Generate_metajson_BTN";
            this.Extract_Generate_metajson_BTN.Size = new System.Drawing.Size(141, 24);
            this.Extract_Generate_metajson_BTN.TabIndex = 8;
            this.Extract_Generate_metajson_BTN.Text = "Generate full meta.json";
            this.Extract_Generate_metajson_BTN.UseSelectable = true;
            this.Extract_Generate_metajson_BTN.Visible = false;
            this.Extract_Generate_metajson_BTN.Click += new System.EventHandler(this.Extract_Generate_metajson_BTN_Click);
            // 
            // Extract_VarNames_BTN
            // 
            this.Extract_VarNames_BTN.Location = new System.Drawing.Point(477, 307);
            this.Extract_VarNames_BTN.Name = "Extract_VarNames_BTN";
            this.Extract_VarNames_BTN.Size = new System.Drawing.Size(141, 24);
            this.Extract_VarNames_BTN.TabIndex = 6;
            this.Extract_VarNames_BTN.Text = "Extract Var Names";
            this.Extract_VarNames_BTN.UseSelectable = true;
            this.Extract_VarNames_BTN.Click += new System.EventHandler(this.Extract_VarNames_BTN_Click);
            // 
            // Extract_Output_Txtbx
            // 
            this.Extract_Output_Txtbx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Extract_Output_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Extract_Output_Txtbx.ContextMenuStrip = this.Extract_CM_Output_Txtbx;
            this.Extract_Output_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.Extract_Output_Txtbx.Location = new System.Drawing.Point(9, 367);
            this.Extract_Output_Txtbx.Name = "Extract_Output_Txtbx";
            this.Extract_Output_Txtbx.Size = new System.Drawing.Size(900, 300);
            this.Extract_Output_Txtbx.TabIndex = 5;
            this.Extract_Output_Txtbx.Text = "";
            this.Extract_Output_Txtbx.WordWrap = false;
            // 
            // Extract_CM_Output_Txtbx
            // 
            this.Extract_CM_Output_Txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Extract_CM_Output_Txtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Extract_CM_Output_Txtbx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Extract_CM_Output_Txtbx_Copy,
            this.Extract_CM_Output_Txtbx_CopyAll,
            this.Extract_CM_Output_Txtbx_Clear});
            this.Extract_CM_Output_Txtbx.Name = "ContextMenu_Extract_Output";
            this.Extract_CM_Output_Txtbx.Size = new System.Drawing.Size(179, 82);
            // 
            // Extract_CM_Output_Txtbx_Copy
            // 
            this.Extract_CM_Output_Txtbx_Copy.Name = "Extract_CM_Output_Txtbx_Copy";
            this.Extract_CM_Output_Txtbx_Copy.Size = new System.Drawing.Size(178, 26);
            this.Extract_CM_Output_Txtbx_Copy.Text = "Copy Selected";
            this.Extract_CM_Output_Txtbx_Copy.Click += new System.EventHandler(this.Extract_CM_Output_Txtbx_Copy_Click);
            // 
            // Extract_CM_Output_Txtbx_CopyAll
            // 
            this.Extract_CM_Output_Txtbx_CopyAll.Name = "Extract_CM_Output_Txtbx_CopyAll";
            this.Extract_CM_Output_Txtbx_CopyAll.Size = new System.Drawing.Size(178, 26);
            this.Extract_CM_Output_Txtbx_CopyAll.Text = "Copy All";
            this.Extract_CM_Output_Txtbx_CopyAll.Click += new System.EventHandler(this.Extract_CM_Output_Txtbx_CopyAll_Click);
            // 
            // Extract_CM_Output_Txtbx_Clear
            // 
            this.Extract_CM_Output_Txtbx_Clear.Name = "Extract_CM_Output_Txtbx_Clear";
            this.Extract_CM_Output_Txtbx_Clear.Size = new System.Drawing.Size(178, 26);
            this.Extract_CM_Output_Txtbx_Clear.Text = "Clear All";
            this.Extract_CM_Output_Txtbx_Clear.Click += new System.EventHandler(this.Extract_CM_Output_Txtbx_Clear_Click);
            // 
            // Extract_Gbx1
            // 
            this.Extract_Gbx1.BackColor = System.Drawing.Color.Transparent;
            this.Extract_Gbx1.Controls.Add(this.Extract_Isjson_Chkbx);
            this.Extract_Gbx1.Controls.Add(this.Extract_Input_Txtbx);
            this.Extract_Gbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extract_Gbx1.Location = new System.Drawing.Point(0, 18);
            this.Extract_Gbx1.Name = "Extract_Gbx1";
            this.Extract_Gbx1.Size = new System.Drawing.Size(913, 303);
            this.Extract_Gbx1.TabIndex = 15;
            this.Extract_Gbx1.TabStop = false;
            this.Extract_Gbx1.Text = "Input: copy paste text you want to extract var names/download links from:";
            // 
            // Extract_Isjson_Chkbx
            // 
            this.Extract_Isjson_Chkbx.AutoSize = true;
            this.Extract_Isjson_Chkbx.Location = new System.Drawing.Point(6, 275);
            this.Extract_Isjson_Chkbx.Name = "Extract_Isjson_Chkbx";
            this.Extract_Isjson_Chkbx.Size = new System.Drawing.Size(61, 15);
            this.Extract_Isjson_Chkbx.TabIndex = 10;
            this.Extract_Isjson_Chkbx.Text = "Is json?";
            this.Extract_Isjson_Chkbx.UseSelectable = true;
            // 
            // Extract_Input_Txtbx
            // 
            this.Extract_Input_Txtbx.BackColor = System.Drawing.Color.Silver;
            this.Extract_Input_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Extract_Input_Txtbx.ContextMenuStrip = this.Extract_CM_Input_Txtbx;
            this.Extract_Input_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Extract_Input_Txtbx.Location = new System.Drawing.Point(6, 20);
            this.Extract_Input_Txtbx.Name = "Extract_Input_Txtbx";
            this.Extract_Input_Txtbx.Size = new System.Drawing.Size(900, 249);
            this.Extract_Input_Txtbx.TabIndex = 3;
            this.Extract_Input_Txtbx.Text = "";
            this.Extract_Input_Txtbx.WordWrap = false;
            // 
            // Extract_CM_Input_Txtbx
            // 
            this.Extract_CM_Input_Txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Extract_CM_Input_Txtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Extract_CM_Input_Txtbx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Extract_CM_Input_Txtbx_Copy,
            this.Extract_CM_Input_Txtbx_Paste,
            this.Extract_CM_Input_Txtbx_Clear});
            this.Extract_CM_Input_Txtbx.Name = "ContextMenu_input_var_text";
            this.Extract_CM_Input_Txtbx.Size = new System.Drawing.Size(179, 82);
            // 
            // Extract_CM_Input_Txtbx_Copy
            // 
            this.Extract_CM_Input_Txtbx_Copy.Name = "Extract_CM_Input_Txtbx_Copy";
            this.Extract_CM_Input_Txtbx_Copy.Size = new System.Drawing.Size(178, 26);
            this.Extract_CM_Input_Txtbx_Copy.Text = "Copy Selected";
            this.Extract_CM_Input_Txtbx_Copy.Click += new System.EventHandler(this.Extract_CM_Input_Txtbx_Copy_Click);
            // 
            // Extract_CM_Input_Txtbx_Paste
            // 
            this.Extract_CM_Input_Txtbx_Paste.Name = "Extract_CM_Input_Txtbx_Paste";
            this.Extract_CM_Input_Txtbx_Paste.Size = new System.Drawing.Size(178, 26);
            this.Extract_CM_Input_Txtbx_Paste.Text = "Paste";
            this.Extract_CM_Input_Txtbx_Paste.Click += new System.EventHandler(this.Extract_CM_Input_Txtbx_Paste_Click);
            // 
            // Extract_CM_Input_Txtbx_Clear
            // 
            this.Extract_CM_Input_Txtbx_Clear.Name = "Extract_CM_Input_Txtbx_Clear";
            this.Extract_CM_Input_Txtbx_Clear.Size = new System.Drawing.Size(178, 26);
            this.Extract_CM_Input_Txtbx_Clear.Text = "Clear All";
            this.Extract_CM_Input_Txtbx_Clear.Click += new System.EventHandler(this.Extract_CM_Input_Txtbx_Clear_Click);
            // 
            // Extract_Gbx2
            // 
            this.Extract_Gbx2.BackColor = System.Drawing.Color.Transparent;
            this.Extract_Gbx2.Controls.Add(this.Extract_GetSubDependencies_Chkbx);
            this.Extract_Gbx2.Controls.Add(this.Extract_LicenseType_Chkbx);
            this.Extract_Gbx2.Location = new System.Drawing.Point(0, 348);
            this.Extract_Gbx2.Name = "Extract_Gbx2";
            this.Extract_Gbx2.Size = new System.Drawing.Size(913, 354);
            this.Extract_Gbx2.TabIndex = 16;
            this.Extract_Gbx2.TabStop = false;
            this.Extract_Gbx2.Text = "Output";
            // 
            // Extract_GetSubDependencies_Chkbx
            // 
            this.Extract_GetSubDependencies_Chkbx.AutoSize = true;
            this.Extract_GetSubDependencies_Chkbx.Location = new System.Drawing.Point(95, 330);
            this.Extract_GetSubDependencies_Chkbx.Name = "Extract_GetSubDependencies_Chkbx";
            this.Extract_GetSubDependencies_Chkbx.Size = new System.Drawing.Size(120, 15);
            this.Extract_GetSubDependencies_Chkbx.TabIndex = 13;
            this.Extract_GetSubDependencies_Chkbx.Text = "Sub Dependencies";
            this.Extract_GetSubDependencies_Chkbx.UseSelectable = true;
            this.Extract_GetSubDependencies_Chkbx.Visible = false;
            // 
            // Extract_LicenseType_Chkbx
            // 
            this.Extract_LicenseType_Chkbx.AutoSize = true;
            this.Extract_LicenseType_Chkbx.Checked = true;
            this.Extract_LicenseType_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Extract_LicenseType_Chkbx.Location = new System.Drawing.Point(6, 330);
            this.Extract_LicenseType_Chkbx.Name = "Extract_LicenseType_Chkbx";
            this.Extract_LicenseType_Chkbx.Size = new System.Drawing.Size(83, 15);
            this.Extract_LicenseType_Chkbx.TabIndex = 11;
            this.Extract_LicenseType_Chkbx.Text = "licenseType";
            this.Extract_LicenseType_Chkbx.UseSelectable = true;
            // 
            // Tab_Missing_from_F95
            // 
            this.Tab_Missing_from_F95.Controls.Add(this.metroLabel5);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_DeleteZipAfterUploading_Chkbx);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_ExtractVarNames_BTN);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_Browse_BTN);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_Pixeldrain_Txtbx);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_PixeldrainUpload_Chkbx);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_IncludeVarImages_Chkbx);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_BrowseZip_BTN);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_ZipSavePath_Txtbx);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_zip_BTN);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_dataGridView);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_Search_BTN);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_IncludedModelsAssets_Txtbx);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_Gbx1);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_Gbx2);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_Gbx3);
            this.Tab_Missing_from_F95.Controls.Add(this.MissingFromF95_Gbx4);
            this.Tab_Missing_from_F95.HorizontalScrollbarBarColor = true;
            this.Tab_Missing_from_F95.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab_Missing_from_F95.HorizontalScrollbarSize = 10;
            this.Tab_Missing_from_F95.Location = new System.Drawing.Point(4, 35);
            this.Tab_Missing_from_F95.Name = "Tab_Missing_from_F95";
            this.Tab_Missing_from_F95.Size = new System.Drawing.Size(924, 732);
            this.Tab_Missing_from_F95.TabIndex = 3;
            this.Tab_Missing_from_F95.Text = "Vars Missing from F95";
            this.Tab_Missing_from_F95.VerticalScrollbarBarColor = true;
            this.Tab_Missing_from_F95.VerticalScrollbarHighlightOnWheel = false;
            this.Tab_Missing_from_F95.VerticalScrollbarSize = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(26, 3);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(863, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "This function is used to scan your creator\'s folders for vars not shared yet on F" +
    "95, zip these vars, upload them, then share the download link on F95.";
            // 
            // MissingFromF95_DeleteZipAfterUploading_Chkbx
            // 
            this.MissingFromF95_DeleteZipAfterUploading_Chkbx.AutoSize = true;
            this.MissingFromF95_DeleteZipAfterUploading_Chkbx.Location = new System.Drawing.Point(448, 671);
            this.MissingFromF95_DeleteZipAfterUploading_Chkbx.Name = "MissingFromF95_DeleteZipAfterUploading_Chkbx";
            this.MissingFromF95_DeleteZipAfterUploading_Chkbx.Size = new System.Drawing.Size(168, 15);
            this.MissingFromF95_DeleteZipAfterUploading_Chkbx.TabIndex = 22;
            this.MissingFromF95_DeleteZipAfterUploading_Chkbx.Text = "Delete Zip After Uploading?";
            this.MissingFromF95_DeleteZipAfterUploading_Chkbx.UseSelectable = true;
            // 
            // MissingFromF95_ExtractVarNames_BTN
            // 
            this.MissingFromF95_ExtractVarNames_BTN.Location = new System.Drawing.Point(329, 339);
            this.MissingFromF95_ExtractVarNames_BTN.Name = "MissingFromF95_ExtractVarNames_BTN";
            this.MissingFromF95_ExtractVarNames_BTN.Size = new System.Drawing.Size(123, 24);
            this.MissingFromF95_ExtractVarNames_BTN.TabIndex = 20;
            this.MissingFromF95_ExtractVarNames_BTN.Text = "2) Extract Var Names";
            this.MissingFromF95_ExtractVarNames_BTN.UseSelectable = true;
            this.MissingFromF95_ExtractVarNames_BTN.Click += new System.EventHandler(this.MissingFromF95_ExtractVarNames_BTN_Click);
            // 
            // MissingFromF95_Browse_BTN
            // 
            this.MissingFromF95_Browse_BTN.Location = new System.Drawing.Point(800, 25);
            this.MissingFromF95_Browse_BTN.Name = "MissingFromF95_Browse_BTN";
            this.MissingFromF95_Browse_BTN.Size = new System.Drawing.Size(112, 23);
            this.MissingFromF95_Browse_BTN.TabIndex = 19;
            this.MissingFromF95_Browse_BTN.Text = "Browse";
            this.MissingFromF95_Browse_BTN.UseSelectable = true;
            this.MissingFromF95_Browse_BTN.Click += new System.EventHandler(this.MissingFromF95_Browse_Click);
            // 
            // MissingFromF95_Pixeldrain_Txtbx
            // 
            // 
            // 
            // 
            this.MissingFromF95_Pixeldrain_Txtbx.CustomButton.Image = null;
            this.MissingFromF95_Pixeldrain_Txtbx.CustomButton.Location = new System.Drawing.Point(608, 2);
            this.MissingFromF95_Pixeldrain_Txtbx.CustomButton.Name = "";
            this.MissingFromF95_Pixeldrain_Txtbx.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.MissingFromF95_Pixeldrain_Txtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MissingFromF95_Pixeldrain_Txtbx.CustomButton.TabIndex = 1;
            this.MissingFromF95_Pixeldrain_Txtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MissingFromF95_Pixeldrain_Txtbx.CustomButton.UseSelectable = true;
            this.MissingFromF95_Pixeldrain_Txtbx.CustomButton.Visible = false;
            this.MissingFromF95_Pixeldrain_Txtbx.Lines = new string[] {
        "Link will appear here after uploading is finished."};
            this.MissingFromF95_Pixeldrain_Txtbx.Location = new System.Drawing.Point(178, 694);
            this.MissingFromF95_Pixeldrain_Txtbx.MaxLength = 32767;
            this.MissingFromF95_Pixeldrain_Txtbx.Name = "MissingFromF95_Pixeldrain_Txtbx";
            this.MissingFromF95_Pixeldrain_Txtbx.PasswordChar = '\0';
            this.MissingFromF95_Pixeldrain_Txtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MissingFromF95_Pixeldrain_Txtbx.SelectedText = "";
            this.MissingFromF95_Pixeldrain_Txtbx.SelectionLength = 0;
            this.MissingFromF95_Pixeldrain_Txtbx.SelectionStart = 0;
            this.MissingFromF95_Pixeldrain_Txtbx.ShortcutsEnabled = true;
            this.MissingFromF95_Pixeldrain_Txtbx.Size = new System.Drawing.Size(630, 24);
            this.MissingFromF95_Pixeldrain_Txtbx.TabIndex = 18;
            this.MissingFromF95_Pixeldrain_Txtbx.Text = "Link will appear here after uploading is finished.";
            this.MissingFromF95_Pixeldrain_Txtbx.UseSelectable = true;
            this.MissingFromF95_Pixeldrain_Txtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MissingFromF95_Pixeldrain_Txtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MissingFromF95_PixeldrainUpload_Chkbx
            // 
            this.MissingFromF95_PixeldrainUpload_Chkbx.AutoSize = true;
            this.MissingFromF95_PixeldrainUpload_Chkbx.Location = new System.Drawing.Point(307, 671);
            this.MissingFromF95_PixeldrainUpload_Chkbx.Name = "MissingFromF95_PixeldrainUpload_Chkbx";
            this.MissingFromF95_PixeldrainUpload_Chkbx.Size = new System.Drawing.Size(135, 15);
            this.MissingFromF95_PixeldrainUpload_Chkbx.TabIndex = 17;
            this.MissingFromF95_PixeldrainUpload_Chkbx.Text = "Upload to pixeldrain?";
            this.MissingFromF95_PixeldrainUpload_Chkbx.UseSelectable = true;
            // 
            // MissingFromF95_IncludeVarImages_Chkbx
            // 
            this.MissingFromF95_IncludeVarImages_Chkbx.AutoSize = true;
            this.MissingFromF95_IncludeVarImages_Chkbx.Checked = true;
            this.MissingFromF95_IncludeVarImages_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MissingFromF95_IncludeVarImages_Chkbx.Location = new System.Drawing.Point(179, 670);
            this.MissingFromF95_IncludeVarImages_Chkbx.Name = "MissingFromF95_IncludeVarImages_Chkbx";
            this.MissingFromF95_IncludeVarImages_Chkbx.Size = new System.Drawing.Size(122, 15);
            this.MissingFromF95_IncludeVarImages_Chkbx.TabIndex = 16;
            this.MissingFromF95_IncludeVarImages_Chkbx.Text = "Include Var Images";
            this.MissingFromF95_IncludeVarImages_Chkbx.UseSelectable = true;
            // 
            // MissingFromF95_BrowseZip_BTN
            // 
            this.MissingFromF95_BrowseZip_BTN.Location = new System.Drawing.Point(839, 641);
            this.MissingFromF95_BrowseZip_BTN.Name = "MissingFromF95_BrowseZip_BTN";
            this.MissingFromF95_BrowseZip_BTN.Size = new System.Drawing.Size(75, 24);
            this.MissingFromF95_BrowseZip_BTN.TabIndex = 14;
            this.MissingFromF95_BrowseZip_BTN.Text = "Browse";
            this.MissingFromF95_BrowseZip_BTN.UseSelectable = true;
            this.MissingFromF95_BrowseZip_BTN.Click += new System.EventHandler(this.MissingFromF95_BrowseZip_BTN_Click);
            // 
            // MissingFromF95_ZipSavePath_Txtbx
            // 
            // 
            // 
            // 
            this.MissingFromF95_ZipSavePath_Txtbx.CustomButton.Image = null;
            this.MissingFromF95_ZipSavePath_Txtbx.CustomButton.Location = new System.Drawing.Point(608, 2);
            this.MissingFromF95_ZipSavePath_Txtbx.CustomButton.Name = "";
            this.MissingFromF95_ZipSavePath_Txtbx.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.MissingFromF95_ZipSavePath_Txtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.MissingFromF95_ZipSavePath_Txtbx.CustomButton.TabIndex = 1;
            this.MissingFromF95_ZipSavePath_Txtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.MissingFromF95_ZipSavePath_Txtbx.CustomButton.UseSelectable = true;
            this.MissingFromF95_ZipSavePath_Txtbx.CustomButton.Visible = false;
            this.MissingFromF95_ZipSavePath_Txtbx.Lines = new string[0];
            this.MissingFromF95_ZipSavePath_Txtbx.Location = new System.Drawing.Point(179, 641);
            this.MissingFromF95_ZipSavePath_Txtbx.MaxLength = 32767;
            this.MissingFromF95_ZipSavePath_Txtbx.Name = "MissingFromF95_ZipSavePath_Txtbx";
            this.MissingFromF95_ZipSavePath_Txtbx.PasswordChar = '\0';
            this.MissingFromF95_ZipSavePath_Txtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MissingFromF95_ZipSavePath_Txtbx.SelectedText = "";
            this.MissingFromF95_ZipSavePath_Txtbx.SelectionLength = 0;
            this.MissingFromF95_ZipSavePath_Txtbx.SelectionStart = 0;
            this.MissingFromF95_ZipSavePath_Txtbx.ShortcutsEnabled = true;
            this.MissingFromF95_ZipSavePath_Txtbx.Size = new System.Drawing.Size(630, 24);
            this.MissingFromF95_ZipSavePath_Txtbx.TabIndex = 13;
            this.MissingFromF95_ZipSavePath_Txtbx.UseSelectable = true;
            this.MissingFromF95_ZipSavePath_Txtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.MissingFromF95_ZipSavePath_Txtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // MissingFromF95_zip_BTN
            // 
            this.MissingFromF95_zip_BTN.Location = new System.Drawing.Point(12, 641);
            this.MissingFromF95_zip_BTN.Name = "MissingFromF95_zip_BTN";
            this.MissingFromF95_zip_BTN.Size = new System.Drawing.Size(162, 24);
            this.MissingFromF95_zip_BTN.TabIndex = 12;
            this.MissingFromF95_zip_BTN.Text = "Zip Missing Vars";
            this.MissingFromF95_zip_BTN.UseSelectable = true;
            this.MissingFromF95_zip_BTN.Click += new System.EventHandler(this.MissingFromF95_zipButton_Click);
            // 
            // MissingFromF95_dataGridView
            // 
            this.MissingFromF95_dataGridView.AllowUserToAddRows = false;
            this.MissingFromF95_dataGridView.AllowUserToOrderColumns = true;
            this.MissingFromF95_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MissingFromF95_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MissingFromF95_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.MissingFromF95_dataGridView.ContextMenuStrip = this.MissingFromF95_CM_dataGridView;
            this.MissingFromF95_dataGridView.Location = new System.Drawing.Point(11, 381);
            this.MissingFromF95_dataGridView.Name = "MissingFromF95_dataGridView";
            this.MissingFromF95_dataGridView.Size = new System.Drawing.Size(900, 228);
            this.MissingFromF95_dataGridView.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Var";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 48;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Result";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // MissingFromF95_CM_dataGridView
            // 
            this.MissingFromF95_CM_dataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MissingFromF95_CM_dataGridView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MissingFromF95_CM_dataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MissingFromF95_CM_dataGridView_Copy});
            this.MissingFromF95_CM_dataGridView.Name = "ContextMenu_dataGridView2";
            this.MissingFromF95_CM_dataGridView.Size = new System.Drawing.Size(117, 30);
            // 
            // MissingFromF95_CM_dataGridView_Copy
            // 
            this.MissingFromF95_CM_dataGridView_Copy.Name = "MissingFromF95_CM_dataGridView_Copy";
            this.MissingFromF95_CM_dataGridView_Copy.Size = new System.Drawing.Size(116, 26);
            this.MissingFromF95_CM_dataGridView_Copy.Text = "Copy";
            this.MissingFromF95_CM_dataGridView_Copy.Click += new System.EventHandler(this.MissingFromF95_CM_dataGridView_Copy_Click);
            // 
            // MissingFromF95_Search_BTN
            // 
            this.MissingFromF95_Search_BTN.Location = new System.Drawing.Point(469, 339);
            this.MissingFromF95_Search_BTN.Name = "MissingFromF95_Search_BTN";
            this.MissingFromF95_Search_BTN.Size = new System.Drawing.Size(123, 24);
            this.MissingFromF95_Search_BTN.TabIndex = 6;
            this.MissingFromF95_Search_BTN.Text = "3) Search";
            this.MissingFromF95_Search_BTN.UseSelectable = true;
            this.MissingFromF95_Search_BTN.Click += new System.EventHandler(this.MissingFromF95_Search_BTN_Click);
            // 
            // MissingFromF95_IncludedModelsAssets_Txtbx
            // 
            this.MissingFromF95_IncludedModelsAssets_Txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.MissingFromF95_IncludedModelsAssets_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MissingFromF95_IncludedModelsAssets_Txtbx.ContextMenuStrip = this.MissingFromF95_CM_IncludedModelsAssets_Txtbx;
            this.MissingFromF95_IncludedModelsAssets_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissingFromF95_IncludedModelsAssets_Txtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MissingFromF95_IncludedModelsAssets_Txtbx.Location = new System.Drawing.Point(11, 158);
            this.MissingFromF95_IncludedModelsAssets_Txtbx.Name = "MissingFromF95_IncludedModelsAssets_Txtbx";
            this.MissingFromF95_IncludedModelsAssets_Txtbx.Size = new System.Drawing.Size(900, 177);
            this.MissingFromF95_IncludedModelsAssets_Txtbx.TabIndex = 5;
            this.MissingFromF95_IncludedModelsAssets_Txtbx.Text = "";
            this.MissingFromF95_IncludedModelsAssets_Txtbx.WordWrap = false;
            // 
            // MissingFromF95_CM_IncludedModelsAssets_Txtbx
            // 
            this.MissingFromF95_CM_IncludedModelsAssets_Txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MissingFromF95_CM_IncludedModelsAssets_Txtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MissingFromF95_CM_IncludedModelsAssets_Txtbx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MissingFromF95_CM_IncludedModelsAssets_CopyAll,
            this.MissingFromF95_CM_IncludedModelsAssets_CopySelected,
            this.MissingFromF95_CM_IncludedModelsAssets_Paste,
            this.MissingFromF95_CM_IncludedModelsAssets_ClearAll});
            this.MissingFromF95_CM_IncludedModelsAssets_Txtbx.Name = "ContextMenu_F95_Included_Assets";
            this.MissingFromF95_CM_IncludedModelsAssets_Txtbx.Size = new System.Drawing.Size(179, 108);
            // 
            // MissingFromF95_CM_IncludedModelsAssets_CopyAll
            // 
            this.MissingFromF95_CM_IncludedModelsAssets_CopyAll.Name = "MissingFromF95_CM_IncludedModelsAssets_CopyAll";
            this.MissingFromF95_CM_IncludedModelsAssets_CopyAll.Size = new System.Drawing.Size(178, 26);
            this.MissingFromF95_CM_IncludedModelsAssets_CopyAll.Text = "Copy All";
            this.MissingFromF95_CM_IncludedModelsAssets_CopyAll.Click += new System.EventHandler(this.MissingFromF95_CM_IncludedModelsAssets_CopyAll_Click);
            // 
            // MissingFromF95_CM_IncludedModelsAssets_CopySelected
            // 
            this.MissingFromF95_CM_IncludedModelsAssets_CopySelected.Name = "MissingFromF95_CM_IncludedModelsAssets_CopySelected";
            this.MissingFromF95_CM_IncludedModelsAssets_CopySelected.Size = new System.Drawing.Size(178, 26);
            this.MissingFromF95_CM_IncludedModelsAssets_CopySelected.Text = "Copy Selected";
            this.MissingFromF95_CM_IncludedModelsAssets_CopySelected.Click += new System.EventHandler(this.MissingFromF95_CM_IncludedModelsAssets_CopySelected_Click);
            // 
            // MissingFromF95_CM_IncludedModelsAssets_Paste
            // 
            this.MissingFromF95_CM_IncludedModelsAssets_Paste.Name = "MissingFromF95_CM_IncludedModelsAssets_Paste";
            this.MissingFromF95_CM_IncludedModelsAssets_Paste.Size = new System.Drawing.Size(178, 26);
            this.MissingFromF95_CM_IncludedModelsAssets_Paste.Text = "Paste";
            this.MissingFromF95_CM_IncludedModelsAssets_Paste.Click += new System.EventHandler(this.MissingFromF95_CM_IncludedModelsAssets_Paste_Click);
            // 
            // MissingFromF95_CM_IncludedModelsAssets_ClearAll
            // 
            this.MissingFromF95_CM_IncludedModelsAssets_ClearAll.Name = "MissingFromF95_CM_IncludedModelsAssets_ClearAll";
            this.MissingFromF95_CM_IncludedModelsAssets_ClearAll.Size = new System.Drawing.Size(178, 26);
            this.MissingFromF95_CM_IncludedModelsAssets_ClearAll.Text = "Clear All";
            this.MissingFromF95_CM_IncludedModelsAssets_ClearAll.Click += new System.EventHandler(this.MissingFromF95_CM_IncludedModelsAssets_ClearAll_Click);
            // 
            // MissingFromF95_Gbx1
            // 
            this.MissingFromF95_Gbx1.BackColor = System.Drawing.Color.Transparent;
            this.MissingFromF95_Gbx1.Controls.Add(this.MissingFromF95_CreatorPaths_Txtbx);
            this.MissingFromF95_Gbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissingFromF95_Gbx1.Location = new System.Drawing.Point(3, 28);
            this.MissingFromF95_Gbx1.Name = "MissingFromF95_Gbx1";
            this.MissingFromF95_Gbx1.Size = new System.Drawing.Size(918, 102);
            this.MissingFromF95_Gbx1.TabIndex = 23;
            this.MissingFromF95_Gbx1.TabStop = false;
            this.MissingFromF95_Gbx1.Text = "0. Select Creator\'s Folder/s";
            // 
            // MissingFromF95_CreatorPaths_Txtbx
            // 
            this.MissingFromF95_CreatorPaths_Txtbx.BackColor = System.Drawing.Color.Silver;
            this.MissingFromF95_CreatorPaths_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MissingFromF95_CreatorPaths_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.MissingFromF95_CreatorPaths_Txtbx.Location = new System.Drawing.Point(8, 26);
            this.MissingFromF95_CreatorPaths_Txtbx.Name = "MissingFromF95_CreatorPaths_Txtbx";
            this.MissingFromF95_CreatorPaths_Txtbx.Size = new System.Drawing.Size(900, 66);
            this.MissingFromF95_CreatorPaths_Txtbx.TabIndex = 3;
            this.MissingFromF95_CreatorPaths_Txtbx.Text = "";
            this.MissingFromF95_CreatorPaths_Txtbx.WordWrap = false;
            // 
            // MissingFromF95_Gbx2
            // 
            this.MissingFromF95_Gbx2.BackColor = System.Drawing.Color.Transparent;
            this.MissingFromF95_Gbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissingFromF95_Gbx2.Location = new System.Drawing.Point(3, 137);
            this.MissingFromF95_Gbx2.Name = "MissingFromF95_Gbx2";
            this.MissingFromF95_Gbx2.Size = new System.Drawing.Size(918, 215);
            this.MissingFromF95_Gbx2.TabIndex = 24;
            this.MissingFromF95_Gbx2.TabStop = false;
            this.MissingFromF95_Gbx2.Text = "1. Copy and Paste F95 Included Models/Assets and Changelog:";
            // 
            // MissingFromF95_Gbx3
            // 
            this.MissingFromF95_Gbx3.BackColor = System.Drawing.Color.Transparent;
            this.MissingFromF95_Gbx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MissingFromF95_Gbx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissingFromF95_Gbx3.Location = new System.Drawing.Point(3, 361);
            this.MissingFromF95_Gbx3.Name = "MissingFromF95_Gbx3";
            this.MissingFromF95_Gbx3.Size = new System.Drawing.Size(918, 255);
            this.MissingFromF95_Gbx3.TabIndex = 25;
            this.MissingFromF95_Gbx3.TabStop = false;
            this.MissingFromF95_Gbx3.Text = "4. Result";
            // 
            // MissingFromF95_Gbx4
            // 
            this.MissingFromF95_Gbx4.BackColor = System.Drawing.Color.Transparent;
            this.MissingFromF95_Gbx4.Controls.Add(this.MissingFromF95_YingYang_PixelDrain);
            this.MissingFromF95_Gbx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissingFromF95_Gbx4.Location = new System.Drawing.Point(3, 622);
            this.MissingFromF95_Gbx4.Name = "MissingFromF95_Gbx4";
            this.MissingFromF95_Gbx4.Size = new System.Drawing.Size(918, 106);
            this.MissingFromF95_Gbx4.TabIndex = 26;
            this.MissingFromF95_Gbx4.TabStop = false;
            this.MissingFromF95_Gbx4.Text = "5. Share";
            // 
            // MissingFromF95_YingYang_PixelDrain
            // 
            this.MissingFromF95_YingYang_PixelDrain.Image = global::Sharp_VaM_Tools.Properties.Resources.YingYang;
            this.MissingFromF95_YingYang_PixelDrain.Location = new System.Drawing.Point(136, 64);
            this.MissingFromF95_YingYang_PixelDrain.Name = "MissingFromF95_YingYang_PixelDrain";
            this.MissingFromF95_YingYang_PixelDrain.Size = new System.Drawing.Size(33, 36);
            this.MissingFromF95_YingYang_PixelDrain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MissingFromF95_YingYang_PixelDrain.TabIndex = 21;
            this.MissingFromF95_YingYang_PixelDrain.TabStop = false;
            this.MissingFromF95_YingYang_PixelDrain.Visible = false;
            // 
            // Tab_Search_Inside_vars
            // 
            this.Tab_Search_Inside_vars.AllowDrop = true;
            this.Tab_Search_Inside_vars.Controls.Add(this.metroLabel12);
            this.Tab_Search_Inside_vars.Controls.Add(this.SearchInsideVars_Browse_BTN);
            this.Tab_Search_Inside_vars.Controls.Add(this.SearchInsideVars_BuildingDone_Lbl);
            this.Tab_Search_Inside_vars.Controls.Add(this.SearchInsideVars_KeepBookmarks_Chkbx);
            this.Tab_Search_Inside_vars.Controls.Add(this.SearchInsideVars_Append_Chkbx);
            this.Tab_Search_Inside_vars.Controls.Add(this.SearchInsideVars_db_Path_Txtbx);
            this.Tab_Search_Inside_vars.Controls.Add(this.SearchInsideVars_BuildDatabase_BTN);
            this.Tab_Search_Inside_vars.Controls.Add(this.SearchInsideVars_dataGridView);
            this.Tab_Search_Inside_vars.Controls.Add(this.SearchInsideVars_SearchStrings_Txtbx);
            this.Tab_Search_Inside_vars.Controls.Add(this.SearchInsideVars_VarPaths_Txtbx);
            this.Tab_Search_Inside_vars.Controls.Add(this.SearchInsideVars_YingYangBuildDB_Pic);
            this.Tab_Search_Inside_vars.Controls.Add(this.SearchInsideVars_Gbx1);
            this.Tab_Search_Inside_vars.Controls.Add(this.SearchInsideVars_Gbx2);
            this.Tab_Search_Inside_vars.Controls.Add(this.SearchInsideVars_Gbx3);
            this.Tab_Search_Inside_vars.HorizontalScrollbarBarColor = true;
            this.Tab_Search_Inside_vars.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab_Search_Inside_vars.HorizontalScrollbarSize = 10;
            this.Tab_Search_Inside_vars.Location = new System.Drawing.Point(4, 35);
            this.Tab_Search_Inside_vars.Name = "Tab_Search_Inside_vars";
            this.Tab_Search_Inside_vars.Size = new System.Drawing.Size(924, 732);
            this.Tab_Search_Inside_vars.TabIndex = 4;
            this.Tab_Search_Inside_vars.Text = "Search Inside Vars";
            this.Tab_Search_Inside_vars.VerticalScrollbarBarColor = true;
            this.Tab_Search_Inside_vars.VerticalScrollbarHighlightOnWheel = false;
            this.Tab_Search_Inside_vars.VerticalScrollbarSize = 10;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(824, 194);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(57, 19);
            this.metroLabel12.TabIndex = 18;
            this.metroLabel12.Text = "Subfilter";
            // 
            // SearchInsideVars_Browse_BTN
            // 
            this.SearchInsideVars_Browse_BTN.Location = new System.Drawing.Point(795, 8);
            this.SearchInsideVars_Browse_BTN.Name = "SearchInsideVars_Browse_BTN";
            this.SearchInsideVars_Browse_BTN.Size = new System.Drawing.Size(117, 23);
            this.SearchInsideVars_Browse_BTN.TabIndex = 13;
            this.SearchInsideVars_Browse_BTN.Text = "Browse Folder(s)";
            this.SearchInsideVars_Browse_BTN.UseSelectable = true;
            this.SearchInsideVars_Browse_BTN.Click += new System.EventHandler(this.SearchInsideVars_Browse_BTN_Click);
            // 
            // SearchInsideVars_BuildingDone_Lbl
            // 
            this.SearchInsideVars_BuildingDone_Lbl.AutoSize = true;
            this.SearchInsideVars_BuildingDone_Lbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SearchInsideVars_BuildingDone_Lbl.ForeColor = System.Drawing.Color.Black;
            this.SearchInsideVars_BuildingDone_Lbl.Location = new System.Drawing.Point(801, 120);
            this.SearchInsideVars_BuildingDone_Lbl.Name = "SearchInsideVars_BuildingDone_Lbl";
            this.SearchInsideVars_BuildingDone_Lbl.Size = new System.Drawing.Size(99, 19);
            this.SearchInsideVars_BuildingDone_Lbl.TabIndex = 12;
            this.SearchInsideVars_BuildingDone_Lbl.Text = "Building Done!";
            this.SearchInsideVars_BuildingDone_Lbl.Visible = false;
            // 
            // SearchInsideVars_KeepBookmarks_Chkbx
            // 
            this.SearchInsideVars_KeepBookmarks_Chkbx.AutoSize = true;
            this.SearchInsideVars_KeepBookmarks_Chkbx.Checked = true;
            this.SearchInsideVars_KeepBookmarks_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SearchInsideVars_KeepBookmarks_Chkbx.Location = new System.Drawing.Point(76, 121);
            this.SearchInsideVars_KeepBookmarks_Chkbx.Name = "SearchInsideVars_KeepBookmarks_Chkbx";
            this.SearchInsideVars_KeepBookmarks_Chkbx.Size = new System.Drawing.Size(116, 15);
            this.SearchInsideVars_KeepBookmarks_Chkbx.TabIndex = 10;
            this.SearchInsideVars_KeepBookmarks_Chkbx.Text = "Keep Bookmarks?";
            this.SearchInsideVars_KeepBookmarks_Chkbx.UseSelectable = true;
            // 
            // SearchInsideVars_Append_Chkbx
            // 
            this.SearchInsideVars_Append_Chkbx.AutoSize = true;
            this.SearchInsideVars_Append_Chkbx.Location = new System.Drawing.Point(4, 121);
            this.SearchInsideVars_Append_Chkbx.Name = "SearchInsideVars_Append_Chkbx";
            this.SearchInsideVars_Append_Chkbx.Size = new System.Drawing.Size(65, 15);
            this.SearchInsideVars_Append_Chkbx.TabIndex = 9;
            this.SearchInsideVars_Append_Chkbx.Text = "Append";
            this.SearchInsideVars_Append_Chkbx.UseSelectable = true;
            // 
            // SearchInsideVars_db_Path_Txtbx
            // 
            // 
            // 
            // 
            this.SearchInsideVars_db_Path_Txtbx.CustomButton.Image = null;
            this.SearchInsideVars_db_Path_Txtbx.CustomButton.Location = new System.Drawing.Point(749, 2);
            this.SearchInsideVars_db_Path_Txtbx.CustomButton.Name = "";
            this.SearchInsideVars_db_Path_Txtbx.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.SearchInsideVars_db_Path_Txtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchInsideVars_db_Path_Txtbx.CustomButton.TabIndex = 1;
            this.SearchInsideVars_db_Path_Txtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchInsideVars_db_Path_Txtbx.CustomButton.UseSelectable = true;
            this.SearchInsideVars_db_Path_Txtbx.CustomButton.Visible = false;
            this.SearchInsideVars_db_Path_Txtbx.Lines = new string[] {
        "metroTextBox1"};
            this.SearchInsideVars_db_Path_Txtbx.Location = new System.Drawing.Point(4, 91);
            this.SearchInsideVars_db_Path_Txtbx.MaxLength = 32767;
            this.SearchInsideVars_db_Path_Txtbx.Name = "SearchInsideVars_db_Path_Txtbx";
            this.SearchInsideVars_db_Path_Txtbx.PasswordChar = '\0';
            this.SearchInsideVars_db_Path_Txtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchInsideVars_db_Path_Txtbx.SelectedText = "";
            this.SearchInsideVars_db_Path_Txtbx.SelectionLength = 0;
            this.SearchInsideVars_db_Path_Txtbx.SelectionStart = 0;
            this.SearchInsideVars_db_Path_Txtbx.ShortcutsEnabled = true;
            this.SearchInsideVars_db_Path_Txtbx.Size = new System.Drawing.Size(771, 24);
            this.SearchInsideVars_db_Path_Txtbx.TabIndex = 8;
            this.SearchInsideVars_db_Path_Txtbx.Text = "metroTextBox1";
            this.SearchInsideVars_db_Path_Txtbx.UseSelectable = true;
            this.SearchInsideVars_db_Path_Txtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchInsideVars_db_Path_Txtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SearchInsideVars_BuildDatabase_BTN
            // 
            this.SearchInsideVars_BuildDatabase_BTN.Location = new System.Drawing.Point(795, 91);
            this.SearchInsideVars_BuildDatabase_BTN.Name = "SearchInsideVars_BuildDatabase_BTN";
            this.SearchInsideVars_BuildDatabase_BTN.Size = new System.Drawing.Size(117, 23);
            this.SearchInsideVars_BuildDatabase_BTN.TabIndex = 7;
            this.SearchInsideVars_BuildDatabase_BTN.Text = "Build Database";
            this.SearchInsideVars_BuildDatabase_BTN.UseSelectable = true;
            this.SearchInsideVars_BuildDatabase_BTN.Click += new System.EventHandler(this.SearchInsideVars_BuildDatabase_BTN_Click);
            // 
            // SearchInsideVars_dataGridView
            // 
            this.SearchInsideVars_dataGridView.AllowUserToAddRows = false;
            this.SearchInsideVars_dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchInsideVars_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchInsideVars_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.SearchInsideVars_dataGridView.ContextMenuStrip = this.SearchInsideVars_CM_dataGridView;
            this.SearchInsideVars_dataGridView.Location = new System.Drawing.Point(6, 273);
            this.SearchInsideVars_dataGridView.Name = "SearchInsideVars_dataGridView";
            this.SearchInsideVars_dataGridView.Size = new System.Drawing.Size(907, 222);
            this.SearchInsideVars_dataGridView.TabIndex = 6;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Keyword";
            this.Column2.Name = "Column2";
            this.Column2.Width = 73;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Result";
            this.Column1.Name = "Column1";
            // 
            // SearchInsideVars_CM_dataGridView
            // 
            this.SearchInsideVars_CM_dataGridView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchInsideVars_CM_dataGridView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchInsideVars_CM_dataGridView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchInsideVars_CM_dataGridView_Copy,
            this.SearchInsideVars_CM_dataGridView_CopyCrc,
            this.SearchInsideVars_CM_dataGridView_CopyPathJson,
            this.SearchInsideVars_CM_dataGridView_CopyPathJsonLatest,
            this.SearchInsideVars_CM_dataGridView_Bookmark,
            this.SearchInsideVars_CM_dataGridView_RemoveBookmark,
            this.SearchInsideVars_CM_dataGridView_OpenVarLocation});
            this.SearchInsideVars_CM_dataGridView.Name = "ContextMenu_dataGridView3";
            this.SearchInsideVars_CM_dataGridView.Size = new System.Drawing.Size(291, 186);
            // 
            // SearchInsideVars_CM_dataGridView_Copy
            // 
            this.SearchInsideVars_CM_dataGridView_Copy.Name = "SearchInsideVars_CM_dataGridView_Copy";
            this.SearchInsideVars_CM_dataGridView_Copy.Size = new System.Drawing.Size(290, 26);
            this.SearchInsideVars_CM_dataGridView_Copy.Text = "Copy";
            this.SearchInsideVars_CM_dataGridView_Copy.Click += new System.EventHandler(this.SearchInsideVars_CM_dataGridView_Copy_Click);
            // 
            // SearchInsideVars_CM_dataGridView_CopyCrc
            // 
            this.SearchInsideVars_CM_dataGridView_CopyCrc.Name = "SearchInsideVars_CM_dataGridView_CopyCrc";
            this.SearchInsideVars_CM_dataGridView_CopyCrc.Size = new System.Drawing.Size(290, 26);
            this.SearchInsideVars_CM_dataGridView_CopyCrc.Text = "Copy CRC";
            this.SearchInsideVars_CM_dataGridView_CopyCrc.Click += new System.EventHandler(this.SearchInsideVars_CM_dataGridView_CopyCrc_Click);
            // 
            // SearchInsideVars_CM_dataGridView_CopyPathJson
            // 
            this.SearchInsideVars_CM_dataGridView_CopyPathJson.Name = "SearchInsideVars_CM_dataGridView_CopyPathJson";
            this.SearchInsideVars_CM_dataGridView_CopyPathJson.Size = new System.Drawing.Size(290, 26);
            this.SearchInsideVars_CM_dataGridView_CopyPathJson.Text = "Copy Full Path (for json)";
            this.SearchInsideVars_CM_dataGridView_CopyPathJson.Click += new System.EventHandler(this.SearchInsideVars_CM_dataGridView_CopyPathJson_Click);
            // 
            // SearchInsideVars_CM_dataGridView_CopyPathJsonLatest
            // 
            this.SearchInsideVars_CM_dataGridView_CopyPathJsonLatest.Name = "SearchInsideVars_CM_dataGridView_CopyPathJsonLatest";
            this.SearchInsideVars_CM_dataGridView_CopyPathJsonLatest.Size = new System.Drawing.Size(290, 26);
            this.SearchInsideVars_CM_dataGridView_CopyPathJsonLatest.Text = "Copy Full Path .latest (for json)";
            this.SearchInsideVars_CM_dataGridView_CopyPathJsonLatest.Click += new System.EventHandler(this.SearchInsideVars_CM_dataGridView_CopyPathJsonLatest_Click);
            // 
            // SearchInsideVars_CM_dataGridView_Bookmark
            // 
            this.SearchInsideVars_CM_dataGridView_Bookmark.Name = "SearchInsideVars_CM_dataGridView_Bookmark";
            this.SearchInsideVars_CM_dataGridView_Bookmark.Size = new System.Drawing.Size(290, 26);
            this.SearchInsideVars_CM_dataGridView_Bookmark.Text = "Bookmark";
            this.SearchInsideVars_CM_dataGridView_Bookmark.Click += new System.EventHandler(this.SearchInsideVars_CM_dataGridView_Bookmark_Click);
            // 
            // SearchInsideVars_CM_dataGridView_RemoveBookmark
            // 
            this.SearchInsideVars_CM_dataGridView_RemoveBookmark.Name = "SearchInsideVars_CM_dataGridView_RemoveBookmark";
            this.SearchInsideVars_CM_dataGridView_RemoveBookmark.Size = new System.Drawing.Size(290, 26);
            this.SearchInsideVars_CM_dataGridView_RemoveBookmark.Text = "Remove from Bookmarks";
            this.SearchInsideVars_CM_dataGridView_RemoveBookmark.Click += new System.EventHandler(this.SearchInsideVars_CM_dataGridView_RemoveBookmark_Click);
            // 
            // SearchInsideVars_CM_dataGridView_OpenVarLocation
            // 
            this.SearchInsideVars_CM_dataGridView_OpenVarLocation.Name = "SearchInsideVars_CM_dataGridView_OpenVarLocation";
            this.SearchInsideVars_CM_dataGridView_OpenVarLocation.Size = new System.Drawing.Size(290, 26);
            this.SearchInsideVars_CM_dataGridView_OpenVarLocation.Text = "Open Var Location";
            this.SearchInsideVars_CM_dataGridView_OpenVarLocation.Click += new System.EventHandler(this.SearchInsideVars_CM_dataGridView_OpenVarLocation_Click);
            // 
            // SearchInsideVars_SearchStrings_Txtbx
            // 
            // 
            // 
            // 
            this.SearchInsideVars_SearchStrings_Txtbx.CustomButton.Image = null;
            this.SearchInsideVars_SearchStrings_Txtbx.CustomButton.Location = new System.Drawing.Point(746, 2);
            this.SearchInsideVars_SearchStrings_Txtbx.CustomButton.Name = "";
            this.SearchInsideVars_SearchStrings_Txtbx.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.SearchInsideVars_SearchStrings_Txtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchInsideVars_SearchStrings_Txtbx.CustomButton.TabIndex = 1;
            this.SearchInsideVars_SearchStrings_Txtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchInsideVars_SearchStrings_Txtbx.CustomButton.UseSelectable = true;
            this.SearchInsideVars_SearchStrings_Txtbx.CustomButton.Visible = false;
            this.SearchInsideVars_SearchStrings_Txtbx.Lines = new string[] {
        "Enhanced Eyes Realastic.vam;93CA8E6D;Enhanced EyeLid Blender.vam"};
            this.SearchInsideVars_SearchStrings_Txtbx.Location = new System.Drawing.Point(6, 216);
            this.SearchInsideVars_SearchStrings_Txtbx.MaxLength = 32767;
            this.SearchInsideVars_SearchStrings_Txtbx.Name = "SearchInsideVars_SearchStrings_Txtbx";
            this.SearchInsideVars_SearchStrings_Txtbx.PasswordChar = '\0';
            this.SearchInsideVars_SearchStrings_Txtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchInsideVars_SearchStrings_Txtbx.SelectedText = "";
            this.SearchInsideVars_SearchStrings_Txtbx.SelectionLength = 0;
            this.SearchInsideVars_SearchStrings_Txtbx.SelectionStart = 0;
            this.SearchInsideVars_SearchStrings_Txtbx.ShortcutsEnabled = true;
            this.SearchInsideVars_SearchStrings_Txtbx.Size = new System.Drawing.Size(768, 24);
            this.SearchInsideVars_SearchStrings_Txtbx.TabIndex = 4;
            this.SearchInsideVars_SearchStrings_Txtbx.Text = "Enhanced Eyes Realastic.vam;93CA8E6D;Enhanced EyeLid Blender.vam";
            this.SearchInsideVars_SearchStrings_Txtbx.UseSelectable = true;
            this.SearchInsideVars_SearchStrings_Txtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchInsideVars_SearchStrings_Txtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SearchInsideVars_VarPaths_Txtbx
            // 
            this.SearchInsideVars_VarPaths_Txtbx.BackColor = System.Drawing.Color.Silver;
            this.SearchInsideVars_VarPaths_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchInsideVars_VarPaths_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.SearchInsideVars_VarPaths_Txtbx.Location = new System.Drawing.Point(3, 36);
            this.SearchInsideVars_VarPaths_Txtbx.Name = "SearchInsideVars_VarPaths_Txtbx";
            this.SearchInsideVars_VarPaths_Txtbx.Size = new System.Drawing.Size(909, 45);
            this.SearchInsideVars_VarPaths_Txtbx.TabIndex = 3;
            this.SearchInsideVars_VarPaths_Txtbx.Text = "";
            // 
            // SearchInsideVars_YingYangBuildDB_Pic
            // 
            this.SearchInsideVars_YingYangBuildDB_Pic.Image = global::Sharp_VaM_Tools.Properties.Resources.YingYang;
            this.SearchInsideVars_YingYangBuildDB_Pic.Location = new System.Drawing.Point(833, 117);
            this.SearchInsideVars_YingYangBuildDB_Pic.Name = "SearchInsideVars_YingYangBuildDB_Pic";
            this.SearchInsideVars_YingYangBuildDB_Pic.Size = new System.Drawing.Size(39, 42);
            this.SearchInsideVars_YingYangBuildDB_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchInsideVars_YingYangBuildDB_Pic.TabIndex = 22;
            this.SearchInsideVars_YingYangBuildDB_Pic.TabStop = false;
            this.SearchInsideVars_YingYangBuildDB_Pic.Visible = false;
            // 
            // SearchInsideVars_Gbx1
            // 
            this.SearchInsideVars_Gbx1.BackColor = System.Drawing.Color.Transparent;
            this.SearchInsideVars_Gbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchInsideVars_Gbx1.Location = new System.Drawing.Point(0, 8);
            this.SearchInsideVars_Gbx1.Name = "SearchInsideVars_Gbx1";
            this.SearchInsideVars_Gbx1.Size = new System.Drawing.Size(924, 153);
            this.SearchInsideVars_Gbx1.TabIndex = 30;
            this.SearchInsideVars_Gbx1.TabStop = false;
            this.SearchInsideVars_Gbx1.Text = "1. Build Database";
            // 
            // SearchInsideVars_Gbx2
            // 
            this.SearchInsideVars_Gbx2.BackColor = System.Drawing.Color.Transparent;
            this.SearchInsideVars_Gbx2.Controls.Add(this.metroLabel11);
            this.SearchInsideVars_Gbx2.Controls.Add(this.SearchInsideVars_UseSubfilter_Chkbx);
            this.SearchInsideVars_Gbx2.Controls.Add(this.SearchInsideVars_Cancel_BTN);
            this.SearchInsideVars_Gbx2.Controls.Add(this.SearchInsideVars_IsMorph_Chkbx);
            this.SearchInsideVars_Gbx2.Controls.Add(this.SearchInsideVars_SearchSubfilter_Txtbx);
            this.SearchInsideVars_Gbx2.Controls.Add(this.SearchInsideVars_SearchDatabase_BTN);
            this.SearchInsideVars_Gbx2.Controls.Add(this.SearchInsideVars_SearchFolders_BTN);
            this.SearchInsideVars_Gbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchInsideVars_Gbx2.Location = new System.Drawing.Point(0, 175);
            this.SearchInsideVars_Gbx2.Name = "SearchInsideVars_Gbx2";
            this.SearchInsideVars_Gbx2.Size = new System.Drawing.Size(924, 325);
            this.SearchInsideVars_Gbx2.TabIndex = 31;
            this.SearchInsideVars_Gbx2.TabStop = false;
            this.SearchInsideVars_Gbx2.Text = "2. Search Inside Vars (Clean Vars)";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(3, 19);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(306, 19);
            this.metroLabel11.TabIndex = 17;
            this.metroLabel11.Text = "Add Keyword(s) or CRC seperated by semicolon (;)";
            // 
            // SearchInsideVars_UseSubfilter_Chkbx
            // 
            this.SearchInsideVars_UseSubfilter_Chkbx.AutoSize = true;
            this.SearchInsideVars_UseSubfilter_Chkbx.Location = new System.Drawing.Point(88, 70);
            this.SearchInsideVars_UseSubfilter_Chkbx.Name = "SearchInsideVars_UseSubfilter_Chkbx";
            this.SearchInsideVars_UseSubfilter_Chkbx.Size = new System.Drawing.Size(94, 15);
            this.SearchInsideVars_UseSubfilter_Chkbx.TabIndex = 16;
            this.SearchInsideVars_UseSubfilter_Chkbx.Text = "Use Subfilter?";
            this.SearchInsideVars_UseSubfilter_Chkbx.UseSelectable = true;
            // 
            // SearchInsideVars_Cancel_BTN
            // 
            this.SearchInsideVars_Cancel_BTN.Location = new System.Drawing.Point(531, 69);
            this.SearchInsideVars_Cancel_BTN.Name = "SearchInsideVars_Cancel_BTN";
            this.SearchInsideVars_Cancel_BTN.Size = new System.Drawing.Size(117, 24);
            this.SearchInsideVars_Cancel_BTN.TabIndex = 21;
            this.SearchInsideVars_Cancel_BTN.Text = "Cancel Search";
            this.SearchInsideVars_Cancel_BTN.UseSelectable = true;
            this.SearchInsideVars_Cancel_BTN.Click += new System.EventHandler(this.SearchInsideVars_Cancel_BTN_Click);
            // 
            // SearchInsideVars_IsMorph_Chkbx
            // 
            this.SearchInsideVars_IsMorph_Chkbx.AutoSize = true;
            this.SearchInsideVars_IsMorph_Chkbx.Location = new System.Drawing.Point(6, 71);
            this.SearchInsideVars_IsMorph_Chkbx.Name = "SearchInsideVars_IsMorph_Chkbx";
            this.SearchInsideVars_IsMorph_Chkbx.Size = new System.Drawing.Size(75, 15);
            this.SearchInsideVars_IsMorph_Chkbx.TabIndex = 14;
            this.SearchInsideVars_IsMorph_Chkbx.Text = "Is Morph?";
            this.SearchInsideVars_IsMorph_Chkbx.UseSelectable = true;
            // 
            // SearchInsideVars_SearchSubfilter_Txtbx
            // 
            // 
            // 
            // 
            this.SearchInsideVars_SearchSubfilter_Txtbx.CustomButton.Image = null;
            this.SearchInsideVars_SearchSubfilter_Txtbx.CustomButton.Location = new System.Drawing.Point(95, 2);
            this.SearchInsideVars_SearchSubfilter_Txtbx.CustomButton.Name = "";
            this.SearchInsideVars_SearchSubfilter_Txtbx.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.SearchInsideVars_SearchSubfilter_Txtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchInsideVars_SearchSubfilter_Txtbx.CustomButton.TabIndex = 1;
            this.SearchInsideVars_SearchSubfilter_Txtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchInsideVars_SearchSubfilter_Txtbx.CustomButton.UseSelectable = true;
            this.SearchInsideVars_SearchSubfilter_Txtbx.CustomButton.Visible = false;
            this.SearchInsideVars_SearchSubfilter_Txtbx.Lines = new string[] {
        "Hunting-Succubus."};
            this.SearchInsideVars_SearchSubfilter_Txtbx.Location = new System.Drawing.Point(795, 41);
            this.SearchInsideVars_SearchSubfilter_Txtbx.MaxLength = 32767;
            this.SearchInsideVars_SearchSubfilter_Txtbx.Name = "SearchInsideVars_SearchSubfilter_Txtbx";
            this.SearchInsideVars_SearchSubfilter_Txtbx.PasswordChar = '\0';
            this.SearchInsideVars_SearchSubfilter_Txtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchInsideVars_SearchSubfilter_Txtbx.SelectedText = "";
            this.SearchInsideVars_SearchSubfilter_Txtbx.SelectionLength = 0;
            this.SearchInsideVars_SearchSubfilter_Txtbx.SelectionStart = 0;
            this.SearchInsideVars_SearchSubfilter_Txtbx.ShortcutsEnabled = true;
            this.SearchInsideVars_SearchSubfilter_Txtbx.Size = new System.Drawing.Size(117, 24);
            this.SearchInsideVars_SearchSubfilter_Txtbx.TabIndex = 15;
            this.SearchInsideVars_SearchSubfilter_Txtbx.Text = "Hunting-Succubus.";
            this.SearchInsideVars_SearchSubfilter_Txtbx.UseSelectable = true;
            this.SearchInsideVars_SearchSubfilter_Txtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchInsideVars_SearchSubfilter_Txtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SearchInsideVars_SearchDatabase_BTN
            // 
            this.SearchInsideVars_SearchDatabase_BTN.Location = new System.Drawing.Point(795, 71);
            this.SearchInsideVars_SearchDatabase_BTN.Name = "SearchInsideVars_SearchDatabase_BTN";
            this.SearchInsideVars_SearchDatabase_BTN.Size = new System.Drawing.Size(117, 23);
            this.SearchInsideVars_SearchDatabase_BTN.TabIndex = 11;
            this.SearchInsideVars_SearchDatabase_BTN.Text = "Search Database";
            this.SearchInsideVars_SearchDatabase_BTN.UseSelectable = true;
            this.SearchInsideVars_SearchDatabase_BTN.Click += new System.EventHandler(this.SearchInsideVars_SearchDatabase_BTN_Click);
            // 
            // SearchInsideVars_SearchFolders_BTN
            // 
            this.SearchInsideVars_SearchFolders_BTN.Location = new System.Drawing.Point(657, 69);
            this.SearchInsideVars_SearchFolders_BTN.Name = "SearchInsideVars_SearchFolders_BTN";
            this.SearchInsideVars_SearchFolders_BTN.Size = new System.Drawing.Size(117, 24);
            this.SearchInsideVars_SearchFolders_BTN.TabIndex = 5;
            this.SearchInsideVars_SearchFolders_BTN.Text = "Search Folders";
            this.SearchInsideVars_SearchFolders_BTN.UseSelectable = true;
            this.SearchInsideVars_SearchFolders_BTN.Click += new System.EventHandler(this.SearchInsideVars_SearchFolders_BTN_Click);
            // 
            // SearchInsideVars_Gbx3
            // 
            this.SearchInsideVars_Gbx3.BackColor = System.Drawing.Color.Transparent;
            this.SearchInsideVars_Gbx3.Controls.Add(this.SearchInsideVars_AnalyzeVars_YinYang_Pic);
            this.SearchInsideVars_Gbx3.Controls.Add(this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx);
            this.SearchInsideVars_Gbx3.Controls.Add(this.SearchInsideVars_VarToCRCAndPaths_Txtbx);
            this.SearchInsideVars_Gbx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchInsideVars_Gbx3.Location = new System.Drawing.Point(0, 504);
            this.SearchInsideVars_Gbx3.Name = "SearchInsideVars_Gbx3";
            this.SearchInsideVars_Gbx3.Size = new System.Drawing.Size(924, 224);
            this.SearchInsideVars_Gbx3.TabIndex = 32;
            this.SearchInsideVars_Gbx3.TabStop = false;
            this.SearchInsideVars_Gbx3.Text = "3. List Var(s) Content and CRC (Drag and Drop Var/s)";
            // 
            // SearchInsideVars_AnalyzeVars_YinYang_Pic
            // 
            this.SearchInsideVars_AnalyzeVars_YinYang_Pic.Image = ((System.Drawing.Image)(resources.GetObject("SearchInsideVars_AnalyzeVars_YinYang_Pic.Image")));
            this.SearchInsideVars_AnalyzeVars_YinYang_Pic.Location = new System.Drawing.Point(891, 194);
            this.SearchInsideVars_AnalyzeVars_YinYang_Pic.Name = "SearchInsideVars_AnalyzeVars_YinYang_Pic";
            this.SearchInsideVars_AnalyzeVars_YinYang_Pic.Size = new System.Drawing.Size(21, 24);
            this.SearchInsideVars_AnalyzeVars_YinYang_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SearchInsideVars_AnalyzeVars_YinYang_Pic.TabIndex = 20;
            this.SearchInsideVars_AnalyzeVars_YinYang_Pic.TabStop = false;
            this.SearchInsideVars_AnalyzeVars_YinYang_Pic.Visible = false;
            // 
            // SearchInsideVars_SearchVarToCRCAndPathsTxtbx
            // 
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.CustomButton.Image = null;
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.CustomButton.Name = "";
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.CustomButton.TabIndex = 1;
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.CustomButton.UseSelectable = true;
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.CustomButton.Visible = false;
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.Lines = new string[] {
        "Search ......"};
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.Location = new System.Drawing.Point(783, 15);
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.MaxLength = 32767;
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.Name = "SearchInsideVars_SearchVarToCRCAndPathsTxtbx";
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.PasswordChar = '\0';
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.SelectedText = "";
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.SelectionLength = 0;
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.SelectionStart = 0;
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.ShortcutsEnabled = true;
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.Size = new System.Drawing.Size(132, 21);
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.TabIndex = 20;
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.Text = "Search ......";
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.UseSelectable = true;
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx.TextChanged += new System.EventHandler(this.SearchInsideVars_SearchVarToCRCAndPathsTxtbx_TextChanged);
            // 
            // SearchInsideVars_VarToCRCAndPaths_Txtbx
            // 
            this.SearchInsideVars_VarToCRCAndPaths_Txtbx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SearchInsideVars_VarToCRCAndPaths_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchInsideVars_VarToCRCAndPaths_Txtbx.ContextMenuStrip = this.SearchInsideVars_CM_VarToCRCAndPaths;
            this.SearchInsideVars_VarToCRCAndPaths_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchInsideVars_VarToCRCAndPaths_Txtbx.Location = new System.Drawing.Point(6, 15);
            this.SearchInsideVars_VarToCRCAndPaths_Txtbx.Name = "SearchInsideVars_VarToCRCAndPaths_Txtbx";
            this.SearchInsideVars_VarToCRCAndPaths_Txtbx.Size = new System.Drawing.Size(909, 203);
            this.SearchInsideVars_VarToCRCAndPaths_Txtbx.TabIndex = 19;
            this.SearchInsideVars_VarToCRCAndPaths_Txtbx.Text = "";
            this.SearchInsideVars_VarToCRCAndPaths_Txtbx.WordWrap = false;
            // 
            // SearchInsideVars_CM_VarToCRCAndPaths
            // 
            this.SearchInsideVars_CM_VarToCRCAndPaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchInsideVars_CM_VarToCRCAndPaths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SearchInsideVars_CM_VarToCRCAndPaths.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchInsideVars_CM_VarToCRCAndPaths_Browse,
            this.SearchInsideVars_CM_VarToCRCAndPaths_CopySelected,
            this.SearchInsideVars_CM_VarToCRCAndPaths_CopyAll,
            this.SearchInsideVars_CM_VarToCRCAndPaths_ClearAll,
            this.SearchInsideVars_CM_VarToCRCAndPaths_CancelAll});
            this.SearchInsideVars_CM_VarToCRCAndPaths.Name = "CM_var_to_crc_and_path";
            this.SearchInsideVars_CM_VarToCRCAndPaths.Size = new System.Drawing.Size(230, 134);
            // 
            // SearchInsideVars_CM_VarToCRCAndPaths_Browse
            // 
            this.SearchInsideVars_CM_VarToCRCAndPaths_Browse.Name = "SearchInsideVars_CM_VarToCRCAndPaths_Browse";
            this.SearchInsideVars_CM_VarToCRCAndPaths_Browse.Size = new System.Drawing.Size(229, 26);
            this.SearchInsideVars_CM_VarToCRCAndPaths_Browse.Text = "Browse Var(s)";
            this.SearchInsideVars_CM_VarToCRCAndPaths_Browse.Click += new System.EventHandler(this.SearchInsideVars_CM_VarToCRCAndPaths_Browse_Click);
            // 
            // SearchInsideVars_CM_VarToCRCAndPaths_CopySelected
            // 
            this.SearchInsideVars_CM_VarToCRCAndPaths_CopySelected.Name = "SearchInsideVars_CM_VarToCRCAndPaths_CopySelected";
            this.SearchInsideVars_CM_VarToCRCAndPaths_CopySelected.Size = new System.Drawing.Size(229, 26);
            this.SearchInsideVars_CM_VarToCRCAndPaths_CopySelected.Text = "Copy Selected";
            this.SearchInsideVars_CM_VarToCRCAndPaths_CopySelected.Click += new System.EventHandler(this.SearchInsideVars_CM_VarToCRCAndPaths_CopySelected_Click);
            // 
            // SearchInsideVars_CM_VarToCRCAndPaths_CopyAll
            // 
            this.SearchInsideVars_CM_VarToCRCAndPaths_CopyAll.Name = "SearchInsideVars_CM_VarToCRCAndPaths_CopyAll";
            this.SearchInsideVars_CM_VarToCRCAndPaths_CopyAll.Size = new System.Drawing.Size(229, 26);
            this.SearchInsideVars_CM_VarToCRCAndPaths_CopyAll.Text = "Copy All";
            this.SearchInsideVars_CM_VarToCRCAndPaths_CopyAll.Click += new System.EventHandler(this.SearchInsideVars_CM_VarToCRCAndPaths_CopyAll_Click);
            // 
            // SearchInsideVars_CM_VarToCRCAndPaths_ClearAll
            // 
            this.SearchInsideVars_CM_VarToCRCAndPaths_ClearAll.Name = "SearchInsideVars_CM_VarToCRCAndPaths_ClearAll";
            this.SearchInsideVars_CM_VarToCRCAndPaths_ClearAll.Size = new System.Drawing.Size(229, 26);
            this.SearchInsideVars_CM_VarToCRCAndPaths_ClearAll.Text = "Clear All";
            this.SearchInsideVars_CM_VarToCRCAndPaths_ClearAll.Click += new System.EventHandler(this.SearchInsideVars_CM_VarToCRCAndPaths_ClearAll_Click);
            // 
            // SearchInsideVars_CM_VarToCRCAndPaths_CancelAll
            // 
            this.SearchInsideVars_CM_VarToCRCAndPaths_CancelAll.Name = "SearchInsideVars_CM_VarToCRCAndPaths_CancelAll";
            this.SearchInsideVars_CM_VarToCRCAndPaths_CancelAll.Size = new System.Drawing.Size(229, 26);
            this.SearchInsideVars_CM_VarToCRCAndPaths_CancelAll.Text = "Cancel All Operations";
            this.SearchInsideVars_CM_VarToCRCAndPaths_CancelAll.Click += new System.EventHandler(this.SearchInsideVars_CM_VarToCRCAndPaths_CancelAll_Click);
            // 
            // Tab_Analyze_Vars
            // 
            this.Tab_Analyze_Vars.Controls.Add(this.AnalyzeVars_GBX4);
            this.Tab_Analyze_Vars.HorizontalScrollbarBarColor = true;
            this.Tab_Analyze_Vars.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab_Analyze_Vars.HorizontalScrollbarSize = 10;
            this.Tab_Analyze_Vars.Location = new System.Drawing.Point(4, 35);
            this.Tab_Analyze_Vars.Name = "Tab_Analyze_Vars";
            this.Tab_Analyze_Vars.Size = new System.Drawing.Size(924, 732);
            this.Tab_Analyze_Vars.TabIndex = 7;
            this.Tab_Analyze_Vars.Text = "Analyze Vars";
            this.Tab_Analyze_Vars.VerticalScrollbarBarColor = true;
            this.Tab_Analyze_Vars.VerticalScrollbarHighlightOnWheel = false;
            this.Tab_Analyze_Vars.VerticalScrollbarSize = 10;
            // 
            // AnalyzeVars_GBX4
            // 
            this.AnalyzeVars_GBX4.BackColor = System.Drawing.Color.Transparent;
            this.AnalyzeVars_GBX4.Controls.Add(this.AnalyzeVars_Search_Txtbx);
            this.AnalyzeVars_GBX4.Controls.Add(this.AnalyzeVars_Cencel_BTN);
            this.AnalyzeVars_GBX4.Controls.Add(this.AnalyzeVars_Gbx2);
            this.AnalyzeVars_GBX4.Controls.Add(this.AnalyzeVars_Gbx3);
            this.AnalyzeVars_GBX4.Controls.Add(this.AnalyzeVars_Browse_BTN);
            this.AnalyzeVars_GBX4.Controls.Add(this.AnalyzeVars_Result_Txtbx);
            this.AnalyzeVars_GBX4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalyzeVars_GBX4.Location = new System.Drawing.Point(6, 18);
            this.AnalyzeVars_GBX4.Name = "AnalyzeVars_GBX4";
            this.AnalyzeVars_GBX4.Size = new System.Drawing.Size(915, 534);
            this.AnalyzeVars_GBX4.TabIndex = 26;
            this.AnalyzeVars_GBX4.TabStop = false;
            this.AnalyzeVars_GBX4.Text = "Drag and drop Var(s) | Folder(s)";
            // 
            // AnalyzeVars_Search_Txtbx
            // 
            this.AnalyzeVars_Search_Txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            // 
            // 
            // 
            this.AnalyzeVars_Search_Txtbx.CustomButton.Image = null;
            this.AnalyzeVars_Search_Txtbx.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.AnalyzeVars_Search_Txtbx.CustomButton.Name = "";
            this.AnalyzeVars_Search_Txtbx.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.AnalyzeVars_Search_Txtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.AnalyzeVars_Search_Txtbx.CustomButton.TabIndex = 1;
            this.AnalyzeVars_Search_Txtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.AnalyzeVars_Search_Txtbx.CustomButton.UseSelectable = true;
            this.AnalyzeVars_Search_Txtbx.CustomButton.Visible = false;
            this.AnalyzeVars_Search_Txtbx.ForeColor = System.Drawing.SystemColors.Control;
            this.AnalyzeVars_Search_Txtbx.Lines = new string[] {
        "Search ......"};
            this.AnalyzeVars_Search_Txtbx.Location = new System.Drawing.Point(786, 27);
            this.AnalyzeVars_Search_Txtbx.MaxLength = 32767;
            this.AnalyzeVars_Search_Txtbx.Name = "AnalyzeVars_Search_Txtbx";
            this.AnalyzeVars_Search_Txtbx.PasswordChar = '\0';
            this.AnalyzeVars_Search_Txtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AnalyzeVars_Search_Txtbx.SelectedText = "";
            this.AnalyzeVars_Search_Txtbx.SelectionLength = 0;
            this.AnalyzeVars_Search_Txtbx.SelectionStart = 0;
            this.AnalyzeVars_Search_Txtbx.ShortcutsEnabled = true;
            this.AnalyzeVars_Search_Txtbx.Size = new System.Drawing.Size(106, 21);
            this.AnalyzeVars_Search_Txtbx.TabIndex = 41;
            this.AnalyzeVars_Search_Txtbx.Text = "Search ......";
            this.AnalyzeVars_Search_Txtbx.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AnalyzeVars_Search_Txtbx.UseCustomBackColor = true;
            this.AnalyzeVars_Search_Txtbx.UseCustomForeColor = true;
            this.AnalyzeVars_Search_Txtbx.UseSelectable = true;
            this.AnalyzeVars_Search_Txtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.AnalyzeVars_Search_Txtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.AnalyzeVars_Search_Txtbx.TextChanged += new System.EventHandler(this.AnalyzeVars_Search_Txtbx_TextChanged);
            // 
            // AnalyzeVars_Cencel_BTN
            // 
            this.AnalyzeVars_Cencel_BTN.Location = new System.Drawing.Point(657, 0);
            this.AnalyzeVars_Cencel_BTN.Name = "AnalyzeVars_Cencel_BTN";
            this.AnalyzeVars_Cencel_BTN.Size = new System.Drawing.Size(123, 21);
            this.AnalyzeVars_Cencel_BTN.TabIndex = 40;
            this.AnalyzeVars_Cencel_BTN.Text = "Cancel";
            this.AnalyzeVars_Cencel_BTN.UseSelectable = true;
            this.AnalyzeVars_Cencel_BTN.Visible = false;
            this.AnalyzeVars_Cencel_BTN.Click += new System.EventHandler(this.AnalyzeVars_Cencel_BTN_Click);
            // 
            // AnalyzeVars_Gbx2
            // 
            this.AnalyzeVars_Gbx2.BackColor = System.Drawing.Color.Transparent;
            this.AnalyzeVars_Gbx2.Controls.Add(this.AnalyzeVars_ListVarsContent_Chkbx);
            this.AnalyzeVars_Gbx2.Controls.Add(this.AnalyzeVars_DetectPlugins_Chkbx);
            this.AnalyzeVars_Gbx2.Controls.Add(this.AnalyzeVars_LocalReferences_Chkbx);
            this.AnalyzeVars_Gbx2.Controls.Add(this.AnalyzeVars_BloatedVar_Chkbx);
            this.AnalyzeVars_Gbx2.Controls.Add(this.AnalyzeVars_Morphs_Chkbx);
            this.AnalyzeVars_Gbx2.Controls.Add(this.AnalyzeVars_DeserializeJson_Chkbx);
            this.AnalyzeVars_Gbx2.Controls.Add(this.AnalyzeVars_metaJson_Chkbx);
            this.AnalyzeVars_Gbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalyzeVars_Gbx2.Location = new System.Drawing.Point(10, 409);
            this.AnalyzeVars_Gbx2.Name = "AnalyzeVars_Gbx2";
            this.AnalyzeVars_Gbx2.Size = new System.Drawing.Size(899, 51);
            this.AnalyzeVars_Gbx2.TabIndex = 39;
            this.AnalyzeVars_Gbx2.TabStop = false;
            this.AnalyzeVars_Gbx2.Text = "Var Issues:";
            // 
            // AnalyzeVars_ListVarsContent_Chkbx
            // 
            this.AnalyzeVars_ListVarsContent_Chkbx.AutoSize = true;
            this.AnalyzeVars_ListVarsContent_Chkbx.Location = new System.Drawing.Point(775, 22);
            this.AnalyzeVars_ListVarsContent_Chkbx.Name = "AnalyzeVars_ListVarsContent_Chkbx";
            this.AnalyzeVars_ListVarsContent_Chkbx.Size = new System.Drawing.Size(119, 15);
            this.AnalyzeVars_ListVarsContent_Chkbx.TabIndex = 38;
            this.AnalyzeVars_ListVarsContent_Chkbx.Text = "List Var(s) Content";
            this.AnalyzeVars_ListVarsContent_Chkbx.UseSelectable = true;
            // 
            // AnalyzeVars_DetectPlugins_Chkbx
            // 
            this.AnalyzeVars_DetectPlugins_Chkbx.AutoSize = true;
            this.AnalyzeVars_DetectPlugins_Chkbx.Checked = true;
            this.AnalyzeVars_DetectPlugins_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnalyzeVars_DetectPlugins_Chkbx.Location = new System.Drawing.Point(478, 22);
            this.AnalyzeVars_DetectPlugins_Chkbx.Name = "AnalyzeVars_DetectPlugins_Chkbx";
            this.AnalyzeVars_DetectPlugins_Chkbx.Size = new System.Drawing.Size(99, 15);
            this.AnalyzeVars_DetectPlugins_Chkbx.TabIndex = 36;
            this.AnalyzeVars_DetectPlugins_Chkbx.Text = "Detect Plugins";
            this.AnalyzeVars_DetectPlugins_Chkbx.UseSelectable = true;
            // 
            // AnalyzeVars_LocalReferences_Chkbx
            // 
            this.AnalyzeVars_LocalReferences_Chkbx.AutoSize = true;
            this.AnalyzeVars_LocalReferences_Chkbx.Checked = true;
            this.AnalyzeVars_LocalReferences_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnalyzeVars_LocalReferences_Chkbx.Location = new System.Drawing.Point(93, 22);
            this.AnalyzeVars_LocalReferences_Chkbx.Name = "AnalyzeVars_LocalReferences_Chkbx";
            this.AnalyzeVars_LocalReferences_Chkbx.Size = new System.Drawing.Size(111, 15);
            this.AnalyzeVars_LocalReferences_Chkbx.TabIndex = 32;
            this.AnalyzeVars_LocalReferences_Chkbx.Text = "Local References";
            this.AnalyzeVars_LocalReferences_Chkbx.UseSelectable = true;
            // 
            // AnalyzeVars_BloatedVar_Chkbx
            // 
            this.AnalyzeVars_BloatedVar_Chkbx.AutoSize = true;
            this.AnalyzeVars_BloatedVar_Chkbx.Checked = true;
            this.AnalyzeVars_BloatedVar_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnalyzeVars_BloatedVar_Chkbx.Location = new System.Drawing.Point(390, 22);
            this.AnalyzeVars_BloatedVar_Chkbx.Name = "AnalyzeVars_BloatedVar_Chkbx";
            this.AnalyzeVars_BloatedVar_Chkbx.Size = new System.Drawing.Size(82, 15);
            this.AnalyzeVars_BloatedVar_Chkbx.TabIndex = 35;
            this.AnalyzeVars_BloatedVar_Chkbx.Text = "Bloated Var";
            this.AnalyzeVars_BloatedVar_Chkbx.UseSelectable = true;
            // 
            // AnalyzeVars_Morphs_Chkbx
            // 
            this.AnalyzeVars_Morphs_Chkbx.AutoSize = true;
            this.AnalyzeVars_Morphs_Chkbx.Checked = true;
            this.AnalyzeVars_Morphs_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnalyzeVars_Morphs_Chkbx.Location = new System.Drawing.Point(320, 22);
            this.AnalyzeVars_Morphs_Chkbx.Name = "AnalyzeVars_Morphs_Chkbx";
            this.AnalyzeVars_Morphs_Chkbx.Size = new System.Drawing.Size(64, 15);
            this.AnalyzeVars_Morphs_Chkbx.TabIndex = 34;
            this.AnalyzeVars_Morphs_Chkbx.Text = "Morphs";
            this.AnalyzeVars_Morphs_Chkbx.UseSelectable = true;
            // 
            // AnalyzeVars_DeserializeJson_Chkbx
            // 
            this.AnalyzeVars_DeserializeJson_Chkbx.AutoSize = true;
            this.AnalyzeVars_DeserializeJson_Chkbx.Checked = true;
            this.AnalyzeVars_DeserializeJson_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnalyzeVars_DeserializeJson_Chkbx.Location = new System.Drawing.Point(210, 22);
            this.AnalyzeVars_DeserializeJson_Chkbx.Name = "AnalyzeVars_DeserializeJson_Chkbx";
            this.AnalyzeVars_DeserializeJson_Chkbx.Size = new System.Drawing.Size(104, 15);
            this.AnalyzeVars_DeserializeJson_Chkbx.TabIndex = 33;
            this.AnalyzeVars_DeserializeJson_Chkbx.Text = "Deserialize Json";
            this.AnalyzeVars_DeserializeJson_Chkbx.UseSelectable = true;
            // 
            // AnalyzeVars_metaJson_Chkbx
            // 
            this.AnalyzeVars_metaJson_Chkbx.AutoSize = true;
            this.AnalyzeVars_metaJson_Chkbx.Checked = true;
            this.AnalyzeVars_metaJson_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnalyzeVars_metaJson_Chkbx.Location = new System.Drawing.Point(12, 22);
            this.AnalyzeVars_metaJson_Chkbx.Name = "AnalyzeVars_metaJson_Chkbx";
            this.AnalyzeVars_metaJson_Chkbx.Size = new System.Drawing.Size(75, 15);
            this.AnalyzeVars_metaJson_Chkbx.TabIndex = 31;
            this.AnalyzeVars_metaJson_Chkbx.Text = "meta.json";
            this.AnalyzeVars_metaJson_Chkbx.UseSelectable = true;
            // 
            // AnalyzeVars_Gbx3
            // 
            this.AnalyzeVars_Gbx3.BackColor = System.Drawing.Color.Transparent;
            this.AnalyzeVars_Gbx3.Controls.Add(this.AnalyzeVars_YingYang_PIC);
            this.AnalyzeVars_Gbx3.Controls.Add(this.AnalyzeVars_ExtractImagesExif_Chkbx);
            this.AnalyzeVars_Gbx3.Controls.Add(this.AnalyzeVars_NonVamImages_Chkbx);
            this.AnalyzeVars_Gbx3.Controls.Add(this.AnalyzeVars_ImagesMISC_Chkbx);
            this.AnalyzeVars_Gbx3.Controls.Add(this.AnalyzeVars_TamperedwithVar_Chkbx);
            this.AnalyzeVars_Gbx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnalyzeVars_Gbx3.Location = new System.Drawing.Point(9, 466);
            this.AnalyzeVars_Gbx3.Name = "AnalyzeVars_Gbx3";
            this.AnalyzeVars_Gbx3.Size = new System.Drawing.Size(900, 51);
            this.AnalyzeVars_Gbx3.TabIndex = 38;
            this.AnalyzeVars_Gbx3.TabStop = false;
            this.AnalyzeVars_Gbx3.Text = "Trackers:";
            // 
            // AnalyzeVars_YingYang_PIC
            // 
            this.AnalyzeVars_YingYang_PIC.Image = global::Sharp_VaM_Tools.Properties.Resources.YingYang;
            this.AnalyzeVars_YingYang_PIC.Location = new System.Drawing.Point(861, 11);
            this.AnalyzeVars_YingYang_PIC.Name = "AnalyzeVars_YingYang_PIC";
            this.AnalyzeVars_YingYang_PIC.Size = new System.Drawing.Size(33, 36);
            this.AnalyzeVars_YingYang_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AnalyzeVars_YingYang_PIC.TabIndex = 40;
            this.AnalyzeVars_YingYang_PIC.TabStop = false;
            this.AnalyzeVars_YingYang_PIC.Visible = false;
            // 
            // AnalyzeVars_ExtractImagesExif_Chkbx
            // 
            this.AnalyzeVars_ExtractImagesExif_Chkbx.AutoSize = true;
            this.AnalyzeVars_ExtractImagesExif_Chkbx.Location = new System.Drawing.Point(259, 21);
            this.AnalyzeVars_ExtractImagesExif_Chkbx.Name = "AnalyzeVars_ExtractImagesExif_Chkbx";
            this.AnalyzeVars_ExtractImagesExif_Chkbx.Size = new System.Drawing.Size(149, 15);
            this.AnalyzeVars_ExtractImagesExif_Chkbx.TabIndex = 36;
            this.AnalyzeVars_ExtractImagesExif_Chkbx.Text = "Extract Images Exif Data";
            this.AnalyzeVars_ExtractImagesExif_Chkbx.UseSelectable = true;
            // 
            // AnalyzeVars_NonVamImages_Chkbx
            // 
            this.AnalyzeVars_NonVamImages_Chkbx.AutoSize = true;
            this.AnalyzeVars_NonVamImages_Chkbx.Location = new System.Drawing.Point(138, 21);
            this.AnalyzeVars_NonVamImages_Chkbx.Name = "AnalyzeVars_NonVamImages_Chkbx";
            this.AnalyzeVars_NonVamImages_Chkbx.Size = new System.Drawing.Size(115, 15);
            this.AnalyzeVars_NonVamImages_Chkbx.TabIndex = 35;
            this.AnalyzeVars_NonVamImages_Chkbx.Text = "Non-Vam Images";
            this.AnalyzeVars_NonVamImages_Chkbx.UseSelectable = true;
            // 
            // AnalyzeVars_ImagesMISC_Chkbx
            // 
            this.AnalyzeVars_ImagesMISC_Chkbx.AutoSize = true;
            this.AnalyzeVars_ImagesMISC_Chkbx.Location = new System.Drawing.Point(414, 21);
            this.AnalyzeVars_ImagesMISC_Chkbx.Name = "AnalyzeVars_ImagesMISC_Chkbx";
            this.AnalyzeVars_ImagesMISC_Chkbx.Size = new System.Drawing.Size(92, 15);
            this.AnalyzeVars_ImagesMISC_Chkbx.TabIndex = 34;
            this.AnalyzeVars_ImagesMISC_Chkbx.Text = "Images MISC";
            this.AnalyzeVars_ImagesMISC_Chkbx.UseSelectable = true;
            // 
            // AnalyzeVars_TamperedwithVar_Chkbx
            // 
            this.AnalyzeVars_TamperedwithVar_Chkbx.AutoSize = true;
            this.AnalyzeVars_TamperedwithVar_Chkbx.Checked = true;
            this.AnalyzeVars_TamperedwithVar_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AnalyzeVars_TamperedwithVar_Chkbx.Location = new System.Drawing.Point(12, 21);
            this.AnalyzeVars_TamperedwithVar_Chkbx.Name = "AnalyzeVars_TamperedwithVar_Chkbx";
            this.AnalyzeVars_TamperedwithVar_Chkbx.Size = new System.Drawing.Size(120, 15);
            this.AnalyzeVars_TamperedwithVar_Chkbx.TabIndex = 30;
            this.AnalyzeVars_TamperedwithVar_Chkbx.Text = "Tampered with Var";
            this.AnalyzeVars_TamperedwithVar_Chkbx.UseSelectable = true;
            // 
            // AnalyzeVars_Browse_BTN
            // 
            this.AnalyzeVars_Browse_BTN.Location = new System.Drawing.Point(786, 0);
            this.AnalyzeVars_Browse_BTN.Name = "AnalyzeVars_Browse_BTN";
            this.AnalyzeVars_Browse_BTN.Size = new System.Drawing.Size(123, 21);
            this.AnalyzeVars_Browse_BTN.TabIndex = 4;
            this.AnalyzeVars_Browse_BTN.Text = "Browse";
            this.AnalyzeVars_Browse_BTN.UseSelectable = true;
            this.AnalyzeVars_Browse_BTN.Click += new System.EventHandler(this.AnalyzeVars_Browse_BTN_Click);
            // 
            // AnalyzeVars_Result_Txtbx
            // 
            this.AnalyzeVars_Result_Txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.AnalyzeVars_Result_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AnalyzeVars_Result_Txtbx.ContextMenuStrip = this.AnalyzeVars_CM_Result_Txtbx;
            this.AnalyzeVars_Result_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.AnalyzeVars_Result_Txtbx.ForeColor = System.Drawing.Color.White;
            this.AnalyzeVars_Result_Txtbx.Location = new System.Drawing.Point(9, 27);
            this.AnalyzeVars_Result_Txtbx.Name = "AnalyzeVars_Result_Txtbx";
            this.AnalyzeVars_Result_Txtbx.Size = new System.Drawing.Size(900, 369);
            this.AnalyzeVars_Result_Txtbx.TabIndex = 25;
            this.AnalyzeVars_Result_Txtbx.Text = "";
            this.AnalyzeVars_Result_Txtbx.WordWrap = false;
            // 
            // AnalyzeVars_CM_Result_Txtbx
            // 
            this.AnalyzeVars_CM_Result_Txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AnalyzeVars_CM_Result_Txtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AnalyzeVars_CM_Result_Txtbx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AnalyzeVars_CM_Result_Txtbx_ShowWarnings,
            this.AnalyzeVars_CM_Result_Txtbx_CopyWarnings,
            this.AnalyzeVars_CM_Result_Txtbx_GoBack,
            this.AnalyzeVars_CM_Result_Txtbx_CopySelected,
            this.AnalyzeVars_CM_Result_Txtbx_CopyAllText,
            this.AnalyzeVars_CM_Result_Txtbx_Clear});
            this.AnalyzeVars_CM_Result_Txtbx.Name = "AnalyzeVars_CM_Result_Txtbx";
            this.AnalyzeVars_CM_Result_Txtbx.Size = new System.Drawing.Size(227, 160);
            // 
            // AnalyzeVars_CM_Result_Txtbx_ShowWarnings
            // 
            this.AnalyzeVars_CM_Result_Txtbx_ShowWarnings.Name = "AnalyzeVars_CM_Result_Txtbx_ShowWarnings";
            this.AnalyzeVars_CM_Result_Txtbx_ShowWarnings.Size = new System.Drawing.Size(226, 26);
            this.AnalyzeVars_CM_Result_Txtbx_ShowWarnings.Text = "Show Warnings Only";
            this.AnalyzeVars_CM_Result_Txtbx_ShowWarnings.Click += new System.EventHandler(this.AnalyzeVars_CM_Result_Txtbx_ShowWarnings_Click);
            // 
            // AnalyzeVars_CM_Result_Txtbx_CopyWarnings
            // 
            this.AnalyzeVars_CM_Result_Txtbx_CopyWarnings.Name = "AnalyzeVars_CM_Result_Txtbx_CopyWarnings";
            this.AnalyzeVars_CM_Result_Txtbx_CopyWarnings.Size = new System.Drawing.Size(226, 26);
            this.AnalyzeVars_CM_Result_Txtbx_CopyWarnings.Text = "Copy Warnings";
            this.AnalyzeVars_CM_Result_Txtbx_CopyWarnings.Click += new System.EventHandler(this.AnalyzeVars_CM_Result_Txtbx_CopyWarnings_Click);
            // 
            // AnalyzeVars_CM_Result_Txtbx_GoBack
            // 
            this.AnalyzeVars_CM_Result_Txtbx_GoBack.Name = "AnalyzeVars_CM_Result_Txtbx_GoBack";
            this.AnalyzeVars_CM_Result_Txtbx_GoBack.Size = new System.Drawing.Size(226, 26);
            this.AnalyzeVars_CM_Result_Txtbx_GoBack.Text = "Go Back";
            this.AnalyzeVars_CM_Result_Txtbx_GoBack.Click += new System.EventHandler(this.AnalyzeVars_CM_Result_Txtbx_GoBack_Click);
            // 
            // AnalyzeVars_CM_Result_Txtbx_CopySelected
            // 
            this.AnalyzeVars_CM_Result_Txtbx_CopySelected.Name = "AnalyzeVars_CM_Result_Txtbx_CopySelected";
            this.AnalyzeVars_CM_Result_Txtbx_CopySelected.Size = new System.Drawing.Size(226, 26);
            this.AnalyzeVars_CM_Result_Txtbx_CopySelected.Text = "Copy Selected";
            this.AnalyzeVars_CM_Result_Txtbx_CopySelected.Click += new System.EventHandler(this.AnalyzeVars_CM_Result_Txtbx_CopySelected_Click);
            // 
            // AnalyzeVars_CM_Result_Txtbx_CopyAllText
            // 
            this.AnalyzeVars_CM_Result_Txtbx_CopyAllText.Name = "AnalyzeVars_CM_Result_Txtbx_CopyAllText";
            this.AnalyzeVars_CM_Result_Txtbx_CopyAllText.Size = new System.Drawing.Size(226, 26);
            this.AnalyzeVars_CM_Result_Txtbx_CopyAllText.Text = "Copy All Text";
            this.AnalyzeVars_CM_Result_Txtbx_CopyAllText.Click += new System.EventHandler(this.AnalyzeVars_CM_Result_Txtbx_CopyAllText_Click);
            // 
            // AnalyzeVars_CM_Result_Txtbx_Clear
            // 
            this.AnalyzeVars_CM_Result_Txtbx_Clear.Name = "AnalyzeVars_CM_Result_Txtbx_Clear";
            this.AnalyzeVars_CM_Result_Txtbx_Clear.Size = new System.Drawing.Size(226, 26);
            this.AnalyzeVars_CM_Result_Txtbx_Clear.Text = "Clear";
            this.AnalyzeVars_CM_Result_Txtbx_Clear.Click += new System.EventHandler(this.AnalyzeVars_CM_Result_Txtbx_Clear_Click);
            // 
            // Tab_Security_MalwareScan
            // 
            this.Tab_Security_MalwareScan.AllowDrop = true;
            this.Tab_Security_MalwareScan.Controls.Add(this.Security_ScanResultMalware_Txtbx);
            this.Tab_Security_MalwareScan.Controls.Add(this.Security_ScanResultSuspecious_Txtbx);
            this.Tab_Security_MalwareScan.Controls.Add(this.Security_VarsToScan_Txtbx);
            this.Tab_Security_MalwareScan.Controls.Add(this.Security_Gbx1);
            this.Tab_Security_MalwareScan.Controls.Add(this.Security_Gbx2);
            this.Tab_Security_MalwareScan.Controls.Add(this.Security_Gbx3);
            this.Tab_Security_MalwareScan.HorizontalScrollbarBarColor = true;
            this.Tab_Security_MalwareScan.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab_Security_MalwareScan.HorizontalScrollbarSize = 10;
            this.Tab_Security_MalwareScan.Location = new System.Drawing.Point(4, 38);
            this.Tab_Security_MalwareScan.Name = "Tab_Security_MalwareScan";
            this.Tab_Security_MalwareScan.Size = new System.Drawing.Size(924, 729);
            this.Tab_Security_MalwareScan.TabIndex = 5;
            this.Tab_Security_MalwareScan.Text = "Security (Malware Scan)";
            this.Tab_Security_MalwareScan.VerticalScrollbarBarColor = true;
            this.Tab_Security_MalwareScan.VerticalScrollbarHighlightOnWheel = false;
            this.Tab_Security_MalwareScan.VerticalScrollbarSize = 10;
            // 
            // Security_ScanResultMalware_Txtbx
            // 
            this.Security_ScanResultMalware_Txtbx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Security_ScanResultMalware_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Security_ScanResultMalware_Txtbx.ContextMenuStrip = this.Security_CM_ScanResultMalware_Txtbx;
            this.Security_ScanResultMalware_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.Security_ScanResultMalware_Txtbx.ForeColor = System.Drawing.Color.Red;
            this.Security_ScanResultMalware_Txtbx.Location = new System.Drawing.Point(9, 501);
            this.Security_ScanResultMalware_Txtbx.Name = "Security_ScanResultMalware_Txtbx";
            this.Security_ScanResultMalware_Txtbx.Size = new System.Drawing.Size(900, 219);
            this.Security_ScanResultMalware_Txtbx.TabIndex = 7;
            this.Security_ScanResultMalware_Txtbx.Text = "";
            this.Security_ScanResultMalware_Txtbx.WordWrap = false;
            // 
            // Security_CM_ScanResultMalware_Txtbx
            // 
            this.Security_CM_ScanResultMalware_Txtbx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Security_CM_ScanResultMalware_Txtbx_CopySelected,
            this.Security_CM_ScanResultMalware_Txtbx_CopyAll,
            this.Security_CM_ScanResultMalware_Txtbx_ClearAll});
            this.Security_CM_ScanResultMalware_Txtbx.Name = "contextMenu_Security_ScanResult_Malware_TxtBx";
            this.Security_CM_ScanResultMalware_Txtbx.Size = new System.Drawing.Size(179, 82);
            // 
            // Security_CM_ScanResultMalware_Txtbx_CopySelected
            // 
            this.Security_CM_ScanResultMalware_Txtbx_CopySelected.Name = "Security_CM_ScanResultMalware_Txtbx_CopySelected";
            this.Security_CM_ScanResultMalware_Txtbx_CopySelected.Size = new System.Drawing.Size(178, 26);
            this.Security_CM_ScanResultMalware_Txtbx_CopySelected.Text = "Copy Selected";
            this.Security_CM_ScanResultMalware_Txtbx_CopySelected.Click += new System.EventHandler(this.Security_CM_ScanResultMalware_Txtbx_CopySelected_Click);
            // 
            // Security_CM_ScanResultMalware_Txtbx_CopyAll
            // 
            this.Security_CM_ScanResultMalware_Txtbx_CopyAll.Name = "Security_CM_ScanResultMalware_Txtbx_CopyAll";
            this.Security_CM_ScanResultMalware_Txtbx_CopyAll.Size = new System.Drawing.Size(178, 26);
            this.Security_CM_ScanResultMalware_Txtbx_CopyAll.Text = "Copy All";
            this.Security_CM_ScanResultMalware_Txtbx_CopyAll.Click += new System.EventHandler(this.Security_CM_ScanResultMalware_Txtbx_CopyAll_Click);
            // 
            // Security_CM_ScanResultMalware_Txtbx_ClearAll
            // 
            this.Security_CM_ScanResultMalware_Txtbx_ClearAll.Name = "Security_CM_ScanResultMalware_Txtbx_ClearAll";
            this.Security_CM_ScanResultMalware_Txtbx_ClearAll.Size = new System.Drawing.Size(178, 26);
            this.Security_CM_ScanResultMalware_Txtbx_ClearAll.Text = "Clear All";
            this.Security_CM_ScanResultMalware_Txtbx_ClearAll.Click += new System.EventHandler(this.Security_CM_ScanResultMalware_Txtbx_ClearAll_Click);
            // 
            // Security_ScanResultSuspecious_Txtbx
            // 
            this.Security_ScanResultSuspecious_Txtbx.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Security_ScanResultSuspecious_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Security_ScanResultSuspecious_Txtbx.ContextMenuStrip = this.Security_CM_ScanResultSuspecious_Txtbx;
            this.Security_ScanResultSuspecious_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.Security_ScanResultSuspecious_Txtbx.Location = new System.Drawing.Point(9, 206);
            this.Security_ScanResultSuspecious_Txtbx.Name = "Security_ScanResultSuspecious_Txtbx";
            this.Security_ScanResultSuspecious_Txtbx.Size = new System.Drawing.Size(900, 261);
            this.Security_ScanResultSuspecious_Txtbx.TabIndex = 6;
            this.Security_ScanResultSuspecious_Txtbx.Text = "";
            this.Security_ScanResultSuspecious_Txtbx.WordWrap = false;
            // 
            // Security_CM_ScanResultSuspecious_Txtbx
            // 
            this.Security_CM_ScanResultSuspecious_Txtbx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Security_CM_ScanResultSuspecious_Txtbx_CopySelected,
            this.Security_CM_ScanResultSuspecious_Txtbx_CopyAll,
            this.Security_CM_ScanResultSuspecious_Txtbx_ClearAll});
            this.Security_CM_ScanResultSuspecious_Txtbx.Name = "contextMenu_Security_ScanResult_Suspecious_TxtBx";
            this.Security_CM_ScanResultSuspecious_Txtbx.Size = new System.Drawing.Size(179, 82);
            // 
            // Security_CM_ScanResultSuspecious_Txtbx_CopySelected
            // 
            this.Security_CM_ScanResultSuspecious_Txtbx_CopySelected.Name = "Security_CM_ScanResultSuspecious_Txtbx_CopySelected";
            this.Security_CM_ScanResultSuspecious_Txtbx_CopySelected.Size = new System.Drawing.Size(178, 26);
            this.Security_CM_ScanResultSuspecious_Txtbx_CopySelected.Text = "Copy Selected";
            this.Security_CM_ScanResultSuspecious_Txtbx_CopySelected.Click += new System.EventHandler(this.Security_CM_ScanResultSuspecious_Txtbx_CopySelected_Click);
            // 
            // Security_CM_ScanResultSuspecious_Txtbx_CopyAll
            // 
            this.Security_CM_ScanResultSuspecious_Txtbx_CopyAll.Name = "Security_CM_ScanResultSuspecious_Txtbx_CopyAll";
            this.Security_CM_ScanResultSuspecious_Txtbx_CopyAll.Size = new System.Drawing.Size(178, 26);
            this.Security_CM_ScanResultSuspecious_Txtbx_CopyAll.Text = "Copy All";
            this.Security_CM_ScanResultSuspecious_Txtbx_CopyAll.Click += new System.EventHandler(this.Security_CM_ScanResultSuspecious_Txtbx_CopyAll_Click);
            // 
            // Security_CM_ScanResultSuspecious_Txtbx_ClearAll
            // 
            this.Security_CM_ScanResultSuspecious_Txtbx_ClearAll.Name = "Security_CM_ScanResultSuspecious_Txtbx_ClearAll";
            this.Security_CM_ScanResultSuspecious_Txtbx_ClearAll.Size = new System.Drawing.Size(178, 26);
            this.Security_CM_ScanResultSuspecious_Txtbx_ClearAll.Text = "Clear All";
            this.Security_CM_ScanResultSuspecious_Txtbx_ClearAll.Click += new System.EventHandler(this.Security_CM_ScanResultSuspecious_Txtbx_ClearAll_Click);
            // 
            // Security_VarsToScan_Txtbx
            // 
            this.Security_VarsToScan_Txtbx.BackColor = System.Drawing.Color.Silver;
            this.Security_VarsToScan_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Security_VarsToScan_Txtbx.ContextMenuStrip = this.Security_CM_VarsToScan_Txtbx;
            this.Security_VarsToScan_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.Security_VarsToScan_Txtbx.Location = new System.Drawing.Point(9, 41);
            this.Security_VarsToScan_Txtbx.Name = "Security_VarsToScan_Txtbx";
            this.Security_VarsToScan_Txtbx.Size = new System.Drawing.Size(900, 96);
            this.Security_VarsToScan_Txtbx.TabIndex = 2;
            this.Security_VarsToScan_Txtbx.Text = "";
            // 
            // Security_CM_VarsToScan_Txtbx
            // 
            this.Security_CM_VarsToScan_Txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Security_CM_VarsToScan_Txtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Security_CM_VarsToScan_Txtbx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Security_CM_VarsToScan_Txtbx_Clear});
            this.Security_CM_VarsToScan_Txtbx.Name = "Security_CM_VarsToScan_Txtbx";
            this.Security_CM_VarsToScan_Txtbx.Size = new System.Drawing.Size(117, 30);
            // 
            // Security_CM_VarsToScan_Txtbx_Clear
            // 
            this.Security_CM_VarsToScan_Txtbx_Clear.Name = "Security_CM_VarsToScan_Txtbx_Clear";
            this.Security_CM_VarsToScan_Txtbx_Clear.Size = new System.Drawing.Size(116, 26);
            this.Security_CM_VarsToScan_Txtbx_Clear.Text = "Clear";
            this.Security_CM_VarsToScan_Txtbx_Clear.Click += new System.EventHandler(this.Security_CM_VarsToScan_Txtbx_Clear_Click);
            // 
            // Security_Gbx1
            // 
            this.Security_Gbx1.BackColor = System.Drawing.Color.Transparent;
            this.Security_Gbx1.Controls.Add(this.Security_EscapeClean_Chkbx);
            this.Security_Gbx1.Controls.Add(this.Security_Scan_BTN);
            this.Security_Gbx1.Controls.Add(this.Security_YinYang_Scan);
            this.Security_Gbx1.Controls.Add(this.Security_escape_Assetbundles_Chkbx);
            this.Security_Gbx1.Controls.Add(this.Security_escape_EventTrigger_Chkbx);
            this.Security_Gbx1.Controls.Add(this.Security_Browse_BTN);
            this.Security_Gbx1.Controls.Add(this.Security_escape_ApplicationOpenURL_Chkbx);
            this.Security_Gbx1.Controls.Add(this.Security_escape_FileMangementSecure_Chkbx);
            this.Security_Gbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Security_Gbx1.Location = new System.Drawing.Point(3, 14);
            this.Security_Gbx1.Name = "Security_Gbx1";
            this.Security_Gbx1.Size = new System.Drawing.Size(918, 168);
            this.Security_Gbx1.TabIndex = 13;
            this.Security_Gbx1.TabStop = false;
            this.Security_Gbx1.Text = "Add vars you want to scan (you can drag and drop multiple vars|folders|zip|vac)";
            // 
            // Security_EscapeClean_Chkbx
            // 
            this.Security_EscapeClean_Chkbx.AutoSize = true;
            this.Security_EscapeClean_Chkbx.Checked = true;
            this.Security_EscapeClean_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Security_EscapeClean_Chkbx.Location = new System.Drawing.Point(6, 148);
            this.Security_EscapeClean_Chkbx.Name = "Security_EscapeClean_Chkbx";
            this.Security_EscapeClean_Chkbx.Size = new System.Drawing.Size(116, 15);
            this.Security_EscapeClean_Chkbx.TabIndex = 13;
            this.Security_EscapeClean_Chkbx.Text = "Escape Clean Vars";
            this.Security_EscapeClean_Chkbx.UseSelectable = true;
            // 
            // Security_Scan_BTN
            // 
            this.Security_Scan_BTN.Location = new System.Drawing.Point(782, 131);
            this.Security_Scan_BTN.Name = "Security_Scan_BTN";
            this.Security_Scan_BTN.Size = new System.Drawing.Size(124, 21);
            this.Security_Scan_BTN.TabIndex = 5;
            this.Security_Scan_BTN.Text = "Scan";
            this.Security_Scan_BTN.UseSelectable = true;
            this.Security_Scan_BTN.Click += new System.EventHandler(this.Security_Scan_BTN_Click);
            // 
            // Security_YinYang_Scan
            // 
            this.Security_YinYang_Scan.Image = global::Sharp_VaM_Tools.Properties.Resources.YingYang;
            this.Security_YinYang_Scan.Location = new System.Drawing.Point(756, 131);
            this.Security_YinYang_Scan.Name = "Security_YinYang_Scan";
            this.Security_YinYang_Scan.Size = new System.Drawing.Size(20, 21);
            this.Security_YinYang_Scan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Security_YinYang_Scan.TabIndex = 10;
            this.Security_YinYang_Scan.TabStop = false;
            this.Security_YinYang_Scan.Visible = false;
            // 
            // Security_escape_Assetbundles_Chkbx
            // 
            this.Security_escape_Assetbundles_Chkbx.AutoSize = true;
            this.Security_escape_Assetbundles_Chkbx.Checked = true;
            this.Security_escape_Assetbundles_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Security_escape_Assetbundles_Chkbx.Location = new System.Drawing.Point(574, 129);
            this.Security_escape_Assetbundles_Chkbx.Name = "Security_escape_Assetbundles_Chkbx";
            this.Security_escape_Assetbundles_Chkbx.Size = new System.Drawing.Size(130, 15);
            this.Security_escape_Assetbundles_Chkbx.TabIndex = 12;
            this.Security_escape_Assetbundles_Chkbx.Text = "Escape assetbundles";
            this.Security_escape_Assetbundles_Chkbx.UseSelectable = true;
            // 
            // Security_escape_EventTrigger_Chkbx
            // 
            this.Security_escape_EventTrigger_Chkbx.AutoSize = true;
            this.Security_escape_EventTrigger_Chkbx.Checked = true;
            this.Security_escape_EventTrigger_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Security_escape_EventTrigger_Chkbx.Location = new System.Drawing.Point(255, 129);
            this.Security_escape_EventTrigger_Chkbx.Name = "Security_escape_EventTrigger_Chkbx";
            this.Security_escape_EventTrigger_Chkbx.Size = new System.Drawing.Size(127, 15);
            this.Security_escape_EventTrigger_Chkbx.TabIndex = 11;
            this.Security_escape_EventTrigger_Chkbx.Text = "Escape EventTrigger";
            this.Security_escape_EventTrigger_Chkbx.UseSelectable = true;
            // 
            // Security_Browse_BTN
            // 
            this.Security_Browse_BTN.Location = new System.Drawing.Point(782, 0);
            this.Security_Browse_BTN.Name = "Security_Browse_BTN";
            this.Security_Browse_BTN.Size = new System.Drawing.Size(124, 21);
            this.Security_Browse_BTN.TabIndex = 4;
            this.Security_Browse_BTN.Text = "Browse";
            this.Security_Browse_BTN.UseSelectable = true;
            this.Security_Browse_BTN.Click += new System.EventHandler(this.Security_Browse_BTN_Click);
            // 
            // Security_escape_ApplicationOpenURL_Chkbx
            // 
            this.Security_escape_ApplicationOpenURL_Chkbx.AutoSize = true;
            this.Security_escape_ApplicationOpenURL_Chkbx.Checked = true;
            this.Security_escape_ApplicationOpenURL_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Security_escape_ApplicationOpenURL_Chkbx.Location = new System.Drawing.Point(6, 128);
            this.Security_escape_ApplicationOpenURL_Chkbx.Name = "Security_escape_ApplicationOpenURL_Chkbx";
            this.Security_escape_ApplicationOpenURL_Chkbx.Size = new System.Drawing.Size(248, 15);
            this.Security_escape_ApplicationOpenURL_Chkbx.TabIndex = 8;
            this.Security_escape_ApplicationOpenURL_Chkbx.Text = "Escape Application.OpenURL(\"http/https\")";
            this.Security_escape_ApplicationOpenURL_Chkbx.UseSelectable = true;
            // 
            // Security_escape_FileMangementSecure_Chkbx
            // 
            this.Security_escape_FileMangementSecure_Chkbx.AutoSize = true;
            this.Security_escape_FileMangementSecure_Chkbx.Checked = true;
            this.Security_escape_FileMangementSecure_Chkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Security_escape_FileMangementSecure_Chkbx.Location = new System.Drawing.Point(388, 129);
            this.Security_escape_FileMangementSecure_Chkbx.Name = "Security_escape_FileMangementSecure_Chkbx";
            this.Security_escape_FileMangementSecure_Chkbx.Size = new System.Drawing.Size(180, 15);
            this.Security_escape_FileMangementSecure_Chkbx.TabIndex = 9;
            this.Security_escape_FileMangementSecure_Chkbx.Text = "Escape FileMangementSecure";
            this.Security_escape_FileMangementSecure_Chkbx.UseSelectable = true;
            // 
            // Security_Gbx2
            // 
            this.Security_Gbx2.BackColor = System.Drawing.Color.Transparent;
            this.Security_Gbx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Security_Gbx2.Location = new System.Drawing.Point(3, 186);
            this.Security_Gbx2.Name = "Security_Gbx2";
            this.Security_Gbx2.Size = new System.Drawing.Size(918, 289);
            this.Security_Gbx2.TabIndex = 14;
            this.Security_Gbx2.TabStop = false;
            this.Security_Gbx2.Text = "Result (Suspicious)";
            // 
            // Security_Gbx3
            // 
            this.Security_Gbx3.BackColor = System.Drawing.Color.Transparent;
            this.Security_Gbx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Security_Gbx3.Location = new System.Drawing.Point(3, 481);
            this.Security_Gbx3.Name = "Security_Gbx3";
            this.Security_Gbx3.Size = new System.Drawing.Size(918, 245);
            this.Security_Gbx3.TabIndex = 15;
            this.Security_Gbx3.TabStop = false;
            this.Security_Gbx3.Text = "Result (Suspicious Malware)";
            // 
            // Tab_MISC
            // 
            this.Tab_MISC.Controls.Add(this.MISC_Browse_BTN);
            this.Tab_MISC.Controls.Add(this.MISC_Output_Txtbx);
            this.Tab_MISC.Controls.Add(this.MISC_Paths_Txtbx);
            this.Tab_MISC.Controls.Add(this.MISC_Gbx1);
            this.Tab_MISC.Controls.Add(this.MISC_Gbx2);
            this.Tab_MISC.Controls.Add(this.MISC_Gbx3);
            this.Tab_MISC.HorizontalScrollbarBarColor = true;
            this.Tab_MISC.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab_MISC.HorizontalScrollbarSize = 10;
            this.Tab_MISC.Location = new System.Drawing.Point(4, 35);
            this.Tab_MISC.Name = "Tab_MISC";
            this.Tab_MISC.Size = new System.Drawing.Size(924, 732);
            this.Tab_MISC.TabIndex = 6;
            this.Tab_MISC.Text = "MISC";
            this.Tab_MISC.VerticalScrollbarBarColor = true;
            this.Tab_MISC.VerticalScrollbarHighlightOnWheel = false;
            this.Tab_MISC.VerticalScrollbarSize = 10;
            // 
            // MISC_Browse_BTN
            // 
            this.MISC_Browse_BTN.Location = new System.Drawing.Point(796, 7);
            this.MISC_Browse_BTN.Name = "MISC_Browse_BTN";
            this.MISC_Browse_BTN.Size = new System.Drawing.Size(117, 24);
            this.MISC_Browse_BTN.TabIndex = 14;
            this.MISC_Browse_BTN.Text = "Browse Folder(s)";
            this.MISC_Browse_BTN.UseSelectable = true;
            this.MISC_Browse_BTN.Click += new System.EventHandler(this.MISC_Browse_BTN_Click);
            // 
            // MISC_Output_Txtbx
            // 
            this.MISC_Output_Txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.MISC_Output_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MISC_Output_Txtbx.ContextMenuStrip = this.MISC_CM_Output_Txtbx;
            this.MISC_Output_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.MISC_Output_Txtbx.ForeColor = System.Drawing.Color.White;
            this.MISC_Output_Txtbx.Location = new System.Drawing.Point(7, 276);
            this.MISC_Output_Txtbx.Name = "MISC_Output_Txtbx";
            this.MISC_Output_Txtbx.Size = new System.Drawing.Size(906, 300);
            this.MISC_Output_Txtbx.TabIndex = 7;
            this.MISC_Output_Txtbx.Text = "";
            this.MISC_Output_Txtbx.WordWrap = false;
            // 
            // MISC_CM_Output_Txtbx
            // 
            this.MISC_CM_Output_Txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MISC_CM_Output_Txtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MISC_CM_Output_Txtbx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MISC_CM_Output_Txtbx_Clear});
            this.MISC_CM_Output_Txtbx.Name = "ContextMenu1_Security_VarsToScan_TxtBx";
            this.MISC_CM_Output_Txtbx.Size = new System.Drawing.Size(139, 30);
            // 
            // MISC_CM_Output_Txtbx_Clear
            // 
            this.MISC_CM_Output_Txtbx_Clear.Name = "MISC_CM_Output_Txtbx_Clear";
            this.MISC_CM_Output_Txtbx_Clear.Size = new System.Drawing.Size(138, 26);
            this.MISC_CM_Output_Txtbx_Clear.Text = "Clear All";
            this.MISC_CM_Output_Txtbx_Clear.Click += new System.EventHandler(this.MISC_CM_Output_Txtbx_Clear_Click);
            // 
            // MISC_Paths_Txtbx
            // 
            this.MISC_Paths_Txtbx.BackColor = System.Drawing.Color.Silver;
            this.MISC_Paths_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MISC_Paths_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.6F);
            this.MISC_Paths_Txtbx.Location = new System.Drawing.Point(7, 36);
            this.MISC_Paths_Txtbx.Name = "MISC_Paths_Txtbx";
            this.MISC_Paths_Txtbx.Size = new System.Drawing.Size(906, 66);
            this.MISC_Paths_Txtbx.TabIndex = 4;
            this.MISC_Paths_Txtbx.Text = "";
            // 
            // MISC_Gbx1
            // 
            this.MISC_Gbx1.BackColor = System.Drawing.Color.Transparent;
            this.MISC_Gbx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MISC_Gbx1.Location = new System.Drawing.Point(1, 12);
            this.MISC_Gbx1.Name = "MISC_Gbx1";
            this.MISC_Gbx1.Size = new System.Drawing.Size(920, 100);
            this.MISC_Gbx1.TabIndex = 16;
            this.MISC_Gbx1.TabStop = false;
            this.MISC_Gbx1.Text = "Var Locations (Repos/Addonpackages/Creator\'s Folder)";
            // 
            // MISC_Gbx2
            // 
            this.MISC_Gbx2.BackColor = System.Drawing.Color.Transparent;
            this.MISC_Gbx2.Controls.Add(this.MISC_MoveUnusedVars_BTN);
            this.MISC_Gbx2.Controls.Add(this.MISC_ExtractImagesScene2_BTN);
            this.MISC_Gbx2.Controls.Add(this.MISC_YingYang0_PIC);
            this.MISC_Gbx2.Controls.Add(this.MISC_YingYang1_PIC);
            this.MISC_Gbx2.Controls.Add(this.MISC_ExtractChineseArchives_BTN);
            this.MISC_Gbx2.Controls.Add(this.MISC_DeleteCorruptedVars_BTN);
            this.MISC_Gbx2.Controls.Add(this.MISC_Stop_BTN);
            this.MISC_Gbx2.Controls.Add(this.MISC_ExtractImagesMontage_BTN);
            this.MISC_Gbx2.Controls.Add(this.MISC_DeleteDuplicateVars_BTN);
            this.MISC_Gbx2.Controls.Add(this.MISC_MoveVars_BTN);
            this.MISC_Gbx2.Controls.Add(this.MISC_ExtractImagesScene1_BTN);
            this.MISC_Gbx2.Location = new System.Drawing.Point(1, 118);
            this.MISC_Gbx2.Name = "MISC_Gbx2";
            this.MISC_Gbx2.Size = new System.Drawing.Size(920, 131);
            this.MISC_Gbx2.TabIndex = 17;
            this.MISC_Gbx2.TabStop = false;
            this.MISC_Gbx2.Text = "Select Operation";
            // 
            // MISC_MoveUnusedVars_BTN
            // 
            this.MISC_MoveUnusedVars_BTN.Location = new System.Drawing.Point(451, 15);
            this.MISC_MoveUnusedVars_BTN.Name = "MISC_MoveUnusedVars_BTN";
            this.MISC_MoveUnusedVars_BTN.Size = new System.Drawing.Size(164, 23);
            this.MISC_MoveUnusedVars_BTN.TabIndex = 22;
            this.MISC_MoveUnusedVars_BTN.Text = "Move Unused Vars";
            this.MISC_MoveUnusedVars_BTN.UseSelectable = true;
            this.MISC_MoveUnusedVars_BTN.Click += new System.EventHandler(this.MISC_DeleteOldVersions_BTN_Click);
            // 
            // MISC_ExtractImagesScene2_BTN
            // 
            this.MISC_ExtractImagesScene2_BTN.Location = new System.Drawing.Point(282, 43);
            this.MISC_ExtractImagesScene2_BTN.Name = "MISC_ExtractImagesScene2_BTN";
            this.MISC_ExtractImagesScene2_BTN.Size = new System.Drawing.Size(163, 23);
            this.MISC_ExtractImagesScene2_BTN.TabIndex = 21;
            this.MISC_ExtractImagesScene2_BTN.Text = "Extract Images (Scenes #2)";
            this.MISC_ExtractImagesScene2_BTN.UseSelectable = true;
            this.MISC_ExtractImagesScene2_BTN.Click += new System.EventHandler(this.MISC_ExtractImagesScene2_BTN_Click);
            // 
            // MISC_YingYang0_PIC
            // 
            this.MISC_YingYang0_PIC.Image = global::Sharp_VaM_Tools.Properties.Resources.YingYang;
            this.MISC_YingYang0_PIC.Location = new System.Drawing.Point(6, 15);
            this.MISC_YingYang0_PIC.Name = "MISC_YingYang0_PIC";
            this.MISC_YingYang0_PIC.Size = new System.Drawing.Size(51, 51);
            this.MISC_YingYang0_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MISC_YingYang0_PIC.TabIndex = 20;
            this.MISC_YingYang0_PIC.TabStop = false;
            this.MISC_YingYang0_PIC.Visible = false;
            // 
            // MISC_YingYang1_PIC
            // 
            this.MISC_YingYang1_PIC.Image = global::Sharp_VaM_Tools.Properties.Resources.YingYang;
            this.MISC_YingYang1_PIC.Location = new System.Drawing.Point(863, 14);
            this.MISC_YingYang1_PIC.Name = "MISC_YingYang1_PIC";
            this.MISC_YingYang1_PIC.Size = new System.Drawing.Size(51, 51);
            this.MISC_YingYang1_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MISC_YingYang1_PIC.TabIndex = 19;
            this.MISC_YingYang1_PIC.TabStop = false;
            this.MISC_YingYang1_PIC.Visible = false;
            // 
            // MISC_ExtractChineseArchives_BTN
            // 
            this.MISC_ExtractChineseArchives_BTN.Location = new System.Drawing.Point(621, 42);
            this.MISC_ExtractChineseArchives_BTN.Name = "MISC_ExtractChineseArchives_BTN";
            this.MISC_ExtractChineseArchives_BTN.Size = new System.Drawing.Size(163, 23);
            this.MISC_ExtractChineseArchives_BTN.TabIndex = 13;
            this.MISC_ExtractChineseArchives_BTN.Text = "Extract Chinese Archives";
            this.MISC_ExtractChineseArchives_BTN.UseSelectable = true;
            this.MISC_ExtractChineseArchives_BTN.Click += new System.EventHandler(this.MISC_ExtractChineseArchives_BTN_Click);
            // 
            // MISC_DeleteCorruptedVars_BTN
            // 
            this.MISC_DeleteCorruptedVars_BTN.Location = new System.Drawing.Point(282, 14);
            this.MISC_DeleteCorruptedVars_BTN.Name = "MISC_DeleteCorruptedVars_BTN";
            this.MISC_DeleteCorruptedVars_BTN.Size = new System.Drawing.Size(163, 23);
            this.MISC_DeleteCorruptedVars_BTN.TabIndex = 12;
            this.MISC_DeleteCorruptedVars_BTN.Text = "Delete Corrupted/Empty Vars";
            this.MISC_DeleteCorruptedVars_BTN.UseSelectable = true;
            this.MISC_DeleteCorruptedVars_BTN.Click += new System.EventHandler(this.MISC_DeleteCorruptedVars_BTN_Click);
            // 
            // MISC_Stop_BTN
            // 
            this.MISC_Stop_BTN.ForeColor = System.Drawing.Color.Black;
            this.MISC_Stop_BTN.Location = new System.Drawing.Point(380, 101);
            this.MISC_Stop_BTN.Name = "MISC_Stop_BTN";
            this.MISC_Stop_BTN.Size = new System.Drawing.Size(163, 23);
            this.MISC_Stop_BTN.TabIndex = 10;
            this.MISC_Stop_BTN.Text = "Stop All Operations";
            this.MISC_Stop_BTN.UseSelectable = true;
            this.MISC_Stop_BTN.Visible = false;
            this.MISC_Stop_BTN.Click += new System.EventHandler(this.MISC_Stop_BTN_Click);
            // 
            // MISC_ExtractImagesMontage_BTN
            // 
            this.MISC_ExtractImagesMontage_BTN.Location = new System.Drawing.Point(451, 43);
            this.MISC_ExtractImagesMontage_BTN.Name = "MISC_ExtractImagesMontage_BTN";
            this.MISC_ExtractImagesMontage_BTN.Size = new System.Drawing.Size(164, 23);
            this.MISC_ExtractImagesMontage_BTN.TabIndex = 11;
            this.MISC_ExtractImagesMontage_BTN.Text = "Extract Images (All/Montage)";
            this.MISC_ExtractImagesMontage_BTN.UseSelectable = true;
            this.MISC_ExtractImagesMontage_BTN.Click += new System.EventHandler(this.MISC_ExtractImagesMontage_BTN_Click);
            // 
            // MISC_DeleteDuplicateVars_BTN
            // 
            this.MISC_DeleteDuplicateVars_BTN.Location = new System.Drawing.Point(135, 14);
            this.MISC_DeleteDuplicateVars_BTN.Name = "MISC_DeleteDuplicateVars_BTN";
            this.MISC_DeleteDuplicateVars_BTN.Size = new System.Drawing.Size(140, 23);
            this.MISC_DeleteDuplicateVars_BTN.TabIndex = 6;
            this.MISC_DeleteDuplicateVars_BTN.Text = "Delete Duplicate Vars";
            this.MISC_DeleteDuplicateVars_BTN.UseSelectable = true;
            this.MISC_DeleteDuplicateVars_BTN.Click += new System.EventHandler(this.MISC_DeleteDuplicateVars_BTN_Click);
            // 
            // MISC_MoveVars_BTN
            // 
            this.MISC_MoveVars_BTN.Location = new System.Drawing.Point(621, 15);
            this.MISC_MoveVars_BTN.Name = "MISC_MoveVars_BTN";
            this.MISC_MoveVars_BTN.Size = new System.Drawing.Size(164, 23);
            this.MISC_MoveVars_BTN.TabIndex = 8;
            this.MISC_MoveVars_BTN.Text = "Move Vars To Creators Folders";
            this.MISC_MoveVars_BTN.UseSelectable = true;
            this.MISC_MoveVars_BTN.Click += new System.EventHandler(this.MISC_MoveVars_BTN_Click);
            // 
            // MISC_ExtractImagesScene1_BTN
            // 
            this.MISC_ExtractImagesScene1_BTN.Location = new System.Drawing.Point(135, 43);
            this.MISC_ExtractImagesScene1_BTN.Name = "MISC_ExtractImagesScene1_BTN";
            this.MISC_ExtractImagesScene1_BTN.Size = new System.Drawing.Size(140, 23);
            this.MISC_ExtractImagesScene1_BTN.TabIndex = 9;
            this.MISC_ExtractImagesScene1_BTN.Text = "Extract Images (Scene #1)";
            this.MISC_ExtractImagesScene1_BTN.UseSelectable = true;
            this.MISC_ExtractImagesScene1_BTN.Click += new System.EventHandler(this.MISC_ExtractImagesScene1_BTN_Click);
            // 
            // MISC_Gbx3
            // 
            this.MISC_Gbx3.BackColor = System.Drawing.Color.Transparent;
            this.MISC_Gbx3.Controls.Add(this.MISC_IfJpgExistsNoJpeg_Chkbx);
            this.MISC_Gbx3.Controls.Add(this.MISC_OverwriteImages_Chkbx);
            this.MISC_Gbx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MISC_Gbx3.Location = new System.Drawing.Point(0, 256);
            this.MISC_Gbx3.Name = "MISC_Gbx3";
            this.MISC_Gbx3.Size = new System.Drawing.Size(921, 342);
            this.MISC_Gbx3.TabIndex = 18;
            this.MISC_Gbx3.TabStop = false;
            this.MISC_Gbx3.Text = "Output";
            // 
            // MISC_IfJpgExistsNoJpeg_Chkbx
            // 
            this.MISC_IfJpgExistsNoJpeg_Chkbx.AutoSize = true;
            this.MISC_IfJpgExistsNoJpeg_Chkbx.Location = new System.Drawing.Point(128, 323);
            this.MISC_IfJpgExistsNoJpeg_Chkbx.Name = "MISC_IfJpgExistsNoJpeg_Chkbx";
            this.MISC_IfJpgExistsNoJpeg_Chkbx.Size = new System.Drawing.Size(178, 15);
            this.MISC_IfJpgExistsNoJpeg_Chkbx.TabIndex = 1;
            this.MISC_IfJpgExistsNoJpeg_Chkbx.Text = "If jpg exists don\'t extract jpeg";
            this.MISC_IfJpgExistsNoJpeg_Chkbx.UseSelectable = true;
            // 
            // MISC_OverwriteImages_Chkbx
            // 
            this.MISC_OverwriteImages_Chkbx.AutoSize = true;
            this.MISC_OverwriteImages_Chkbx.Location = new System.Drawing.Point(6, 323);
            this.MISC_OverwriteImages_Chkbx.Name = "MISC_OverwriteImages_Chkbx";
            this.MISC_OverwriteImages_Chkbx.Size = new System.Drawing.Size(115, 15);
            this.MISC_OverwriteImages_Chkbx.TabIndex = 0;
            this.MISC_OverwriteImages_Chkbx.Text = "Overwrite Images";
            this.MISC_OverwriteImages_Chkbx.UseSelectable = true;
            // 
            // Tab_Settings
            // 
            this.Tab_Settings.Controls.Add(this.groupBox1);
            this.Tab_Settings.Controls.Add(this.Settings_Gbx4);
            this.Tab_Settings.Controls.Add(this.Settings_Pixeldrain_Gbx);
            this.Tab_Settings.Controls.Add(this.Settings_Encoding_Gbx);
            this.Tab_Settings.Controls.Add(this.Settings_ExCreators_Gbx);
            this.Tab_Settings.HorizontalScrollbarBarColor = true;
            this.Tab_Settings.HorizontalScrollbarHighlightOnWheel = false;
            this.Tab_Settings.HorizontalScrollbarSize = 10;
            this.Tab_Settings.Location = new System.Drawing.Point(4, 35);
            this.Tab_Settings.Name = "Tab_Settings";
            this.Tab_Settings.Size = new System.Drawing.Size(924, 732);
            this.Tab_Settings.TabIndex = 1;
            this.Tab_Settings.Text = "Settings";
            this.Tab_Settings.VerticalScrollbarBarColor = true;
            this.Tab_Settings.VerticalScrollbarHighlightOnWheel = false;
            this.Tab_Settings.VerticalScrollbarSize = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Settings_SaveAppearance_BTN);
            this.groupBox1.Controls.Add(this.Settings_ThemeStyle_ComboBX);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.Settings_Theme_ComboBX);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.Settings_FontSize_Txtbx);
            this.groupBox1.Controls.Add(this.Settings_SetFontSize_BTN);
            this.groupBox1.Location = new System.Drawing.Point(3, 323);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 119);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Appearance";
            // 
            // Settings_SaveAppearance_BTN
            // 
            this.Settings_SaveAppearance_BTN.Location = new System.Drawing.Point(390, 0);
            this.Settings_SaveAppearance_BTN.Name = "Settings_SaveAppearance_BTN";
            this.Settings_SaveAppearance_BTN.Size = new System.Drawing.Size(78, 24);
            this.Settings_SaveAppearance_BTN.TabIndex = 13;
            this.Settings_SaveAppearance_BTN.Text = "Save";
            this.Settings_SaveAppearance_BTN.UseSelectable = true;
            this.Settings_SaveAppearance_BTN.Click += new System.EventHandler(this.Settings_SaveAppearance_BTN_Click);
            // 
            // Settings_ThemeStyle_ComboBX
            // 
            this.Settings_ThemeStyle_ComboBX.FormattingEnabled = true;
            this.Settings_ThemeStyle_ComboBX.ItemHeight = 23;
            this.Settings_ThemeStyle_ComboBX.Items.AddRange(new object[] {
            "Default",
            "Black",
            "White",
            "Silver",
            "Blue",
            "Green",
            "Lime",
            "Teal",
            "Orange",
            "Brown",
            "Pink",
            "Magenta",
            "Purple",
            "Red",
            "Yellow"});
            this.Settings_ThemeStyle_ComboBX.Location = new System.Drawing.Point(240, 30);
            this.Settings_ThemeStyle_ComboBX.Name = "Settings_ThemeStyle_ComboBX";
            this.Settings_ThemeStyle_ComboBX.Size = new System.Drawing.Size(102, 29);
            this.Settings_ThemeStyle_ComboBX.TabIndex = 35;
            this.Settings_ThemeStyle_ComboBX.UseSelectable = true;
            this.Settings_ThemeStyle_ComboBX.SelectedIndexChanged += new System.EventHandler(this.Settings_ThemeStyle_ComboBX_SelectedIndexChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(195, 33);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(39, 19);
            this.metroLabel3.TabIndex = 34;
            this.metroLabel3.Text = "Style:";
            // 
            // Settings_Theme_ComboBX
            // 
            this.Settings_Theme_ComboBX.FormattingEnabled = true;
            this.Settings_Theme_ComboBX.ItemHeight = 23;
            this.Settings_Theme_ComboBX.Items.AddRange(new object[] {
            "Dark",
            "Light"});
            this.Settings_Theme_ComboBX.Location = new System.Drawing.Point(77, 30);
            this.Settings_Theme_ComboBX.Name = "Settings_Theme_ComboBX";
            this.Settings_Theme_ComboBX.Size = new System.Drawing.Size(102, 29);
            this.Settings_Theme_ComboBX.TabIndex = 33;
            this.Settings_Theme_ComboBX.UseSelectable = true;
            this.Settings_Theme_ComboBX.SelectedIndexChanged += new System.EventHandler(this.Settings_Theme_ComboBX_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 33);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(52, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Theme:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Font Size:";
            // 
            // Settings_FontSize_Txtbx
            // 
            // 
            // 
            // 
            this.Settings_FontSize_Txtbx.CustomButton.Image = null;
            this.Settings_FontSize_Txtbx.CustomButton.Location = new System.Drawing.Point(6, 1);
            this.Settings_FontSize_Txtbx.CustomButton.Name = "";
            this.Settings_FontSize_Txtbx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Settings_FontSize_Txtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Settings_FontSize_Txtbx.CustomButton.TabIndex = 1;
            this.Settings_FontSize_Txtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Settings_FontSize_Txtbx.CustomButton.UseSelectable = true;
            this.Settings_FontSize_Txtbx.CustomButton.Visible = false;
            this.Settings_FontSize_Txtbx.Lines = new string[] {
        "9"};
            this.Settings_FontSize_Txtbx.Location = new System.Drawing.Point(77, 74);
            this.Settings_FontSize_Txtbx.MaxLength = 32767;
            this.Settings_FontSize_Txtbx.Name = "Settings_FontSize_Txtbx";
            this.Settings_FontSize_Txtbx.PasswordChar = '\0';
            this.Settings_FontSize_Txtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Settings_FontSize_Txtbx.SelectedText = "";
            this.Settings_FontSize_Txtbx.SelectionLength = 0;
            this.Settings_FontSize_Txtbx.SelectionStart = 0;
            this.Settings_FontSize_Txtbx.ShortcutsEnabled = true;
            this.Settings_FontSize_Txtbx.Size = new System.Drawing.Size(28, 23);
            this.Settings_FontSize_Txtbx.TabIndex = 27;
            this.Settings_FontSize_Txtbx.Text = "9";
            this.Settings_FontSize_Txtbx.UseSelectable = true;
            this.Settings_FontSize_Txtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Settings_FontSize_Txtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Settings_SetFontSize_BTN
            // 
            this.Settings_SetFontSize_BTN.Location = new System.Drawing.Point(111, 74);
            this.Settings_SetFontSize_BTN.Name = "Settings_SetFontSize_BTN";
            this.Settings_SetFontSize_BTN.Size = new System.Drawing.Size(68, 23);
            this.Settings_SetFontSize_BTN.TabIndex = 26;
            this.Settings_SetFontSize_BTN.Text = "Set";
            this.Settings_SetFontSize_BTN.UseSelectable = true;
            this.Settings_SetFontSize_BTN.Click += new System.EventHandler(this.Settings_SetFontSize_BTN_Click);
            // 
            // Settings_Gbx4
            // 
            this.Settings_Gbx4.BackColor = System.Drawing.Color.Transparent;
            this.Settings_Gbx4.Controls.Add(this.Settings_OpenDownloadLinksFolder_BTN);
            this.Settings_Gbx4.Controls.Add(this.Settings_OpenSharpVamErrorLog_BTN);
            this.Settings_Gbx4.Controls.Add(this.Settings_OpenVamErrorLog_BTN);
            this.Settings_Gbx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_Gbx4.Location = new System.Drawing.Point(500, 235);
            this.Settings_Gbx4.Name = "Settings_Gbx4";
            this.Settings_Gbx4.Size = new System.Drawing.Size(414, 70);
            this.Settings_Gbx4.TabIndex = 25;
            this.Settings_Gbx4.TabStop = false;
            this.Settings_Gbx4.Text = "MISC";
            // 
            // Settings_OpenDownloadLinksFolder_BTN
            // 
            this.Settings_OpenDownloadLinksFolder_BTN.Location = new System.Drawing.Point(268, 25);
            this.Settings_OpenDownloadLinksFolder_BTN.Name = "Settings_OpenDownloadLinksFolder_BTN";
            this.Settings_OpenDownloadLinksFolder_BTN.Size = new System.Drawing.Size(138, 24);
            this.Settings_OpenDownloadLinksFolder_BTN.TabIndex = 2;
            this.Settings_OpenDownloadLinksFolder_BTN.Text = "Download Links Folder";
            this.Settings_OpenDownloadLinksFolder_BTN.UseSelectable = true;
            this.Settings_OpenDownloadLinksFolder_BTN.Click += new System.EventHandler(this.Settings_OpenDownloadLinksFolder_BTN_Click);
            // 
            // Settings_OpenSharpVamErrorLog_BTN
            // 
            this.Settings_OpenSharpVamErrorLog_BTN.Location = new System.Drawing.Point(124, 25);
            this.Settings_OpenSharpVamErrorLog_BTN.Name = "Settings_OpenSharpVamErrorLog_BTN";
            this.Settings_OpenSharpVamErrorLog_BTN.Size = new System.Drawing.Size(138, 24);
            this.Settings_OpenSharpVamErrorLog_BTN.TabIndex = 1;
            this.Settings_OpenSharpVamErrorLog_BTN.Text = "Open SharpVaM Errorlog";
            this.Settings_OpenSharpVamErrorLog_BTN.UseSelectable = true;
            this.Settings_OpenSharpVamErrorLog_BTN.Click += new System.EventHandler(this.Settings_OpenSharpVamErrorLog_BTN_Click);
            // 
            // Settings_OpenVamErrorLog_BTN
            // 
            this.Settings_OpenVamErrorLog_BTN.Location = new System.Drawing.Point(8, 25);
            this.Settings_OpenVamErrorLog_BTN.Name = "Settings_OpenVamErrorLog_BTN";
            this.Settings_OpenVamErrorLog_BTN.Size = new System.Drawing.Size(111, 24);
            this.Settings_OpenVamErrorLog_BTN.TabIndex = 0;
            this.Settings_OpenVamErrorLog_BTN.Text = "Open VaM Log";
            this.Settings_OpenVamErrorLog_BTN.UseSelectable = true;
            this.Settings_OpenVamErrorLog_BTN.Click += new System.EventHandler(this.Settings_OpenVamErrorLog_BTN_Click);
            // 
            // Settings_Pixeldrain_Gbx
            // 
            this.Settings_Pixeldrain_Gbx.BackColor = System.Drawing.Color.Transparent;
            this.Settings_Pixeldrain_Gbx.Controls.Add(this.Settings_SavePixeldrainApi_BTN);
            this.Settings_Pixeldrain_Gbx.Controls.Add(this.Settings_PixeldrainApi_Txtbx);
            this.Settings_Pixeldrain_Gbx.Controls.Add(this.metroLabel8);
            this.Settings_Pixeldrain_Gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_Pixeldrain_Gbx.Location = new System.Drawing.Point(500, 113);
            this.Settings_Pixeldrain_Gbx.Name = "Settings_Pixeldrain_Gbx";
            this.Settings_Pixeldrain_Gbx.Size = new System.Drawing.Size(414, 106);
            this.Settings_Pixeldrain_Gbx.TabIndex = 23;
            this.Settings_Pixeldrain_Gbx.TabStop = false;
            this.Settings_Pixeldrain_Gbx.Text = "Pixeldrain Api Key";
            // 
            // Settings_SavePixeldrainApi_BTN
            // 
            this.Settings_SavePixeldrainApi_BTN.Location = new System.Drawing.Point(331, 0);
            this.Settings_SavePixeldrainApi_BTN.Name = "Settings_SavePixeldrainApi_BTN";
            this.Settings_SavePixeldrainApi_BTN.Size = new System.Drawing.Size(78, 24);
            this.Settings_SavePixeldrainApi_BTN.TabIndex = 15;
            this.Settings_SavePixeldrainApi_BTN.Text = "Save";
            this.Settings_SavePixeldrainApi_BTN.UseSelectable = true;
            this.Settings_SavePixeldrainApi_BTN.Click += new System.EventHandler(this.Settings_SavePixeldrainApi_BTN_Click);
            // 
            // Settings_PixeldrainApi_Txtbx
            // 
            // 
            // 
            // 
            this.Settings_PixeldrainApi_Txtbx.CustomButton.Image = null;
            this.Settings_PixeldrainApi_Txtbx.CustomButton.Location = new System.Drawing.Point(266, 2);
            this.Settings_PixeldrainApi_Txtbx.CustomButton.Name = "";
            this.Settings_PixeldrainApi_Txtbx.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.Settings_PixeldrainApi_Txtbx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Settings_PixeldrainApi_Txtbx.CustomButton.TabIndex = 1;
            this.Settings_PixeldrainApi_Txtbx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Settings_PixeldrainApi_Txtbx.CustomButton.UseSelectable = true;
            this.Settings_PixeldrainApi_Txtbx.CustomButton.Visible = false;
            this.Settings_PixeldrainApi_Txtbx.Lines = new string[] {
        "39f5f370-b01b-4cd8-9ea3-a102f3fbcfa4"};
            this.Settings_PixeldrainApi_Txtbx.Location = new System.Drawing.Point(13, 29);
            this.Settings_PixeldrainApi_Txtbx.MaxLength = 32767;
            this.Settings_PixeldrainApi_Txtbx.Name = "Settings_PixeldrainApi_Txtbx";
            this.Settings_PixeldrainApi_Txtbx.PasswordChar = '\0';
            this.Settings_PixeldrainApi_Txtbx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Settings_PixeldrainApi_Txtbx.SelectedText = "";
            this.Settings_PixeldrainApi_Txtbx.SelectionLength = 0;
            this.Settings_PixeldrainApi_Txtbx.SelectionStart = 0;
            this.Settings_PixeldrainApi_Txtbx.ShortcutsEnabled = true;
            this.Settings_PixeldrainApi_Txtbx.Size = new System.Drawing.Size(288, 24);
            this.Settings_PixeldrainApi_Txtbx.TabIndex = 14;
            this.Settings_PixeldrainApi_Txtbx.Text = "39f5f370-b01b-4cd8-9ea3-a102f3fbcfa4";
            this.Settings_PixeldrainApi_Txtbx.UseSelectable = true;
            this.Settings_PixeldrainApi_Txtbx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Settings_PixeldrainApi_Txtbx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(13, 58);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(372, 38);
            this.metroLabel8.TabIndex = 20;
            this.metroLabel8.Text = "If you want to automatically upload to pixeldrain after zipping,\r\nadd your pixeld" +
    "rain account apikey.";
            // 
            // Settings_Encoding_Gbx
            // 
            this.Settings_Encoding_Gbx.BackColor = System.Drawing.Color.Transparent;
            this.Settings_Encoding_Gbx.Controls.Add(this.Settings_SaveEncoding_BTN);
            this.Settings_Encoding_Gbx.Controls.Add(this.Settings_GB2312_Chkbx);
            this.Settings_Encoding_Gbx.Controls.Add(this.Settings_UTF8_Chkbx);
            this.Settings_Encoding_Gbx.Controls.Add(this.metroLabel9);
            this.Settings_Encoding_Gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_Encoding_Gbx.Location = new System.Drawing.Point(500, 27);
            this.Settings_Encoding_Gbx.Name = "Settings_Encoding_Gbx";
            this.Settings_Encoding_Gbx.Size = new System.Drawing.Size(414, 73);
            this.Settings_Encoding_Gbx.TabIndex = 22;
            this.Settings_Encoding_Gbx.TabStop = false;
            this.Settings_Encoding_Gbx.Text = "Select Encoding";
            // 
            // Settings_SaveEncoding_BTN
            // 
            this.Settings_SaveEncoding_BTN.Location = new System.Drawing.Point(331, 0);
            this.Settings_SaveEncoding_BTN.Name = "Settings_SaveEncoding_BTN";
            this.Settings_SaveEncoding_BTN.Size = new System.Drawing.Size(78, 24);
            this.Settings_SaveEncoding_BTN.TabIndex = 19;
            this.Settings_SaveEncoding_BTN.Text = "Save";
            this.Settings_SaveEncoding_BTN.UseSelectable = true;
            this.Settings_SaveEncoding_BTN.Click += new System.EventHandler(this.Settings_SaveEncoding_BTN_Click);
            // 
            // Settings_GB2312_Chkbx
            // 
            this.Settings_GB2312_Chkbx.AutoSize = true;
            this.Settings_GB2312_Chkbx.Location = new System.Drawing.Point(91, 21);
            this.Settings_GB2312_Chkbx.Name = "Settings_GB2312_Chkbx";
            this.Settings_GB2312_Chkbx.Size = new System.Drawing.Size(115, 15);
            this.Settings_GB2312_Chkbx.TabIndex = 18;
            this.Settings_GB2312_Chkbx.Text = "GB2312 (Chinese)";
            this.Settings_GB2312_Chkbx.UseSelectable = true;
            this.Settings_GB2312_Chkbx.CheckedChanged += new System.EventHandler(this.Settings_GB2312_Chkbx_CheckedChanged);
            // 
            // Settings_UTF8_Chkbx
            // 
            this.Settings_UTF8_Chkbx.AutoSize = true;
            this.Settings_UTF8_Chkbx.Location = new System.Drawing.Point(13, 20);
            this.Settings_UTF8_Chkbx.Name = "Settings_UTF8_Chkbx";
            this.Settings_UTF8_Chkbx.Size = new System.Drawing.Size(54, 15);
            this.Settings_UTF8_Chkbx.TabIndex = 17;
            this.Settings_UTF8_Chkbx.Text = "UTF-8";
            this.Settings_UTF8_Chkbx.UseSelectable = true;
            this.Settings_UTF8_Chkbx.CheckedChanged += new System.EventHandler(this.Settings_UTF8_Chkbx_CheckedChanged);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(13, 42);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(241, 19);
            this.metroLabel9.TabIndex = 21;
            this.metroLabel9.Text = "GB2312 is used with Chinese zip/var files";
            // 
            // Settings_ExCreators_Gbx
            // 
            this.Settings_ExCreators_Gbx.BackColor = System.Drawing.Color.Transparent;
            this.Settings_ExCreators_Gbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Settings_ExCreators_Gbx.Controls.Add(this.Settings_ExCreators_Txtbx);
            this.Settings_ExCreators_Gbx.Controls.Add(this.ex_label1);
            this.Settings_ExCreators_Gbx.Controls.Add(this.Settings_SaveExCreators_BTN);
            this.Settings_ExCreators_Gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_ExCreators_Gbx.Location = new System.Drawing.Point(3, 27);
            this.Settings_ExCreators_Gbx.Name = "Settings_ExCreators_Gbx";
            this.Settings_ExCreators_Gbx.Size = new System.Drawing.Size(474, 278);
            this.Settings_ExCreators_Gbx.TabIndex = 24;
            this.Settings_ExCreators_Gbx.TabStop = false;
            this.Settings_ExCreators_Gbx.Text = "Exceptional Creators";
            // 
            // Settings_ExCreators_Txtbx
            // 
            this.Settings_ExCreators_Txtbx.BackColor = System.Drawing.Color.Silver;
            this.Settings_ExCreators_Txtbx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Settings_ExCreators_Txtbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings_ExCreators_Txtbx.Location = new System.Drawing.Point(6, 41);
            this.Settings_ExCreators_Txtbx.Name = "Settings_ExCreators_Txtbx";
            this.Settings_ExCreators_Txtbx.Size = new System.Drawing.Size(462, 228);
            this.Settings_ExCreators_Txtbx.TabIndex = 10;
            this.Settings_ExCreators_Txtbx.Text = "";
            // 
            // ex_label1
            // 
            this.ex_label1.AutoSize = true;
            this.ex_label1.Location = new System.Drawing.Point(6, 17);
            this.ex_label1.Name = "ex_label1";
            this.ex_label1.Size = new System.Drawing.Size(369, 19);
            this.ex_label1.TabIndex = 11;
            this.ex_label1.Text = "Add any creator with weird name / spaces to the following list";
            // 
            // Settings_SaveExCreators_BTN
            // 
            this.Settings_SaveExCreators_BTN.Location = new System.Drawing.Point(390, 0);
            this.Settings_SaveExCreators_BTN.Name = "Settings_SaveExCreators_BTN";
            this.Settings_SaveExCreators_BTN.Size = new System.Drawing.Size(78, 24);
            this.Settings_SaveExCreators_BTN.TabIndex = 12;
            this.Settings_SaveExCreators_BTN.Text = "Save";
            this.Settings_SaveExCreators_BTN.UseSelectable = true;
            this.Settings_SaveExCreators_BTN.Click += new System.EventHandler(this.Settings_SaveExCreators_BTN_Click);
            // 
            // hero
            // 
            this.hero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hero.Image = global::Sharp_VaM_Tools.Properties.Resources.thor_hero;
            this.hero.Location = new System.Drawing.Point(33, 835);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(150, 114);
            this.hero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hero.TabIndex = 17;
            this.hero.TabStop = false;
            this.hero.Visible = false;
            // 
            // Fine_PIC
            // 
            this.Fine_PIC.Image = global::Sharp_VaM_Tools.Properties.Resources.Speech_bubble_fine;
            this.Fine_PIC.Location = new System.Drawing.Point(631, 835);
            this.Fine_PIC.Name = "Fine_PIC";
            this.Fine_PIC.Size = new System.Drawing.Size(150, 114);
            this.Fine_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fine_PIC.TabIndex = 4;
            this.Fine_PIC.TabStop = false;
            this.Fine_PIC.Visible = false;
            // 
            // Boss_Fine_PIC
            // 
            this.Boss_Fine_PIC.Image = global::Sharp_VaM_Tools.Properties.Resources.solid_snake_salute;
            this.Boss_Fine_PIC.Location = new System.Drawing.Point(789, 835);
            this.Boss_Fine_PIC.Name = "Boss_Fine_PIC";
            this.Boss_Fine_PIC.Size = new System.Drawing.Size(150, 114);
            this.Boss_Fine_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Boss_Fine_PIC.TabIndex = 1;
            this.Boss_Fine_PIC.TabStop = false;
            this.Boss_Fine_PIC.Visible = false;
            // 
            // F95_PIC
            // 
            this.F95_PIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(38)))), ((int)(((byte)(42)))));
            this.F95_PIC.Image = ((System.Drawing.Image)(resources.GetObject("F95_PIC.Image")));
            this.F95_PIC.Location = new System.Drawing.Point(801, 27);
            this.F95_PIC.Name = "F95_PIC";
            this.F95_PIC.Size = new System.Drawing.Size(150, 30);
            this.F95_PIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.F95_PIC.TabIndex = 18;
            this.F95_PIC.TabStop = false;
            this.F95_PIC.Click += new System.EventHandler(this.F95_PIC_Click);
            // 
            // Boss_Smoking_Gif
            // 
            this.Boss_Smoking_Gif.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Boss_Smoking_Gif.Image = global::Sharp_VaM_Tools.Properties.Resources.big_boss_smoking;
            this.Boss_Smoking_Gif.Location = new System.Drawing.Point(389, 835);
            this.Boss_Smoking_Gif.Name = "Boss_Smoking_Gif";
            this.Boss_Smoking_Gif.Size = new System.Drawing.Size(198, 114);
            this.Boss_Smoking_Gif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Boss_Smoking_Gif.TabIndex = 19;
            this.Boss_Smoking_Gif.TabStop = false;
            this.Boss_Smoking_Gif.Visible = false;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(963, 963);
            this.Controls.Add(this.Boss_Smoking_Gif);
            this.Controls.Add(this.F95_PIC);
            this.Controls.Add(this.hero);
            this.Controls.Add(this.Fine_PIC);
            this.Controls.Add(this.Boss_Fine_PIC);
            this.Controls.Add(this.TapsControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Sharp VaM Tools v2.4";
            this.TapsControl.ResumeLayout(false);
            this.Tab_Search_My_Folders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchMyFolders_dataGridView1)).EndInit();
            this.SearchMyFolders_CM_datagridview1.ResumeLayout(false);
            this.SearchMyFolders_CM_VarsList_Txtbx.ResumeLayout(false);
            this.SearchMyFolders_Gbx2.ResumeLayout(false);
            this.SearchMyFolders_Gbx3.ResumeLayout(false);
            this.Tab_Extract.ResumeLayout(false);
            this.Extract_CM_Output_Txtbx.ResumeLayout(false);
            this.Extract_Gbx1.ResumeLayout(false);
            this.Extract_Gbx1.PerformLayout();
            this.Extract_CM_Input_Txtbx.ResumeLayout(false);
            this.Extract_Gbx2.ResumeLayout(false);
            this.Extract_Gbx2.PerformLayout();
            this.Tab_Missing_from_F95.ResumeLayout(false);
            this.Tab_Missing_from_F95.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MissingFromF95_dataGridView)).EndInit();
            this.MissingFromF95_CM_dataGridView.ResumeLayout(false);
            this.MissingFromF95_CM_IncludedModelsAssets_Txtbx.ResumeLayout(false);
            this.MissingFromF95_Gbx1.ResumeLayout(false);
            this.MissingFromF95_Gbx4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MissingFromF95_YingYang_PixelDrain)).EndInit();
            this.Tab_Search_Inside_vars.ResumeLayout(false);
            this.Tab_Search_Inside_vars.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchInsideVars_dataGridView)).EndInit();
            this.SearchInsideVars_CM_dataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchInsideVars_YingYangBuildDB_Pic)).EndInit();
            this.SearchInsideVars_Gbx2.ResumeLayout(false);
            this.SearchInsideVars_Gbx2.PerformLayout();
            this.SearchInsideVars_Gbx3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchInsideVars_AnalyzeVars_YinYang_Pic)).EndInit();
            this.SearchInsideVars_CM_VarToCRCAndPaths.ResumeLayout(false);
            this.Tab_Analyze_Vars.ResumeLayout(false);
            this.AnalyzeVars_GBX4.ResumeLayout(false);
            this.AnalyzeVars_Gbx2.ResumeLayout(false);
            this.AnalyzeVars_Gbx2.PerformLayout();
            this.AnalyzeVars_Gbx3.ResumeLayout(false);
            this.AnalyzeVars_Gbx3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnalyzeVars_YingYang_PIC)).EndInit();
            this.AnalyzeVars_CM_Result_Txtbx.ResumeLayout(false);
            this.Tab_Security_MalwareScan.ResumeLayout(false);
            this.Security_CM_ScanResultMalware_Txtbx.ResumeLayout(false);
            this.Security_CM_ScanResultSuspecious_Txtbx.ResumeLayout(false);
            this.Security_CM_VarsToScan_Txtbx.ResumeLayout(false);
            this.Security_Gbx1.ResumeLayout(false);
            this.Security_Gbx1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Security_YinYang_Scan)).EndInit();
            this.Tab_MISC.ResumeLayout(false);
            this.MISC_CM_Output_Txtbx.ResumeLayout(false);
            this.MISC_Gbx2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MISC_YingYang0_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MISC_YingYang1_PIC)).EndInit();
            this.MISC_Gbx3.ResumeLayout(false);
            this.MISC_Gbx3.PerformLayout();
            this.Tab_Settings.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Settings_Gbx4.ResumeLayout(false);
            this.Settings_Pixeldrain_Gbx.ResumeLayout(false);
            this.Settings_Pixeldrain_Gbx.PerformLayout();
            this.Settings_Encoding_Gbx.ResumeLayout(false);
            this.Settings_Encoding_Gbx.PerformLayout();
            this.Settings_ExCreators_Gbx.ResumeLayout(false);
            this.Settings_ExCreators_Gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fine_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boss_Fine_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.F95_PIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Boss_Smoking_Gif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl TapsControl;
        private MetroFramework.Controls.MetroTabPage Tab_Search_My_Folders;
        private MetroFramework.Controls.MetroTabPage Tab_Settings;
        private System.Windows.Forms.RichTextBox SearchMyFolders_VarsList_Txtbx;
        private System.Windows.Forms.RichTextBox SearchMyFolders_VarsLocations_Txtbx;
        private MetroFramework.Controls.MetroButton SearchMyFolders_StartSearching_BTN;
        private MetroFramework.Controls.MetroTabPage Tab_Extract;
        private MetroFramework.Controls.MetroButton Extract_VarNames_BTN;
        private System.Windows.Forms.RichTextBox Extract_Output_Txtbx;
        private System.Windows.Forms.RichTextBox Extract_Input_Txtbx;
        private MetroFramework.Controls.MetroButton SearchMyFolders_Browse_BTN;
        private System.Windows.Forms.DataGridView SearchMyFolders_dataGridView1;
        private MetroFramework.Controls.MetroButton SearchMyFolders_SaveLocations_BTN;
        private System.Windows.Forms.PictureBox Boss_Fine_PIC;
        private System.Windows.Forms.PictureBox Fine_PIC;
        private MetroFramework.Controls.MetroButton Settings_SaveExCreators_BTN;
        private MetroFramework.Controls.MetroLabel ex_label1;
        private MetroFramework.Controls.MetroTabPage Tab_Missing_from_F95;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.RichTextBox MissingFromF95_CreatorPaths_Txtbx;
        private MetroFramework.Controls.MetroButton MissingFromF95_Search_BTN;
        private System.Windows.Forms.RichTextBox MissingFromF95_IncludedModelsAssets_Txtbx;
        private System.Windows.Forms.DataGridView MissingFromF95_dataGridView;
        private MetroFramework.Controls.MetroButton MissingFromF95_zip_BTN;
        private MetroFramework.Controls.MetroTextBox MissingFromF95_ZipSavePath_Txtbx;
        private MetroFramework.Controls.MetroButton MissingFromF95_BrowseZip_BTN;
        private MetroFramework.Controls.MetroCheckBox MissingFromF95_IncludeVarImages_Chkbx;
        private System.Windows.Forms.PictureBox hero;
        private MetroFramework.Controls.MetroCheckBox MissingFromF95_PixeldrainUpload_Chkbx;
        private MetroFramework.Controls.MetroTextBox MissingFromF95_Pixeldrain_Txtbx;
        private MetroFramework.Controls.MetroButton Settings_SavePixeldrainApi_BTN;
        private MetroFramework.Controls.MetroTextBox Settings_PixeldrainApi_Txtbx;
        private MetroFramework.Controls.MetroButton MissingFromF95_Browse_BTN;
        private MetroFramework.Controls.MetroTabPage Tab_Search_Inside_vars;
        private MetroFramework.Controls.MetroTextBox SearchInsideVars_SearchStrings_Txtbx;
        private System.Windows.Forms.RichTextBox SearchInsideVars_VarPaths_Txtbx;
        private MetroFramework.Controls.MetroButton SearchInsideVars_SearchFolders_BTN;
        private System.Windows.Forms.DataGridView SearchInsideVars_dataGridView;
        private MetroFramework.Controls.MetroButton SearchInsideVars_BuildDatabase_BTN;
        private MetroFramework.Controls.MetroCheckBox SearchInsideVars_KeepBookmarks_Chkbx;
        private MetroFramework.Controls.MetroCheckBox SearchInsideVars_Append_Chkbx;
        private MetroFramework.Controls.MetroTextBox SearchInsideVars_db_Path_Txtbx;
        private MetroFramework.Controls.MetroButton SearchInsideVars_SearchDatabase_BTN;
        private MetroFramework.Controls.MetroLabel SearchInsideVars_BuildingDone_Lbl;
        private MetroFramework.Controls.MetroButton SearchInsideVars_Browse_BTN;
        private MetroFramework.Controls.MetroCheckBox SearchMyFolders_ExtractVarNamesFirst_Chkbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private MetroFramework.Controls.MetroCheckBox Settings_GB2312_Chkbx;
        private MetroFramework.Controls.MetroCheckBox Settings_UTF8_Chkbx;
        private MetroFramework.Controls.MetroButton Settings_SaveEncoding_BTN;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private MetroFramework.Controls.MetroButton MissingFromF95_ExtractVarNames_BTN;
        private MetroFramework.Controls.MetroContextMenu SearchMyFolders_CM_VarsList_Txtbx;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_VarsList_Txtbx_Copy;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_VarsList_Txtbx_Paste;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_VarsList_Txtbx_Clear;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_VarsList_Txtbx_Extract;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_VarsList_Txtbx_CopyAll;
        private MetroFramework.Controls.MetroContextMenu SearchMyFolders_CM_datagridview1;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_datagridview1_CopySelected;
        private MetroFramework.Controls.MetroTabPage Tab_Security_MalwareScan;
        private System.Windows.Forms.RichTextBox Security_VarsToScan_Txtbx;
        private MetroFramework.Controls.MetroButton Security_Browse_BTN;
        private MetroFramework.Controls.MetroButton Security_Scan_BTN;
        private MetroFramework.Controls.MetroCheckBox SearchMyFolders_ExtractOnly_metajson_Chkbx;
        private MetroFramework.Controls.MetroButton Extract_Generate_metajson_BTN;
        private MetroFramework.Controls.MetroContextMenu Extract_CM_Input_Txtbx;
        private System.Windows.Forms.ToolStripMenuItem Extract_CM_Input_Txtbx_Copy;
        private System.Windows.Forms.ToolStripMenuItem Extract_CM_Input_Txtbx_Paste;
        private MetroFramework.Controls.MetroContextMenu Extract_CM_Output_Txtbx;
        private System.Windows.Forms.ToolStripMenuItem Extract_CM_Output_Txtbx_Copy;
        private System.Windows.Forms.ToolStripMenuItem Extract_CM_Output_Txtbx_CopyAll;
        private System.Windows.Forms.ToolStripMenuItem Extract_CM_Output_Txtbx_Clear;
        private MetroFramework.Controls.MetroButton Extract_GenerateDependecies_BTN;
        private System.Windows.Forms.ToolStripMenuItem Extract_CM_Input_Txtbx_Clear;
        private MetroFramework.Controls.MetroContextMenu MissingFromF95_CM_IncludedModelsAssets_Txtbx;
        private System.Windows.Forms.ToolStripMenuItem MissingFromF95_CM_IncludedModelsAssets_CopyAll;
        private System.Windows.Forms.ToolStripMenuItem MissingFromF95_CM_IncludedModelsAssets_CopySelected;
        private System.Windows.Forms.ToolStripMenuItem MissingFromF95_CM_IncludedModelsAssets_Paste;
        private System.Windows.Forms.ToolStripMenuItem MissingFromF95_CM_IncludedModelsAssets_ClearAll;
        private MetroFramework.Controls.MetroContextMenu MissingFromF95_CM_dataGridView;
        private System.Windows.Forms.ToolStripMenuItem MissingFromF95_CM_dataGridView_Copy;
        private MetroFramework.Controls.MetroContextMenu SearchInsideVars_CM_dataGridView;
        private System.Windows.Forms.ToolStripMenuItem SearchInsideVars_CM_dataGridView_Copy;
        private System.Windows.Forms.ToolStripMenuItem SearchInsideVars_CM_dataGridView_CopyPathJson;
        private MetroFramework.Controls.MetroCheckBox SearchInsideVars_IsMorph_Chkbx;
        private MetroFramework.Controls.MetroTextBox SearchInsideVars_SearchSubfilter_Txtbx;
        private MetroFramework.Controls.MetroCheckBox SearchInsideVars_UseSubfilter_Chkbx;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.RichTextBox Security_ScanResultSuspecious_Txtbx;
        private System.Windows.Forms.RichTextBox Security_ScanResultMalware_Txtbx;
        private System.Windows.Forms.ContextMenuStrip Security_CM_ScanResultSuspecious_Txtbx;
        private MetroFramework.Controls.MetroContextMenu MISC_CM_Output_Txtbx;
        private System.Windows.Forms.ContextMenuStrip Security_CM_ScanResultMalware_Txtbx;
        private System.Windows.Forms.ToolStripMenuItem Security_CM_ScanResultMalware_Txtbx_CopySelected;
        private System.Windows.Forms.ToolStripMenuItem Security_CM_ScanResultMalware_Txtbx_CopyAll;
        private System.Windows.Forms.ToolStripMenuItem Security_CM_ScanResultMalware_Txtbx_ClearAll;
        private System.Windows.Forms.ToolStripMenuItem Security_CM_ScanResultSuspecious_Txtbx_CopySelected;
        private System.Windows.Forms.ToolStripMenuItem Security_CM_ScanResultSuspecious_Txtbx_CopyAll;
        private System.Windows.Forms.ToolStripMenuItem Security_CM_ScanResultSuspecious_Txtbx_ClearAll;
        private System.Windows.Forms.ToolStripMenuItem MISC_CM_Output_Txtbx_Clear;
        private System.Windows.Forms.ToolStripMenuItem SearchInsideVars_CM_dataGridView_Bookmark;
        private System.Windows.Forms.RichTextBox SearchInsideVars_VarToCRCAndPaths_Txtbx;
        private System.Windows.Forms.ToolStripMenuItem SearchInsideVars_CM_dataGridView_RemoveBookmark;
        private MetroFramework.Controls.MetroTextBox SearchInsideVars_SearchVarToCRCAndPathsTxtbx;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_datagridview1_SearchMissingVars;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_datagridview1_DownloadHub;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_datagridview1_SearchF95;
        private System.Windows.Forms.RichTextBox Settings_ExCreators_Txtbx;
        private MetroFramework.Controls.MetroCheckBox SearchMyFolders_Ignore_metajson_Chkbx;
        private MetroFramework.Controls.MetroCheckBox Extract_Isjson_Chkbx;
        private System.Windows.Forms.ToolStripMenuItem SearchInsideVars_CM_dataGridView_CopyPathJsonLatest;
        private MetroFramework.Controls.MetroButton SearchInsideVars_Cancel_BTN;
        private MetroFramework.Controls.MetroCheckBox Security_escape_ApplicationOpenURL_Chkbx;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_datagridview1_OpenVarLocation;
        private MetroFramework.Controls.MetroTextBox SearchMyFolders_Search_DataGridView;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_datagridview1_SaveResultcsv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Var;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_datagridview1_SearchTorrent;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_datagridview1_CancelAll;
        private System.Windows.Forms.PictureBox SearchInsideVars_YingYangBuildDB_Pic;
        private System.Windows.Forms.PictureBox MissingFromF95_YingYang_PixelDrain;
        private MetroFramework.Controls.MetroCheckBox MissingFromF95_DeleteZipAfterUploading_Chkbx;
        private System.Windows.Forms.ToolStripMenuItem SearchInsideVars_CM_dataGridView_CopyCrc;
        private System.Windows.Forms.PictureBox F95_PIC;
        private MetroFramework.Controls.MetroCheckBox Security_escape_FileMangementSecure_Chkbx;
        private System.Windows.Forms.PictureBox Security_YinYang_Scan;
        private MetroFramework.Controls.MetroCheckBox Security_escape_EventTrigger_Chkbx;
        private System.Windows.Forms.ToolStripMenuItem SearchInsideVars_CM_dataGridView_OpenVarLocation;
        private MetroFramework.Controls.MetroCheckBox Extract_LicenseType_Chkbx;
        private MetroFramework.Controls.MetroCheckBox Extract_GetSubDependencies_Chkbx;
        private MetroFramework.Controls.MetroContextMenu SearchInsideVars_CM_VarToCRCAndPaths;
        private System.Windows.Forms.ToolStripMenuItem SearchInsideVars_CM_VarToCRCAndPaths_CopySelected;
        private System.Windows.Forms.ToolStripMenuItem SearchInsideVars_CM_VarToCRCAndPaths_CopyAll;
        private System.Windows.Forms.ToolStripMenuItem SearchInsideVars_CM_VarToCRCAndPaths_ClearAll;
        private MetroFramework.Controls.MetroButton Extract_DownloadLinks_BTN;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_datagridview1_MalwareScan;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_datagridview1_CopyVarsToPath;
        private MetroFramework.Controls.MetroTabPage Tab_MISC;
        private System.Windows.Forms.RichTextBox MISC_Paths_Txtbx;
        private System.Windows.Forms.RichTextBox MISC_Output_Txtbx;
        private MetroFramework.Controls.MetroButton MISC_DeleteDuplicateVars_BTN;
        private MetroFramework.Controls.MetroButton MISC_ExtractImagesScene1_BTN;
        private MetroFramework.Controls.MetroButton MISC_MoveVars_BTN;
        private MetroFramework.Controls.MetroButton MISC_ExtractImagesMontage_BTN;
        private MetroFramework.Controls.MetroButton MISC_Stop_BTN;
        private MetroFramework.Controls.MetroButton MISC_Browse_BTN;
        private System.Windows.Forms.PictureBox Boss_Smoking_Gif;
        private MetroFramework.Controls.MetroCheckBox Security_escape_Assetbundles_Chkbx;
        private System.Windows.Forms.GroupBox Settings_Encoding_Gbx;
        private System.Windows.Forms.GroupBox Settings_ExCreators_Gbx;
        private System.Windows.Forms.GroupBox Settings_Pixeldrain_Gbx;
        private System.Windows.Forms.GroupBox SearchMyFolders_Gbx1;
        private System.Windows.Forms.GroupBox SearchMyFolders_Gbx2;
        private System.Windows.Forms.GroupBox SearchMyFolders_Gbx3;
        private System.Windows.Forms.GroupBox Extract_Gbx1;
        private System.Windows.Forms.GroupBox Extract_Gbx2;
        private System.Windows.Forms.GroupBox SearchInsideVars_Gbx1;
        private System.Windows.Forms.GroupBox SearchInsideVars_Gbx2;
        private System.Windows.Forms.GroupBox SearchInsideVars_Gbx3;
        private System.Windows.Forms.GroupBox Settings_Gbx4;
        private MetroFramework.Controls.MetroButton Settings_OpenVamErrorLog_BTN;
        private MetroFramework.Controls.MetroButton Settings_OpenSharpVamErrorLog_BTN;
        private MetroFramework.Controls.MetroButton Settings_OpenDownloadLinksFolder_BTN;
        private System.Windows.Forms.GroupBox MISC_Gbx1;
        private System.Windows.Forms.GroupBox MISC_Gbx2;
        private System.Windows.Forms.GroupBox MISC_Gbx3;
        private MetroFramework.Controls.MetroContextMenu Security_CM_VarsToScan_Txtbx;
        private System.Windows.Forms.ToolStripMenuItem Security_CM_VarsToScan_Txtbx_Clear;
        private System.Windows.Forms.GroupBox MissingFromF95_Gbx1;
        private System.Windows.Forms.GroupBox MissingFromF95_Gbx2;
        private System.Windows.Forms.GroupBox MissingFromF95_Gbx3;
        private System.Windows.Forms.GroupBox MissingFromF95_Gbx4;
        private MetroFramework.Controls.MetroButton MISC_DeleteCorruptedVars_BTN;
        private System.Windows.Forms.GroupBox Security_Gbx1;
        private System.Windows.Forms.GroupBox Security_Gbx2;
        private System.Windows.Forms.GroupBox Security_Gbx3;
        private System.Windows.Forms.PictureBox SearchInsideVars_AnalyzeVars_YinYang_Pic;
        private System.Windows.Forms.ToolStripMenuItem SearchInsideVars_CM_VarToCRCAndPaths_CancelAll;
        private MetroFramework.Controls.MetroCheckBox SearchMyFolders_SkipHubCheck_Chkbx;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_datagridview1_SaveDownloadLinksTxt;
        private MetroFramework.Controls.MetroButton MISC_ExtractChineseArchives_BTN;
        private System.Windows.Forms.PictureBox MISC_YingYang0_PIC;
        private System.Windows.Forms.PictureBox MISC_YingYang1_PIC;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_VarsList_Txtbx_ExtractVAMMissingDependencies;
        private MetroFramework.Controls.MetroCheckBox SearchMyFolders_AutoSearch_Chkbx;
        private MetroFramework.Controls.MetroButton MISC_ExtractImagesScene2_BTN;
        private MetroFramework.Controls.MetroCheckBox SearchMyFolders_AutoDownload_Chkbx;
        private MetroFramework.Controls.MetroCheckBox MISC_OverwriteImages_Chkbx;
        private MetroFramework.Controls.MetroTabPage Tab_Analyze_Vars;
        private MetroFramework.Controls.MetroButton AnalyzeVars_Browse_BTN;
        private System.Windows.Forms.RichTextBox AnalyzeVars_Result_Txtbx;
        private System.Windows.Forms.GroupBox AnalyzeVars_GBX4;
        private System.Windows.Forms.GroupBox AnalyzeVars_Gbx2;
        private MetroFramework.Controls.MetroCheckBox AnalyzeVars_ListVarsContent_Chkbx;
        private MetroFramework.Controls.MetroCheckBox AnalyzeVars_DetectPlugins_Chkbx;
        private MetroFramework.Controls.MetroCheckBox AnalyzeVars_LocalReferences_Chkbx;
        private MetroFramework.Controls.MetroCheckBox AnalyzeVars_BloatedVar_Chkbx;
        private MetroFramework.Controls.MetroCheckBox AnalyzeVars_Morphs_Chkbx;
        private MetroFramework.Controls.MetroCheckBox AnalyzeVars_DeserializeJson_Chkbx;
        private MetroFramework.Controls.MetroCheckBox AnalyzeVars_metaJson_Chkbx;
        private System.Windows.Forms.GroupBox AnalyzeVars_Gbx3;
        private System.Windows.Forms.PictureBox AnalyzeVars_YingYang_PIC;
        private MetroFramework.Controls.MetroCheckBox AnalyzeVars_ExtractImagesExif_Chkbx;
        private MetroFramework.Controls.MetroCheckBox AnalyzeVars_NonVamImages_Chkbx;
        private MetroFramework.Controls.MetroCheckBox AnalyzeVars_ImagesMISC_Chkbx;
        private MetroFramework.Controls.MetroCheckBox AnalyzeVars_TamperedwithVar_Chkbx;
        private MetroFramework.Controls.MetroButton AnalyzeVars_Cencel_BTN;
        private MetroFramework.Controls.MetroTextBox AnalyzeVars_Search_Txtbx;
        private MetroFramework.Controls.MetroContextMenu AnalyzeVars_CM_Result_Txtbx;
        private System.Windows.Forms.ToolStripMenuItem AnalyzeVars_CM_Result_Txtbx_ShowWarnings;
        private System.Windows.Forms.ToolStripMenuItem AnalyzeVars_CM_Result_Txtbx_CopyWarnings;
        private System.Windows.Forms.ToolStripMenuItem AnalyzeVars_CM_Result_Txtbx_GoBack;
        private System.Windows.Forms.ToolStripMenuItem AnalyzeVars_CM_Result_Txtbx_CopySelected;
        private System.Windows.Forms.ToolStripMenuItem AnalyzeVars_CM_Result_Txtbx_CopyAllText;
        private System.Windows.Forms.ToolStripMenuItem AnalyzeVars_CM_Result_Txtbx_Clear;
        private System.Windows.Forms.ToolStripMenuItem SearchInsideVars_CM_VarToCRCAndPaths_Browse;
        private MetroFramework.Controls.MetroButton SearchMyFolder_Browse2_BTN;
        private MetroFramework.Controls.MetroCheckBox MISC_IfJpgExistsNoJpeg_Chkbx;
        private MetroFramework.Controls.MetroButton MISC_MoveUnusedVars_BTN;
        private MetroFramework.Controls.MetroCheckBox Security_EscapeClean_Chkbx;
        private MetroFramework.Controls.MetroTextBox Settings_FontSize_Txtbx;
        private MetroFramework.Controls.MetroButton Settings_SetFontSize_BTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroComboBox Settings_Theme_ComboBX;
        private MetroFramework.Controls.MetroComboBox Settings_ThemeStyle_ComboBX;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
        private MetroFramework.Controls.MetroButton Settings_SaveAppearance_BTN;
        private System.Windows.Forms.ToolStripMenuItem SearchMyFolders_CM_datagridview1_MoveVarsToPath;
    }
}

