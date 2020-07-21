using System;

namespace Main
{
    public class PerformerFactory
    {
        private class Performer : IPerformer
        {
            private readonly ICommandPool _commandPool;

            public Performer(ICommandPool commandPool)
            {
                _commandPool = commandPool;
            }

            public void Invoke<T>(T commandData) where T : struct
            {
                Type commandType = _commandPool.GetCommand<T>();
                object commandObject = Activator.CreateInstance(commandType, commandData);
                if (commandObject is ICommand command)
                {
                    command.Execute();
                }
            }
        }

        private static PerformerFactory _instance;
        public static PerformerFactory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PerformerFactory();
                }

                return _instance;
            }
        }

        public IPerformer Create(ICommandPool commandPool)
            => new Performer(commandPool);
    }
}