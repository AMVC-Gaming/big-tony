using BigTony.Core;
using BigTony.Utility;

namespace BigTony.Examples
{

    public class BulletSystem : BaseSystem<Bullet>
    {

        public override void Update()
        {

            foreach (Bullet bullet in entities)
            {

                bullet.position += bullet.forward * 0.4f;

            }

        }

    }

}