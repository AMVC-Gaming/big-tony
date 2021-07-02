using System.Collections.Generic;

namespace BigTony.Core
{

    public class BaseSystem<T> : ISystem where T : struct
    {

        public static List<T> entities = new List<T>();

        /// <summary>
        /// Adds an entity into the system.
        /// </summary>
        /// <param name="entity">The entity to be added into the system.</param>
        public void Register(T entity)
        {

            entities.Add(entity);

        }

        /// <summary>
        /// Removes an entity from the system.
        /// </summary>
        /// <param name="entity">The entity to be removed from the system.</param>
        public void Unregister(T entity)
        {

            entities.Remove(entity);

        }

        /// <summary>
        /// Get a segment of the entity list from 'start' until the end of the entities list. 
        /// </summary>
        /// <param name="start">The start of the query.</param>
        /// <returns>A list filled with entities between the range 'start' and end of the entities list.</returns>
        public List<T> Slice(int start)
        {

            return entities.GetRange(start, entities.Count - start);

        }

        /// <summary>
        /// Get a segment of the entity list from the 'start' index until the 'end' index. 
        /// </summary>
        /// <param name="start">The start of the query.</param>
        /// <param name="end">The end of the query.</param> 
        /// <returns>A list filled with entities between the range 'start' and 'end'.</returns>
        public List<T> Slice(int start, int end)
        {

            return entities.GetRange(start, end - start);

        }

        /// <summary>
        /// Removes the top entity from the stack and returns it.
        /// </summary>
        /// <returns>The top entity on the stack.</returns>
        public T Pop()
        {

            T entity = entities[entities.Count - 1];
            entities.Remove(entity);
            return entity;

        }

        /// <summary>
        /// Removes the bottom entity from the stack and returns it.
        /// </summary>
        /// <returns>The bottom entity on the stack.</returns>
        public T Shift()
        {

            T entity = entities[0];
            entities.Remove(entity);
            return entity;

        }

        /// <summary>
        /// Returns the top entity from the stack.
        /// </summary>
        /// <returns>The top entity on the stack.</returns>
        public T Top()
        {

            return entities[entities.Count - 1];

        }

        /// <summary>
        /// Returns the bottom entity from the stack.
        /// </summary>
        /// <returns>The bottom entity on the stack.</returns>
        public T Bottom()
        {

            return entities[0];

        }

        /// <summary>
        /// Get the number of entities currently in the system. 
        /// </summary>
        /// <returns>The integer representation of the number of entities in the system.</returns>
        public int GetEntityCount()
        {

            return entities.Count;

        }

        /// <summary>
        /// This is run when a new entity is created.
        /// </summary>
        public virtual void OnRegister()
        {



        }

        /// <summary>
        /// This is run when a new entity is created.
        /// </summary>
        public virtual void OnUnregister()
        {



        }

        /// <summary>
        /// This is run every frame by the server.
        /// </summary>
        public virtual void OnUpdate()
        {

            foreach (T entity in entities)
            {

                // Do Things

            }

        }

    }

}