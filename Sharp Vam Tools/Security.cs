using ICSharpCode.Decompiler;
using ICSharpCode.Decompiler.CSharp;
using SharpCompress.Common;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Sharp_VaM_Tools
{
    internal class Security
    {

        public static List<string> malware_strings = new List<string> {
                
                //Fixed after vam security patch >= 1.22.0.8
                "Application.OpenURL", "System.Xml", "XmlTextReader", "XmlWriter",
  
                //Delete|Move
                "DeleteDirectory", "DeleteDirectoryFromPlugin", "MoveDirectory", "DeleteFile(", "MoveFile(", "MoveFileFromPlugin", "DeleteFileFromPlugin",
                 
                //System.Net (ready/write are fixed after vam security patch >= 1.22.0.8)
                "System.Net", "HttpWebResponse", "HttpWebRequest", "FtpWebRequest", "FtpWebResponse", "WebClient", "WebRequest.Create",
                "DownloadFile", "DownloadData", "DownloadString", "UploadFile", "UploadData", "UploadString", "MailMessage",

                //UnityWebRequest (dll only)
                "UnityWebRequest", "UnityWebRequestAssetBundle", "UnityEngine.Networking", "DownloadHandler", "UploadHandler", "CertificateHandler",

                //Blocked by VaM, added for other purposes
                "File.Read", "File.Write", "File.Delete", "StreamReader", "StreamWriter", "Process.Start(", "cmd.exe", "\"cmd\"", "powershell.exe", "powershell", "rundll32",
                "Assembly.Load", "Assembly.Reflection", "Assembly.UnsafeLoadFrom", "Assembly.Get", "System.AppDomain", "OpenWithDefaultApp", "BaseDirectory",
                "DllImport",
            
                //DynamicCSharp_Config_1.22.0.12
                "System.Management", "System.Data", "System.Deployment", "System.Net.Mail", "Battlehub.RTSaveLoad", "DynamicCSharp", "AssetBundleLoader",
                "AssetBundleEventHandler", "ZenFulcrum.EmbeddedBrowser", "PersistentObjects", "Newtonsoft.Json", "MHLab.PATCH", "Boo.Lang", "NAudio.", "ICSharpCode.SharpZipLib",
                "Mono.Data", "Mono.Posix", "Mono.Security", "Mono.WebBrowser", "Mono.Cecil", "System.EnterpriseServices", "XPathDocument", "SteamVR_Input_ActionFile", "OBJExporter",
                "UnityEngine.PlayerPrefs", "ProtoBuf", "UnityEditor", "RTTypeModel",

                //JayJaywon
                ".bat"
                };

        public static List<string> suspecious_strings = new List<string> { 
                       //Unity
                       "EventTrigger", "CaptureScreenshot(", "Application.dataPath", 

                       //VAM https://apidoc.virtamate.com/api/MVR.FileManagementSecure.html
                        "FileManagerSecure", "FileManagementSecure", "WebClientSecure",   

                        //DynamicCSharp_Config_1.22.0.12
                         "System.Security",

                        //JayJaywon
                        "BrowserAssist", "SymLinks",

                       //Others
                        "System.IO", "System.Reflection", ".dll"
                };


        public static bool flagged_cs;
        public static bool flagged_dll;
        public static bool has_plugins;
        public static string Result_Suspicious;
        public static string Result_Malware;
        public static async Task Security_Scan(string var_path, bool escape_ApplicationOpenURL, bool escape_FileMangementSecure, bool escape_EventTrigger, bool escape_assetbundles)
        {
            flagged_cs = flagged_dll = has_plugins = false;
            Encoding encoding = Form1.encoding;
            Result_Suspicious = Result_Malware = string.Empty;
            await Task.Run(() =>
            {
                try
                {
                    var opts = new SharpCompress.Readers.ReaderOptions();
                    opts.ArchiveEncoding = new SharpCompress.Common.ArchiveEncoding();
                    opts.ArchiveEncoding.Default = Form1.encoding;
                    using (Stream stream = System.IO.File.Open(var_path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                    using (var reader = ReaderFactory.Open(stream, opts))
                        while (reader.MoveToNextEntry())
                        {
                            try
                            {

                                if (reader.Entry.Key.ToLower().EndsWith(".cs"))
                                {
                                    has_plugins = true;

                                    using (var streamReader = new StreamReader(reader.OpenEntryStream()))
                                    {
                                        string line;
                                        while ((line = streamReader.ReadLine()) != null)
                                        {
                                            //ignore comments
                                            if (line.Trim().StartsWith("//")) { goto done_Cs; }

                                            //split line by ;
                                            string[] line_array = line.Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries);
                                            foreach (string bb in line_array)
                                            {
                                                /********* Escaping *********/
                                                if (escape_ApplicationOpenURL == true)
                                                {
                                                    if (Regex.IsMatch(bb.Trim(), "Application\\.OpenURL\\(\"https://.*\\)") | Regex.IsMatch(bb.Trim(), "Application\\.OpenURL\\(@\"https:.*\\)")) { goto done_bb; }
                                                }
                                                if (escape_FileMangementSecure == true)
                                                {
                                                    List<string> FM_strings = new List<string> {
                                                    "FileManagerSecure", "FileManagementSecure", "DeleteDirectory", "DeleteDirectoryFromPlugin",
                                                    "MoveDirectory", "DeleteFile\\(", "MoveFile\\(", "MoveFileFromPlugin", "DeleteFileFromPlugin"
                                                };

                                                    foreach (string FM in FM_strings)
                                                    {
                                                        if (Regex.IsMatch(bb.Trim(), FM)) { goto done_bb; }
                                                    }
                                                }
                                                if (escape_EventTrigger == true)
                                                {
                                                    if (Regex.IsMatch(bb.Trim().ToLower(), "eventtrigger")) { goto done_bb; }
                                                }
                                                /********* Searching *********/
                                                foreach (string malware in malware_strings)
                                                {

                                                    if (Regex.IsMatch(bb, Regex.Escape(malware), RegexOptions.IgnoreCase))
                                                    {
                                                        Result_Malware += "[X] Warning Possible Malware Detected, Keyword: " + malware + Environment.NewLine
                                                                + "      ---> " + reader.Entry.Crc.ToString("X8") + "   " + System.IO.Path.GetFileName(var_path) + ":/" + reader.Entry.Key + Environment.NewLine
                                                                + "      ---> " + bb + Environment.NewLine;

                                                        flagged_cs = true;
                                                    }

                                                }

                                                foreach (string suspecious_string in suspecious_strings)
                                                {
                                                    if (Regex.IsMatch(bb, Regex.Escape(suspecious_string), RegexOptions.IgnoreCase))
                                                    {
                                                        Result_Suspicious += "[!] Possible Bad Behavior, Keyword: " + suspecious_string + Environment.NewLine +
                                                                "      ---> " + reader.Entry.Crc.ToString("X8") + "   " + System.IO.Path.GetFileName(var_path) + ":/" + reader.Entry.Key + Environment.NewLine
                                                              + "      ---> " + bb + Environment.NewLine;
                                                        flagged_cs = true;
                                                    }
                                                }
                                            done_bb:;
                                            }
                                        done_Cs:;
                                        }
                                    }

                                }

                                if (reader.Entry.Key.ToLower().EndsWith(".dll"))
                                {
                                    has_plugins = true;
                                    string dll_name = reader.Entry.Key.Substring(reader.Entry.Key.LastIndexOf("/") + 1);
                                    Result_Suspicious += "[!] " + System.IO.Path.GetFileName(var_path) + Environment.NewLine;
                                    Result_Suspicious += "      ---> [!] Var contains dll file: " + reader.Entry.Crc.ToString("X8") + "   " + System.IO.Path.GetFileName(var_path) + ":/" + reader.Entry.Key +
                                                         Environment.NewLine + "      ---> [!] Decompiling dll for further scan...." + Environment.NewLine +
                                                         "      ---> [!] Extracting dll to C:\\Windows\\Temp\\SharpVamTools" + Environment.NewLine;

                                    //Extracting dll to disk, in case Antivirus has an opinion ...
                                    reader.WriteEntryToDirectory(@"C:\Windows\temp\SharpVamTools\", new ExtractionOptions()
                                    {
                                        ExtractFullPath = false,
                                        Overwrite = true
                                    });


                                    CSharpDecompiler decompiler = new CSharpDecompiler(@"C:\Windows\temp\SharpVamTools\" + dll_name, new DecompilerSettings() { ThrowOnAssemblyResolveErrors = false });

                                    string decomiled_dll = decompiler.DecompileWholeModuleAsString();
                                    string[] decomiled_dll_lines = decomiled_dll.Split(new string[] { ";", "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                                    foreach (string line in decomiled_dll_lines)
                                    {
                                        /********* Escaping Start *********/
                                        if (escape_ApplicationOpenURL == true)
                                        {
                                            //Escape https only, http is a security risk, shouldn't be escaped
                                            if (Regex.IsMatch(line.Trim(), "Application\\.OpenURL\\(\"https://.*\\)") | Regex.IsMatch(line.Trim(), "Application\\.OpenURL\\(@\"https:.*\\)")) { goto done_dll; }
                                        }
                                        if (escape_FileMangementSecure == true)
                                        {
                                            List<string> FM_strings = new List<string> {
                                                    "FileManagerSecure", "FileManagementSecure", "DeleteDirectory", "DeleteDirectoryFromPlugin",
                                                    "MoveDirectory", "DeleteFile\\(", "MoveFile\\(", "MoveFileFromPlugin", "DeleteFileFromPlugin"
                                                };

                                            foreach (string FM in FM_strings)
                                            {
                                                if (Regex.IsMatch(line.Trim(), FM)) { goto done_dll; }
                                            }
                                        }
                                        if (escape_EventTrigger == true)
                                        {
                                            if (Regex.IsMatch(line.Trim().ToLower(), "eventtrigger")) { goto done_dll; }
                                        }

                                        if (line.Trim().StartsWith("//")) { goto done_dll; }
                                        /********* Escaping End *********/

                                        foreach (string malware in malware_strings)
                                        {

                                            if (Regex.IsMatch(line, Regex.Escape(malware), RegexOptions.IgnoreCase))
                                            {
                                                Result_Malware += "[X] " + System.IO.Path.GetFileName(var_path) + Environment.NewLine;
                                                Result_Malware += "      ---> [X] Warning Possible Malware Detected, Keyword: " + malware + Environment.NewLine
                                                        + "      ---> " + reader.Entry.Crc.ToString("X8") + "   " + System.IO.Path.GetFileName(var_path) + ":/" + reader.Entry.Key + Environment.NewLine
                                                        + "      ---> " + line + Environment.NewLine;

                                                flagged_cs = true;
                                            }

                                        }

                                        foreach (string suspecious_string in suspecious_strings)
                                        {
                                            if (Regex.IsMatch(line, Regex.Escape(suspecious_string), RegexOptions.IgnoreCase) && !Regex.IsMatch(line, "System.Reflection", RegexOptions.IgnoreCase))
                                            {
                                                Result_Suspicious += "      ---> [!] Possible Bad Behavior, Keyword: " + suspecious_string + Environment.NewLine +
                                                        "      ---> " + reader.Entry.Crc.ToString("X8") + "   " + System.IO.Path.GetFileName(var_path) + ":/" + reader.Entry.Key + Environment.NewLine
                                                      + "      ---> " + line + Environment.NewLine;
                                                flagged_cs = true;
                                            }
                                        }
                                    done_dll:;
                                    }

                                    Result_Suspicious += "      ---> [!] Searching database using CRC checksum...." + Environment.NewLine;
                                    using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\_Database.txt", encoding))
                                    {
                                        string line;
                                        while ((line = sr.ReadLine()) != null)
                                        {
                                            if (line.Contains(reader.Entry.Crc.ToString("X8")))
                                            {
                                                Result_Suspicious += "      ---> [+] dll match found in database: " + line + Environment.NewLine + Environment.NewLine;
                                                goto done;
                                            }
                                        }

                                        if (!sr.ReadToEnd().Contains(reader.Entry.Crc.ToString("X8")))
                                        {
                                            flagged_dll = true;
                                            Result_Suspicious += "      ---> [!] no dll match found in database, exercise caution." + Environment.NewLine;
                                        }

                                    }
                                done:;
                                    System.IO.File.Delete(@"C:\Windows\temp\SharpVamTools\" + dll_name);
                                }

                                if (reader.Entry.Key.ToLower().EndsWith(".assetbundle") && escape_assetbundles == false)
                                {
                                    Result_Suspicious += "[!] " + System.IO.Path.GetFileName(var_path) + Environment.NewLine;
                                    Result_Suspicious += "      ---> [!] Var contains assetbundle: " + reader.Entry.Crc.ToString("X8") + "   " + System.IO.Path.GetFileName(var_path) + ":/" + reader.Entry.Key + Environment.NewLine;
                                    Result_Suspicious += "      ---> [!] Scanning database using CRC checksum ..." + Environment.NewLine;
                                    using (StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "\\_Database.txt", encoding))
                                    {
                                        string line;
                                        while ((line = sr.ReadLine()) != null)
                                        {
                                            if (line.Contains(reader.Entry.Crc.ToString("X8")))
                                            {
                                                Result_Suspicious += "      ---> [+] assetbundle match found in database: " + line + Environment.NewLine + Environment.NewLine;
                                                goto done;
                                            }
                                        }

                                        if (!(sr.ReadToEnd().Contains(reader.Entry.Crc.ToString("X8"))))
                                        {
                                            //  flagged_dll = true;
                                            Result_Suspicious += "      ---> [!] No assetbundle match found in database." + Environment.NewLine;
                                        }

                                    }
                                done:;
                                }

                            }
                            catch (Exception ex) { Result_Malware += Environment.NewLine + ex.Message + Environment.NewLine; }
                        }


                    if (has_plugins == false)
                    {
                        //Result_Suspicious += "[+] " + System.IO.Path.GetFileName(var_path) + Environment.NewLine;
                        //Result_Suspicious += "      ---> Var does not contain any plugins" + Environment.NewLine;
                        Result_Suspicious += Environment.NewLine + "################## Var does not contain any plugins: " + System.IO.Path.GetFileName(var_path) + " ##################" + Environment.NewLine + Environment.NewLine;
                    }

                    if (has_plugins == true && flagged_dll == false && flagged_cs == false)
                    {
                        //Result_Suspicious += "[+] " + System.IO.Path.GetFileName(var_path) + Environment.NewLine;
                        //Result_Suspicious += "      ---> Var contains clean plugins" + Environment.NewLine;
                        Result_Suspicious += Environment.NewLine + "################## Var contains clean plugins: " + System.IO.Path.GetFileName(var_path) + " ##################" + Environment.NewLine + Environment.NewLine;
                    }

                    if (flagged_dll == true | flagged_cs == true)
                    {
                        Result_Suspicious += Environment.NewLine + "################## Var contains suspecious plugins: " + System.IO.Path.GetFileName(var_path) + " ##################" + Environment.NewLine + Environment.NewLine;
                    }
                    if (Result_Malware.Length > 0)
                    {
                        Result_Malware += Environment.NewLine + "################## Var contains possible malware: " + System.IO.Path.GetFileName(var_path) + " ##################" + Environment.NewLine + Environment.NewLine;
                    }
                    if (Result_Malware.Length == 0)
                    {
                        Result_Malware += "[+] Clean" + Environment.NewLine;
                    }

                }
                catch (Exception ex)
                {
                    Result_Malware += "Error While Scanning Var:" + System.IO.Path.GetFileName(var_path) + "" + ex.Message + Environment.NewLine;
                    System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Security Scan: " + var_path + "\r\n" + ex.Message);
                }
            });
        }
    }
}
