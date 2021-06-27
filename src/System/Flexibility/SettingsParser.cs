using BigTony.Core;
using System.Collections.Generic;
using System.IO;

namespace BigTony.Flexibility
{

    public static class SettingsParser
    {

        public static Dictionary<string, string> settings = new Dictionary<string, string>();

        public static void SetParam(string label, string value)
        {

            settings[label] = value;

        }

        public static string GetParam(string label)
        {

            return settings[label];

        }

        /// <summary>
        /// Print all of the current settings in the system. 
        /// </summary>
        /// <para>This includes the default settings that have not been set by the user.</para>
        public static void PrintSettings()
        {

            foreach (var item in settings)
            {

                Console.Log(item.Key + ": " + item.Value);

            }

        }

        /// <summary>
        /// Open and parse a Big Tony settings file.
        /// </summary>
        /// <para>This function opens up the file of the specified path and then parses 
        /// it using the 'ParseString' fuction. This file needs to be formatted using the 
        /// Settings File Markup. This means that comments start with a hashtag, and only
        /// lines that contain data on them are parsed. The data needs to be formatted as 
        /// 'KEY = VALUE'. An example of this would be, 'HTTP_SERVER = NO'.</para>
        /// <param name="path">The relative or absolute path to the settings file.</param>
        public static void ParseFile(string path)
        {

            string fileData = File.ReadAllText(path);
            ParseString(fileData);

        }

        public static void SetParams(string[] args)
        {

            for (int i = 0; i < args.Length; i++)
            {

                // If it doesn't start with a --, then it probably isn't a parameter
                if (args[i].Trim().StartsWith("--"))
                {

                    string[] argumentParts = args[i].Trim().Split("=");
                    if (argumentParts.Length == 2)
                    {

                        settings[argumentParts[0].Substring(2).Trim()] = argumentParts[1].Trim();

                    }

                }

            }

        }

        public static void ParseString(string data)
        {

            string[] splitData = data.Split("\n");

            for (int i = 0; i < splitData.Length; i++)
            {

                string currentLine = splitData[i].Trim();

                if (!currentLine.StartsWith("#") && currentLine.Length > 0)
                {

                    string[] items = currentLine.Split("=");

                    if (items.Length == 2) settings[items[0].Trim()] = items[1].Trim();

                }

            }

        }

    }

}