namespace AbstractFactory
{
    public class DellDesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Dell();
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
