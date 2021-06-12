using System;

namespace BigTony.Core
{

    public static class Console
    {

        private static int lastFrameRate = 0;
        private static int frameRate = 0;
        private static int lastTick = 0;

        /// <summary>
        /// Calculates the framerate and logs it to the console every second. 
        /// 
        /// <b>Note:</b> This function should only be run once every frame (if run more than once, the framerate will not be real).
        /// </summary>
        /// <returns>The current framerate of the program.</returns>
        public static int CalculateFrameRate()
        {
            if (System.Environment.TickCount - lastTick >= 1000)
            {
                lastFrameRate = frameRate;
                frameRate = 0;
                lastTick = System.Environment.TickCount;
                Console.Log("Current FPS: " + lastFrameRate);
            }

            frameRate++;
            return lastFrameRate;
        }

        /// <summary>
        /// Blankly log to the console.
        /// </summary>
        public static void Log()
        {

            System.Console.WriteLine();

        }

        /// <summary>
        /// Logs an integer to the console.
        /// </summary>
        /// <param name="number">The integer to be logged.</param>
        public static void Log(int number)
        {

            System.Console.WriteLine(number);

        }

        /// <summary>
        /// Logs any object to the console.
        /// </summary>
        /// <param name="any">The object to be logged.</param>
        public static void Log(object any)
        {

            System.Console.WriteLine(any.ToString());

        }

        /// <summary>
        /// Logs a message to the console.
        /// </summary>
        /// <param name="message">The string message to be logged to the console.</param>
        public static void Log(string message)
        {

            System.Console.WriteLine(message);

        }

    }

}