using System;

namespace Main
{
    public class SummarizeCommand :
        Command<Summarize>,
        ICommand
    {
        public SummarizeCommand(Summarize data) : base(data)
        {
        }

        public void Execute()
        {
            Console.WriteLine("Input 1st integer:");
            string input = Console.ReadLine();

            int firstNumber;
            if (int.TryParse(input, out firstNumber) == false)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Console.WriteLine("Input 2nd integer:");
            input = Console.ReadLine();

            int secondNumber;
            if (int.TryParse(input, out secondNumber) == false)
            {
                Console.WriteLine("Incorrect input");
                return;
            }

            Console.WriteLine("Summarize operation result: {0} + {1} = {2}",
                firstNumber, secondNumber, firstNumber + secondNumber);
        }
    }
}
