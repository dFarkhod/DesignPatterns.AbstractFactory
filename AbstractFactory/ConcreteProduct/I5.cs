namespace AbstractFactory
{
    public class I5 : IProcessor
    {
        public string GetProcessor()
        {
            return Constants.Processor.i5.ToString();
        }
    }
}
