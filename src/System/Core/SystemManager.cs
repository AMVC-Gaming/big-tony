using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BigTony.Core
{

    public static class SystemManager
    {

        public static ISystem[] systems;

        public static void FindSystems()
        {

            Type parentType = typeof(ISystem);
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();

            IEnumerable<Type> subclasses = types.Where(t => t.IsSubclassOf(parentType));
            List<ISystem> systemList = new List<ISystem>();

            Console.Log("Systems Loading... ", false);

            foreach (Type type in subclasses)
            {

                if (!type.ContainsGenericParameters)
                {
                    ISystem system = (ISystem)Activator.CreateInstance(type);
                    systemList.Add(system);

                }

            }

            Console.Log("Done");

            systems = systemList.ToArray<ISystem>();

        }

    }

}