namespace AbstractFactory
{
    public class I7 : IProcessor
    {
        public string GetProcessor()
        {
            return Constants.Processor.i7.ToString();
        }
    }
}
