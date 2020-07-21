namespace Main
{
    public interface IPerformer
    {
        void Invoke<T>(T commandData)
            where T : struct;
    }
}
