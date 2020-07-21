using System;
using System.Collections.Generic;

namespace Main
{
    public class CommandPool : ICommandPool
    {
        private readonly Dictionary<Type, Type> _commands;

        public CommandPool()
        {
            _commands = new Dictionary<Type, Type>();
        }

        public void Register<TOne, TTwo>()
            where TOne : struct
            where TTwo : ICommand
        {
            if (_commands.ContainsKey(typeof(TOne)))
            {
                throw new ArgumentException("Command is already existed");
            }

            _commands.Add(typeof(TOne), typeof(TTwo));
        }

        public Type GetCommand<TOne>()
            where TOne : struct
        {
            if (_commands.ContainsKey(typeof(TOne)) == false)
            {
                throw new ArgumentException("Unknown command");
            }

            Type commandType = _commands[typeof(TOne)];
            return commandType;
        }
    }
}
