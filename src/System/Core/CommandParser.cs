using System;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BigTony.Core
{

    public class CommandParser
    {

        public static Command[] commands;

        public static void FindCommands()
        {

            Type parentType = typeof(Command);
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();

            IEnumerable<Type> subclasses = types.Where(t => t.IsSubclassOf(parentType));
            List<Command> commandList = new List<Command>();

            Console.Log("Commands Loading... ", false);

            foreach (Type type in subclasses)
            {

                Command command = (Command)Activator.CreateInstance(type);
                commandList.Add(command);

            }

            commands = commandList.ToArray<Command>();

            Console.Log("Done");

        }

        public static byte[] RunCommand(string command, Span<string> args)
        {

            for (int i = 0; i < commands.Length; i++)
            {

                if (commands[i].name.ToUpper().Equals(command.ToUpper()))
                {

                    return commands[i].Run(args);

                }

            }

            return new byte[0];

        }

    }

}