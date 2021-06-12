using System.Threading;
using System.Collections.Generic;

namespace BigTony.Core
{

    public static class SystemManager
    {

        public static List<Thread> threads = new List<Thread>();

        public static void Start()
        {

            foreach (Thread thread in threads)
            {

                thread.Start();

            }

        }

        public static void Join()
        {

            foreach (Thread thread in threads)
            {

                thread.Join();

            }

        }

        public static bool isRunning()
        {

            bool running = false;

            foreach (Thread thread in threads)
            {

                running |= thread.IsAlive;

            }

            return running;

        }

    }

}