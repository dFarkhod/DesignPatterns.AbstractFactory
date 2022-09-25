namespace AbstractFactory
{
    public class MacDesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Mac();
        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public IComputerType ComputerType()
        {
            return new Desktop();
        }

        public IStorage Storage()
        {
            return new SSD();
        }
    }
}
