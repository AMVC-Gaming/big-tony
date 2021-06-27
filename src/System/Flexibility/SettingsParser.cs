using BigTony.Core;
using System.Collections.Generic;
using System.IO;

namespace BigTony.Flexibility
{

    public static class SettingsParser
    {

        /// <summary>
        /// The Dictionary that stores all of the Big Tony settings for the program during rumtime.
        /// </summary>
        private static Dictionary<string, string> settings = new Dictionary<string, string>() {
            { "HTTP_SERVER", "No" }
        };
        private static Dictionary<string, string> settingDescriptions = new Dictionary<string, string>() {
            { "HTTP_SERVER", "This option is to create an HTTP Server. Please note that to do this in the API, the option has to be enabled here." }
        };

        public static string InsertLineBreaks(string input, int maxCount, string newLine)
        {

            string output = "";
            string[] splitInput = input.Split(" ");
            int characterCount = 0;

            for (int i = 0; i < splitInput.Length; i++)
            {

                characterCount += splitInput[i].Length;

                if (characterCount > maxCount)
                {

                    output += newLine;
                    characterCount = 0;

                }

                output += splitInput[i] + " ";

            }

            return output;

        }

        public static string GenerateConfigFile()
        {

            string output = "";

            foreach (var item in settings)
            {

                output += "# " + InsertLineBreaks(settingDescriptions[item.Key], 60, "\n# ") + "\n";
                output += item.Key + " = " + settings[item.Key] + "\n";

            }

            return output;

        }

        /// <summary> 
        /// Set the value at the specified label. 
        /// </summary>
        /// <param name="label">The key or label for the data that needs to be set.</param>
        /// <param name="value">The value that the data will be set to.</param> 
        public static void SetParam(string label, string value)
        {

            settings[label] = value;

        }

        /// <summary>
        /// Get the value at a specified label.
        /// </summary>
        /// <param name="label">The label to get the data at.</param>
        /// <returns>The value at the specified label.</returns>
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

        /// <summary>
        /// This function is run whenever the program starts to setup the settings.
        /// </summary>
        /// <param name="args">The list of Command Line Arguments that are given by the user.</param>
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

        /// <summary>
        /// Parse a file's data as a Big Tony config file.
        /// </summary>
        /// <param name="data">The string data to be parsed.</param>
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