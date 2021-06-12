using System.Collections.Generic;

namespace BigTony.Core
{

    public class BaseSystem<T> where T : Entity
    {

        public static List<T> entities = new List<T>();

        public virtual void Register(T entity)
        {

            entities.Add(entity);

        }

        public virtual void Update()
        {

            foreach (T entity in entities)
            {

                // Do Things

            }

        }

    }

}