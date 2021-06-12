using BigTony.Core;
using System.Threading;

namespace BigTony.Examples
{

    public class FPSGame : Game
    {

        PlayerSystem playerSystem = new PlayerSystem();
        BulletSystem bulletSystem = new BulletSystem();

        static void Main(string[] args)
        {

            FPSGame game = new FPSGame();

            game.Start();

            Console.Log("Starting Game...");

            while (true)
            {

                game.Update();
                Console.CalculateFrameRate();

            }

        }

        public override void Start()
        {

            // Setup Players

            Player[] players = new Player[1000];

            for (int i = 0; i < players.Length; i++)
            {

                players[i] = new Player();
                players[i].playerName += " #" + (i + 1);
                playerSystem.Register(players[i]);

            }

            // Setup Bullets

            Bullet[] bullets = new Bullet[10000];

            for (int i = 0; i < bullets.Length; i++)
            {

                bullets[i] = new Bullet();
                bulletSystem.Register(bullets[i]);

            }

        }

        public override void Update()
        {

            // Thread playerSystemThread = new Thread(playerSystem.Update);
            // Thread bulletSystemThread = new Thread(bulletSystem.Update);

            // playerSystemThread.Start();
            // bulletSystemThread.Start();

            // playerSystemThread.Join();
            // bulletSystemThread.Join();

            playerSystem.Update();
            bulletSystem.Update();

        }

    }

}