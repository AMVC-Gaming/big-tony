using BigTony.Core;
using System.Threading;

namespace BigTony.Examples
{

    public class FPSGame : Game
    {

        static void Main(string[] args)
        {

            PlayerSystem playerSystem = new PlayerSystem();
            PlayerSystem bulletSystem = new PlayerSystem();

            SystemManager.threads.Add(new Thread(() =>
            {

                while (true)
                {

                    playerSystem.Update();

                }

            }));
            SystemManager.threads.Add(new Thread(() =>
            {

                while (true)
                {

                    bulletSystem.Update();

                }

            }));

            SystemManager.Start();

            while (SystemManager.isRunning())
            {

                Console.CalculateFrameRate();

            }

        }

    }

}