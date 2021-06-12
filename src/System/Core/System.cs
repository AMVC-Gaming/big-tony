using System.Collections.Generic;

namespace BigTony.Core
{

    public class BaseSystem<T> where T : Entity
    {

        public static List<T> entities = new List<T>();

        /// <summary>
        /// Adds an entity into the system.
        /// </summary>
        /// <param name="entity">The entity to be added into the system.</param>
        public virtual void Register(T entity)
        {

            entities.Add(entity);

        }

        /// <summary>
        /// This is run every frame by the server.
        /// </summary>
        public virtual void Update()
        {

            foreach (T entity in entities)
            {

                // Do Things

            }

        }

    }

}