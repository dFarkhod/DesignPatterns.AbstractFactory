using static AbstractFactory.Constants;

namespace AbstractFactory
{
    public class Laptop : IComputerType
    {
        public string GetComputerType()
        {
            return ComputerType.Laptop.ToString();
        }
    }
}
