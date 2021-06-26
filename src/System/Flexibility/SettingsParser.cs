using BigTony.Core;
using System.Collections.Generic;
using System.IO;

namespace BigTony.Flexibility
{

    public static class SettingsParser
    {

        public static Dictionary<string, string> settings = new Dictionary<string, string>();

        public static void PrintSettings()
        {

            foreach (var item in settings)
            {

                Console.Log(item.Key + ": " + item.Value);

            }

        }

        public static void ParseFile(string path)
        {

            string fileData = File.ReadAllText(path);
            ParseString(fileData);

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