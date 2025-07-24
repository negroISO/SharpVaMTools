using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Sharp_VaM_Tools
{
    internal class Extract_Var_Names
    {
        public static List<string> dependencies = new List<string>();
        public static void Extract_json(string text)
        {
            /*********************
             * This method is used specifically with json/presets, if the line contains ":/" it will be bookmarked
             * then for each bookmarked line it removes everything before and after var name using regex
             * then it evaluates whether the extracted var name is valid or not using regex  
             *********************/

            List<string> bookmarked_lines = new List<string>();
            string[] lines = text.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string line in lines)
            {
                if (line.Contains(":/") && !line.Contains("SELF:/") && Regex.IsMatch(line, @"(\..*?\.[0-9]+:|\..*?\.latest:|\..*?\.min[0-9]+)")) { bookmarked_lines.Add(line); }
            }
            foreach (string line in bookmarked_lines)
            {
                string depenedency = Regex.Replace(line, "(.*: \"|:/.*)", string.Empty).Replace(".latest", string.Empty);
                if (Regex.IsMatch(depenedency, @"\..*?\.min[0-9]+"))
                {
                    depenedency = Regex.Replace(depenedency, ".min[0-9]+$", string.Empty);
                }
                string depenedency_fix1 = Regex.Replace(depenedency, ".*\"", string.Empty);
                if (!dependencies.Contains(depenedency_fix1) && !depenedency_fix1.Contains(":") && Regex.IsMatch(depenedency_fix1, @"\..*"))
                {
                    dependencies.Add(depenedency_fix1);
                }
            }
            dependencies.Sort();
        }
        public static void Extract_Var_names(string text, string ex_creators)
        {
            try
            {
                string[] lines = Regex.Replace(text, @"(\.min[0-9]+|\.latest)", ".latest\n").Split(new string[] { ".var", ".txt", ".jpg", ".jpeg", ".gif", ".png", ".zip", ".rar", ".7z", "\n", "http", " - ", ":", "<", ">", "/", ";", "=", @"\", "\"" }, StringSplitOptions.RemoveEmptyEntries);
                string[] Ex_creators = ex_creators.Split(new string[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in lines)
                {
                    // 1.1.1.1 | 1.1.1 | 1.00_3.00 | 1.string.1 (can't go higher than that, some crazy creators use just 123/141 as creator name)
                    var bad_matches = Regex.Match(line, @"([0-9]+\.+[0-9]+\.[0-9]+\.[0-9]+|[0-9]+\.[0-9]+\.[0-9]+|[0-9]+\.[0-9]+_+[0-9]+\.[0-9]+|(^[0-9]\..*\.[0-9]+))");
                    if (bad_matches.Success) { goto done; }

                    foreach (string ex_crerator in Ex_creators)
                    {
                        if (line.Contains(ex_crerator + "."))
                        {
                            string match_ex_creator = string.Empty;
                            if (Regex.IsMatch(line, @"\..*?\.[0-9]+"))
                            {
                                match_ex_creator = Regex.Match(line, ex_crerator + @"+\..*?\.[0-9]+").Value;
                            }
                            if (Regex.IsMatch(line, @"\..*?\.latest"))
                            {
                                match_ex_creator = Regex.Match(line, ex_crerator + @"+\..*?\.latest").Value.Replace(".latest", string.Empty);
                            }
                            //Remove "-" at the start of var name ~ common mistake on F95 (example: Luxury Satin Nightgown -DateKnight.Luxury_nightgown.1.var)
                            match_ex_creator = Regex.Replace(match_ex_creator, @"^-", string.Empty);
                            if (!dependencies.Contains(match_ex_creator)) { dependencies.Add(match_ex_creator); }
                            goto done;
                        }
                    }
                    string match = string.Empty;
                    if (Regex.IsMatch(line, @"([^\s]+\..*?\.[0-9]+)"))
                    {
                        match = Regex.Match(line, @"([^\s]+\..*?\.[0-9]+)").Value.Replace("&amp;", "&");
                    }
                    if (Regex.IsMatch(line, @"([^\s]+\..*?\.latest)"))
                    {
                        match = Regex.Match(line, @"([^\s]+\..*?\.latest)").Value.Replace("\"", string.Empty).Replace(".latest", string.Empty);
                    }

                    //Remove "-" at the start of var name ~ common mistake on F95 (example: Luxury Satin Nightgown -DateKnight.Luxury_nightgown.1.var)
                    match = Regex.Replace(match, @"^-", string.Empty);
                    if (!dependencies.Contains(match)) { dependencies.Add(match); }
                done:;

                }
                dependencies.Sort();
            }
            catch (Exception ex)
            {
                System.IO.File.AppendAllText("_Error_log.txt", "\r\n" + "========= (" + DateTime.Now + ") =========> Extract Var Name: " + "\r\n" + ex.Message + Environment.NewLine);
            }
        }
    }
}
