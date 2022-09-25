namespace AbstractFactory
{
    public class I3 : IProcessor
    {
        public string GetProcessor()
        {
            return Constants.Processor.i3.ToString();
        }
    }
}
