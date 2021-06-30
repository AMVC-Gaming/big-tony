using System;
using System.Text;
using BigTony.Core;

namespace BigTony.Examples
{

    public class KillCommand : Command
    {

        public override string name
        {
            get
            {
                return "kill";
            }
        }

        public override byte[] Run(Span<string> args)
        {

            // Check if the option exists to close the server, if not, act like the command doesn't exist
            if (!SettingsParser.GetBoolParam("KILL_COMMAND")) return new byte[0];

            // Close the server
            Program.Close();

            // If the server is closing, we don't have enough time to send them a message
            return new byte[1] { 0x01 };

        }

    }
}