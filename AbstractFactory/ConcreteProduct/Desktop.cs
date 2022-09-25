using static AbstractFactory.Constants;

namespace AbstractFactory
{
    internal class Desktop : IComputerType
    {
        public string GetComputerType()
        {
            return Constants.ComputerType.Desktop.ToString();
        }
    }
}
