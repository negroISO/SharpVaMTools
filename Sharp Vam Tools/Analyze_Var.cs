using ImageMagick;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SharpCompress.Readers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Web.Script.Serialization;
using System.Web.UI.WebControls;

namespace Sharp_VaM_Tools
{
    internal class Analyze_Var
    {
        public static string Anal_CRC = string.Empty;
        public static string Anal_Warnings = string.Empty;
        public static void analyze_var(string var, bool Anal_metajson, bool Anal_LocalRef, bool Anal_DeserializeJson, bool Anal_Morphs, bool Anal_BloatedVar,
                                                   bool Anal_Plugins, bool Anal_ListVarsContent,
                                                   bool Anal_TamperedwithVar, bool Anal_NonVamImages, bool Anal_ExtractImagesExif, bool Anal_ImagesMISC
                                      )
        {
            try
            {
                Int32 morphs = 0;
                string Creators_Assets_Inside_Var = string.Empty;
                bool metaJson_Exists = false;
                bool NotPackagedByVam = false;
                bool HasPlugins = false;
                //Anal_CRC += var + Environment.NewLine;
                //Anal_CRC_All += var + Environment.NewLine;

                var opts = new SharpCompress.Readers.ReaderOptions();
                opts.ArchiveEncoding.Default = Form1.encoding;
                List<string> PreviewImages = new List<string>();

                using (Stream stream = System.IO.File.OpenRead(var))
                using (var reader = ReaderFactory.Open(stream, opts))
                {
                    if (Anal_NonVamImages == true)
                    {
                        while (reader.MoveToNextEntry())
                        {
                            if (Regex.IsMatch(reader.Entry.Key, "\\.(json|vap|vaj|assetbundle)$", RegexOptions.IgnoreCase))
                            {
                                PreviewImages.Add(reader.Entry.Key.Substring(0, reader.Entry.Key.LastIndexOf(".")) + ".jpg");
                            }
                        }
                    }
                }

                using (Stream stream = System.IO.File.OpenRead(var))
                using (var reader = ReaderFactory.Open(stream, opts))
                {
                    while (reader.MoveToNextEntry())
                    {

                        if (!reader.Entry.IsDirectory && Anal_ListVarsContent == true)
                        {
                            Anal_CRC += reader.Entry.Crc.ToString("X8") + "   " + reader.Entry.Key + Environment.NewLine;
                        }
                        if (reader.Entry.IsDirectory && reader.Entry.LastModifiedTime != null && Anal_TamperedwithVar == true)
                        {
                            NotPackagedByVam = true;
                        }
                        if ((Anal_ImagesMISC == true || Anal_NonVamImages == true || Anal_ExtractImagesExif == true) &&
                            (reader.Entry.Key.ToLower().EndsWith(".jpg") || reader.Entry.Key.ToLower().EndsWith(".jpeg") || reader.Entry.Key.ToLower().EndsWith(".png")))
                        {
                            var memoryStream = new MemoryStream();
                            using (var Imgstream = reader.OpenEntryStream())
                            {
                                Imgstream.CopyTo(memoryStream);
                            }

                            //JPEG
                            if (reader.Entry.Key.ToLower().EndsWith(".jpg") || reader.Entry.Key.ToLower().EndsWith(".jpeg"))
                            {

                                if (Anal_ExtractImagesExif == true)
                                {
                                    memoryStream.Seek(0, SeekOrigin.Begin);
                                    using (var magickImage = new MagickImage(memoryStream))
                                    {
                                        var profile = magickImage.GetExifProfile();
                                        if (profile != null)
                                        {
                                            foreach (var value in profile.Values)
                                            {
                                                Anal_Warnings += "[!] Warning, exif data found inside jpg image: " + value.Tag + ": " + value.ToString() + " ===> " + System.IO.Path.GetFileNameWithoutExtension(var) + ":/" + reader.Entry.Key + Environment.NewLine;
                                            }
                                        }
                                    }
                                }

                                if (Anal_ImagesMISC == true || Anal_NonVamImages == true)
                                {
                                    //streamReader + UTF8 is used intentionally
                                    memoryStream.Seek(0, SeekOrigin.Begin);
                                    using (var streamReader = new StreamReader(memoryStream))
                                    {
                                        byte[] content = System.Text.Encoding.UTF8.GetBytes(streamReader.ReadToEnd());
                                        bool CleanJpeg = false;
                                        if (Anal_ImagesMISC == true)
                                        {
                                            if (content[content.Length - 2] != 0xBF && content[content.Length - 1] != 0xBD)
                                            {
                                                Anal_Warnings += "[!] Warning, hidden info/file found in jpg image: " + System.IO.Path.GetFileNameWithoutExtension(var) + ":/" + reader.Entry.Key + Environment.NewLine;
                                            }
                                        }
                                        if (Anal_NonVamImages == true && PreviewImages.Contains(reader.Entry.Key))
                                        {

                                            for (var index = 69; index < 150; index++)
                                            {
                                                if (content[index] == 0x32 && content[index + 1] == 0x21 && content[index + 2] == 0x1C && content[index + 3] == 0x21 && content[index + 4] == 0x32)
                                                {
                                                    CleanJpeg = true;
                                                    break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            CleanJpeg = true;
                                        }
                                        if (CleanJpeg == false)
                                        {
                                            Anal_Warnings += "[!] Warning, jpg image tampered with | hidden watermark | non-vam: " + System.IO.Path.GetFileNameWithoutExtension(var) + ":/" + reader.Entry.Key + Environment.NewLine;
                                        }

                                    }
                                }
                            }

                            //Analzying PNG
                            if (reader.Entry.Key.ToLower().EndsWith(".png"))
                            {
                                if (Anal_ExtractImagesExif == true)
                                {
                                    memoryStream.Seek(0, SeekOrigin.Begin);
                                    using (var magickImage = new MagickImage(memoryStream))
                                    {
                                        var profile = magickImage.GetExifProfile();
                                        if (profile != null)
                                        {
                                            foreach (var value in profile.Values)
                                            {
                                                Anal_Warnings += "[!] Warning, exif data found inside jpg image: " + value.Tag + ": " + value.ToString() + " ===> " + System.IO.Path.GetFileNameWithoutExtension(var) + ":/" + reader.Entry.Key + Environment.NewLine;
                                            }
                                        }
                                    }
                                }

                                if (Anal_ImagesMISC == true)
                                {
                                    memoryStream.Seek(0, SeekOrigin.Begin);
                                    using (var streamReader = new StreamReader(memoryStream))
                                    {
                                        byte[] content = System.Text.Encoding.UTF8.GetBytes(streamReader.ReadToEnd());
                                        System.IO.File.WriteAllText("C:\\programdata\\1.png", BitConverter.ToString(content));
                                        if (content[content.Length - 1] != 0xBD && content[content.Length - 2] != 0xBF && content[content.Length - 3] != 0xEF && content[content.Length - 4] != 0x60 && content[content.Length - 5] != 0x42 &&
                                        content[content.Length - 6] != 0xBD && content[content.Length - 7] != 0xBF && content[content.Length - 8] != 0xEF && content[content.Length - 9] != 0x44 && content[content.Length - 10] != 0x4E &&
                                        content[content.Length - 11] != 0x45 && content[content.Length - 12] != 0x49)
                                        {

                                            Anal_Warnings += "[!] Warning, hidden info/file found in png image: " + System.IO.Path.GetFileNameWithoutExtension(var) + ":/" + reader.Entry.Key + Environment.NewLine;
                                        }
                                    }
                                }
                            }
                        }
                        if (Anal_TamperedwithVar == true && reader.Entry.Key.ToLower().EndsWith(".txt"))
                        {
                            Anal_Warnings += "[!] Warning, txt file found inside var (trackers?): " + System.IO.Path.GetFileNameWithoutExtension(var) + ":/" + reader.Entry.Key + Environment.NewLine;
                        }
                        if (Anal_Morphs == true && reader.Entry.Key.ToLower().EndsWith(".vmi"))
                        {
                            morphs++;
                        }
                        if (Anal_Morphs == true && reader.Entry.Key.ToLower().EndsWith(".vmi") && reader.Entry.Key.ToLower().Substring(reader.Entry.Key.ToLower().LastIndexOf("/") + 1).StartsWith("rg "))
                        {
                            Anal_Warnings += "[!] Warning var contains RG morph: " + System.IO.Path.GetFileNameWithoutExtension(var) + ":/" + reader.Entry.Key + Environment.NewLine;
                        }
                        if (Anal_Morphs == true && reader.Entry.Key.ToLower().EndsWith(".vmi") && reader.Entry.Key.ToLower().Substring(reader.Entry.Key.ToLower().LastIndexOf("/") + 1).StartsWith("pctrl"))
                        {
                            Anal_Warnings += "[!] Warning var contains pCTRL morph: " + System.IO.Path.GetFileNameWithoutExtension(var) + ":/" + reader.Entry.Key + Environment.NewLine;
                        }
                        if (Anal_Plugins == true && Regex.IsMatch(reader.Entry.Key, "\\.(dll|cs|cslist)$"))
                        {
                            HasPlugins = true;
                        }

                        if (reader.Entry.Key.ToLower().Equals("meta.json")) { metaJson_Exists = true; }
                        if (Anal_metajson == false && reader.Entry.Key.ToLower().Equals("meta.json")) { goto done; }
                        if (Anal_metajson == true && reader.Entry.Key.ToLower().Equals("meta.json"))
                        {
                            //parsing meta.json
                            string packageName_Actual = string.Empty;
                            string CreatorName_Actual = string.Empty;
                            string version = Regex.Match(var, "[0-9]+.var$").Value;
                            if (version == string.Empty)
                            {
                                version = "1.var";
                            }
                            bool hadReferenceIssues = false;
                            bool preloadMorphs = false;
                            string metajsonContent = string.Empty;
                            string[] var_name = System.IO.Path.GetFileName(var).Split(new string[] { "." }, StringSplitOptions.None);

                            using (var streamReader = new StreamReader(reader.OpenEntryStream()))
                            {
                                string line;
                                while ((line = streamReader.ReadLine()) != null)
                                {
                                    metajsonContent += line + Environment.NewLine;
                                    if (line.Contains("\"packageName\" : \""))
                                    {
                                        packageName_Actual = Regex.Replace(line, "(.*: \"|\",)", string.Empty);
                                    }
                                    if (line.Contains("\"creatorName\" : \""))
                                    {
                                        CreatorName_Actual = Regex.Replace(line, "(.*: \"|\",)", string.Empty);
                                    }
                                    if (line.Contains("\"hadReferenceIssues\" : \"true\""))
                                    {
                                        hadReferenceIssues = true;
                                    }
                                    if (line.Contains("\"preloadMorphs\" : \"true\""))
                                    {
                                        preloadMorphs = true;
                                    }
                                }

                            }
                            if (CreatorName_Actual.Trim().Length == 0)
                            {
                                Anal_Warnings += "[!] Warning, no creator name in meta.json: " + System.IO.Path.GetFileName(var) + Environment.NewLine;
                                CreatorName_Actual = var_name[0].Trim();
                            }

                            if (packageName_Actual.Trim().Length == 0)
                            {
                                Anal_Warnings += "[!] Warning, no package name in meta.json: " + System.IO.Path.GetFileName(var) + Environment.NewLine;
                                packageName_Actual = var_name[1].Trim();
                            }

                            if (!Regex.IsMatch(System.IO.Path.GetFileName(var), "\\..*?\\.[0-9]+.var"))
                            {
                                Anal_Warnings += "[!] Warning, var name does not follow the format creator.package.1.var: " + System.IO.Path.GetFileName(var) + Environment.NewLine;
                            }

                            //Trim(): some Chinese Vars have weird white space at the end
                            if (packageName_Actual.Replace("\"packageName\" : \"", "").Trim() != var_name[1].Trim() || (CreatorName_Actual.Replace("\"packageName\" : \"", "").Trim() != var_name[0].Trim().Replace(" ", "_")))
                            {
                                Anal_Warnings += "[!] Warning, mismatching var name: " + System.IO.Path.GetFileName(var) + "   --->   " + CreatorName_Actual.Trim().Replace("\"creatorName\" : \"", "") + "." + packageName_Actual.Replace("\"packageName\" : \"", "").Trim() + "." + version + Environment.NewLine;
                            }
                            if (hadReferenceIssues == true)
                            {
                                Anal_Warnings += "[!] Warning, var has reference issues: " + System.IO.Path.GetFileName(var) + Environment.NewLine;
                            }
                            if (preloadMorphs == true)
                            {
                                Anal_Warnings += "[!] Warning, preloadMorphs is set to true: " + System.IO.Path.GetFileName(var) + Environment.NewLine;
                            }
                            try

                            {
                                JavaScriptSerializer serializer = new JavaScriptSerializer();
                                serializer.DeserializeObject(metajsonContent);
                            }
                            catch
                            {
                                Anal_Warnings += "[!] Warning, bad meta.json, can't deserialize: " + System.IO.Path.GetFileName(var) + Environment.NewLine;
                            }

                            goto done;
                        }

                        if (Regex.IsMatch(reader.Entry.Key, "\\.(json|vaj|clothingplugins|vap|vam|vmi)$", RegexOptions.IgnoreCase))
                        {
                            if (Anal_DeserializeJson == true || Anal_LocalRef == true)
                            {
                                string jsonContent = string.Empty;
                                using (var streamReader = new StreamReader(reader.OpenEntryStream()))
                                {
                                    jsonContent = streamReader.ReadToEnd();
                                }

                                if (Anal_LocalRef == true)
                                {
                                    string[] lines = jsonContent.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                                    foreach (string line in lines)
                                    {
                                        if (line.Contains("\"Custom/") && !line.Contains("/MeshedVR/") && !line.Contains("/RenVR/") && !line.Contains("/VaMDeV/")
                                            && !line.Contains("/JulianBuzz.vam") && !line.Contains("/LeePompadour.vam") && !line.Contains("\"storePath\" : \"Custom/SubScene"))

                                        {
                                            Anal_Warnings += "[!] Warning, var uses local reference: " + System.IO.Path.GetFileName(var) + ":/" + reader.Entry.Key + Environment.NewLine
                                                + "[!] --> " + line + Environment.NewLine;
                                        }
                                    }
                                }

                                if (Anal_DeserializeJson == true)
                                {
                                    try
                                    {
                                        //Netwonsoft no longer used
                                        System.Text.Json.JsonSerializer.Deserialize<dynamic>(jsonContent);
                                    }
                                    catch
                                    {
                                        Anal_Warnings += "[!] Warning, can't deserialize (trackers?): " + System.IO.Path.GetFileName(var) + ":/" + reader.Entry.Key + Environment.NewLine;
                                    }
                                }

                                if (Anal_BloatedVar == true && reader.Entry.Key.ToLower().EndsWith(".vam"))
                                {
                                    string var_creator = System.IO.Path.GetFileName(var).Substring(0, System.IO.Path.GetFileName(var).IndexOf(".")).Trim();
                                    string creator_actual = string.Empty;
                                    string[] lines = jsonContent.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
                                    foreach (string line in lines)
                                    {
                                        if (line.Contains(" \"creatorName\""))
                                        {
                                            creator_actual = Regex.Replace(line, "(.*: \"|\".*)", string.Empty);
                                            if (var_creator.ToLower() != creator_actual.ToLower().Trim() && !Creators_Assets_Inside_Var.Contains(creator_actual.Trim()))
                                            {
                                                Creators_Assets_Inside_Var += creator_actual + ", ";
                                            }
                                            break;
                                        }
                                    }
                                }
                            }
                        }                           
                    done:;
                    }
                    if (morphs > 30)
                    {
                        Anal_Warnings += "[!] Warning, var has too many morphs: " + morphs + " morphs ===> " + System.IO.Path.GetFileName(var) + Environment.NewLine;
                    }
                    if (Creators_Assets_Inside_Var != string.Empty)
                    {
                        Anal_Warnings += "[!] Warning, var contains (clothes/hair) from the following creators: " + Creators_Assets_Inside_Var + " ===> " + System.IO.Path.GetFileName(var) + Environment.NewLine;
                    }
                    if (!metaJson_Exists)
                    {
                        Anal_Warnings += "[!] Warning, no meta.json inside var: " + System.IO.Path.GetFileName(var) + Environment.NewLine;
                    }
                    if (NotPackagedByVam == true)
                    {
                        Anal_Warnings += "[!] Warning, var has been modified, not packaged by vam or tampered with (trackers?): " + System.IO.Path.GetFileName(var) + Environment.NewLine;
                    }
                    if (HasPlugins == true)
                    {
                        Anal_Warnings += "[!] Warning, var contains plugin files (.cs/.dll), security scan is needed: " + System.IO.Path.GetFileName(var) + Environment.NewLine;
                    }
                }
            }
            catch (Exception ex)
            {
                Anal_Warnings += "[!] Warning: " + System.IO.Path.GetFileName(var) + "   ---> " + ex.Message + Environment.NewLine;
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Analyze var: " + var + "\r\n" + ex.Message + Environment.NewLine);
            }
        }
    }
}