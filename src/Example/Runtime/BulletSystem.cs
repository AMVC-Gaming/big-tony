using BigTony.Core;
using BigTony.Utility;

namespace BigTony.Examples
{

    public class BulletSystem : BaseSystem<Bullet>
    {

        public override void OnUpdate()
        {

            for (int i = 0; i < entities.Count; i++)
            {

                float x = entities[i].position.x + entities[i].forward.x;
                float y = entities[i].position.y + entities[i].forward.y;
                float z = entities[i].position.z + entities[i].forward.z;

                entities[i] = new Bullet { position = new Vector3(x, y, z), forward = entities[i].forward };

            }

        }

    }

}