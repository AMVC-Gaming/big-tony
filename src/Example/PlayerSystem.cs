using BigTony.Core;

namespace BigTony.Examples
{

    public class PlayerSystem : BaseSystem<Player>
    {

        public override void Update()
        {

            foreach (Player player in entities)
            {

                if (player.playerName == player.playerName.ToUpper())
                {

                    player.playerName = player.playerName.ToLower();

                }
                else
                {

                    player.playerName = player.playerName.ToUpper();

                }

            }

            Console.Log("Tick");

        }

    }

}