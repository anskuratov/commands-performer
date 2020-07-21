using System;

namespace Main
{
    public class PrintHelloCommand :
        Command<PrintHello>,
        ICommand
    {
        public PrintHelloCommand(PrintHello data) : base(data)
        {
        }

        public void Execute()
        {
            Console.WriteLine("Hello world!");
        }
    }
}
