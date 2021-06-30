using System;

namespace BigTony.Core
{

    public class Command
    {

        public virtual string name
        {
            get
            {
                return "Untitled Command";
            }
        }

        public virtual byte[] Run()
        {

            return new byte[0];

        }

        public virtual byte[] Run(Span<string> args)
        {

            return new byte[0];

        }

    }

}