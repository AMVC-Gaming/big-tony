using System.Runtime.CompilerServices;
using System.Text;

namespace BigTony.Utility
{
    public static class String
    {

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string InsertLineBreaks(string input)
        {

            return InsertLineBreaks(input, 50, "\n");

        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string InsertLineBreaks(string input, int maxCount)
        {

            return InsertLineBreaks(input, maxCount, "\n");

        }

        public static string InsertLineBreaks(string input, int maxCount, string newLine)
        {

            StringBuilder output = new StringBuilder();
            string[] splitInput = input.Split(" ");
            int characterCount = 0;

            for (int i = 0; i < splitInput.Length; i++)
            {

                characterCount += splitInput[i].Length;

                if (characterCount > maxCount)
                {

                    output.Append(newLine);
                    characterCount = 0;

                }

                output.Append(splitInput[i]);
                output.Append(" ");

            }

            return output.ToString();

        }

    }
}
