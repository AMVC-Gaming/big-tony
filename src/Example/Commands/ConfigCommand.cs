using System;
using System.Text;
using BigTony.Core;

namespace BigTony.Examples
{

    public class ConfigCommand : Command
    {

        public override string name
        {
            get
            {
                return "config";
            }
        }

        public override byte[] Run(Span<string> args)
        {

            // Check if the option exists to close the server, if not, act like the command doesn't exist
            if (!SettingsParser.GetBoolParam("CONFIG_COMMAND")) return new byte[0];

            string stringOutput = SettingsParser.GenerateConfigFile();
            byte[] byteOutput = Encoding.ASCII.GetBytes("\u0001" + stringOutput);

            return byteOutput;

        }

    }
}