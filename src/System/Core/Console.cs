using System;

namespace BigTony.Core
{

    public static class Console
    {

        private static int lastFrameRate = 0;
        private static int frameRate = 0;
        private static int lastTick = 0;

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

        public static void Log()
        {



        }

        public static void Log(string message)
        {

            System.Console.WriteLine(message);

        }

    }

}