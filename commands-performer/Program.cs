namespace Main
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ICommandPool commandPool = new CommandPool();
            commandPool.Register<PrintHello, PrintHelloCommand>();
            commandPool.Register<Summarize, SummarizeCommand>();
            commandPool.Register<PrintText, PrintTextCommand>();

            PerformerFactory factory = PerformerFactory.Instance;
            IPerformer performer = factory.Create(commandPool);

            performer.Invoke(new PrintHello());
            performer.Invoke(new Summarize());
            performer.Invoke(new PrintText("Print this text, pls! c:"));
        }
    }
}
