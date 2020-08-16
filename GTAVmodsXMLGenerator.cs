using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace GTAVmodsXMLgenerator
{
    static class GTAVmodsXMLGenerator
    {
        public static List<string> ConsoleRead()
        {
            try
            {
                string modeName = "mod";
                List<string> Mods = new List<string>();
                Regex rule = new Regex(@"^[a-zA-Z0-9]");

                Console.WriteLine("Enter list of mode-packs names. Enter empty line to generate xml murkup");
                while (modeName != "" || modeName != "\n")
                {
                    modeName = Console.ReadLine();
                    if (modeName == "")
                        break;
                    if (!rule.IsMatch(modeName))
                    {
                        Console.WriteLine("Mode name is wrong, enter name again");
                    }

                    Mods.Add(modeName);
                }
                return Mods;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        private static void Generate()
        {
            try
            {
                string modeName = "mod";
                List<string> Mods = new List<string>();
                StringBuilder firstPartstringBuilder = new StringBuilder();
                StringBuilder secondPartstringBuilder = new StringBuilder();
                Regex rule = new Regex(@"^[a-zA-Z0-9]");

                Console.WriteLine("Enter list of mode-packs names. Enter empty line to generate xml murkup");
                while (modeName != "" || modeName != "\n")
                {
                    modeName = Console.ReadLine();
                    if (modeName == "")
                        break;
                    if (!rule.IsMatch(modeName))
                    {
                        Console.WriteLine("Mode name is wrong, enter name again");
                    }

                    Mods.Add(modeName);
                }
                foreach (string mod in Mods)
                {
                    firstPartstringBuilder.AppendLine($"<item>dlcpacks:/{mod}/</item>");

                    secondPartstringBuilder.AppendLine("<Item type=\"SExtraTitleUpdateMount\">");
                    secondPartstringBuilder.AppendLine($"\t<deviceName>dlc_{mod}:/</deviceName>");
                    secondPartstringBuilder.AppendLine($"\t<path>update:/dlc_patch/{mod}/</path>");
                    secondPartstringBuilder.AppendLine($"</Item>");
                }
                firstPartstringBuilder.AppendLine("");
                string result = firstPartstringBuilder.ToString() + secondPartstringBuilder.ToString();
                Console.Write(result);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static string GetXMLmurkupToString(List<string> mods)
        {
            try
            {
                List<string> Mods = mods;
                StringBuilder firstPartstringBuilder = new StringBuilder();
                StringBuilder secondPartstringBuilder = new StringBuilder();
                Regex rule = new Regex(@"^[a-zA-Z0-9]");

                foreach (string mod in Mods)
                {
                    if (!rule.IsMatch(mod))
                    {
                        Console.WriteLine($"Mode name={mod} is wrong. It was omited.");
                        continue;
                    }

                    firstPartstringBuilder.AppendLine($"<item>dlcpacks:/{mod}/</item>");

                    secondPartstringBuilder.AppendLine("<Item type=\"SExtraTitleUpdateMount\">");
                    secondPartstringBuilder.AppendLine($"\t<deviceName>dlc_{mod}:/</deviceName>");
                    secondPartstringBuilder.AppendLine($"\t<path>update:/dlc_patch/{mod}/</path>");
                    secondPartstringBuilder.AppendLine($"</Item>");
                }
                firstPartstringBuilder.AppendLine("");
                string result = firstPartstringBuilder.ToString() + secondPartstringBuilder.ToString();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static string GetDlcListXMLmurkupToString(List<string> mods)
        {
            try
            {
                List<string> Mods = mods;
                StringBuilder firstPartstringBuilder = new StringBuilder();
                Regex rule = new Regex(@"^[a-zA-Z0-9]");

                foreach (string mod in Mods)
                {
                    if (!rule.IsMatch(mod))
                    {
                        Console.WriteLine($"Mode name={mod} is wrong. It was omited.");
                        continue;
                    }

                    firstPartstringBuilder.AppendLine($"<item>dlcpacks:/{mod}/</item>");
                }
                firstPartstringBuilder.AppendLine("");
                string result = firstPartstringBuilder.ToString();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static string GetExtraTitleUpdateMountXMLmurkupToString(List<string> mods)
        {
            try
            {
                List<string> Mods = mods;
                StringBuilder secondPartstringBuilder = new StringBuilder();
                Regex rule = new Regex(@"^[a-zA-Z0-9]");

                foreach (string mod in Mods)
                {
                    if (!rule.IsMatch(mod))
                    {
                        Console.WriteLine($"Mode name={mod} is wrong. It was omited.");
                        continue;
                    }

                    secondPartstringBuilder.AppendLine("<Item type=\"SExtraTitleUpdateMount\">");
                    secondPartstringBuilder.AppendLine($"\t<deviceName>dlc_{mod}:/</deviceName>");
                    secondPartstringBuilder.AppendLine($"\t<path>update:/dlc_patch/{mod}/</path>");
                    secondPartstringBuilder.AppendLine($"</Item>");
                }
                string result = secondPartstringBuilder.ToString();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
