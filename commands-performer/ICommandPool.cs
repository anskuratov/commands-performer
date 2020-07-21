using System;

namespace Main
{
    public interface ICommandPool
    {
        void Register<TOne, TTwo>()
            where TOne : struct
            where TTwo : ICommand;

        Type GetCommand<TOne>()
            where TOne : struct;
    }
}
