using System;

namespace Main
{
    public class PrintTextCommand :
        Command<PrintText>,
        ICommand
    {
        public PrintTextCommand(PrintText data) : base(data)
        {
        }

        public void Execute()
        {
            Console.WriteLine(_data.Text);
        }
    }
}
