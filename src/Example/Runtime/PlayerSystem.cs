using BigTony.Core;

namespace BigTony.Examples
{

    public class PlayerSystem : BaseSystem<Player>
    {

        public override void OnUpdate()
        {

            for (int i = 0; i < entities.Count; i++)
            {

                if (entities[i].playerName.StartsWith("S"))
                {

                    entities[i] = new Player { playerName = entities[i].playerName.ToLower() };

                }
                else
                {

                    entities[i] = new Player { playerName = entities[i].playerName.ToUpper() };

                }


            }

        }

    }

}