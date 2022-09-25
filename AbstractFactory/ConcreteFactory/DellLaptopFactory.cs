namespace AbstractFactory
{
    public class DellLaptopFactory : IComputerFactory
    {
        public IComputerType ComputerType()
        {
            return new Laptop();
        }

        public IBrand Brand()
        {
            return new Dell();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public IStorage Storage()
        {
            return new SSD();
        }
    }
}
