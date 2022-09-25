namespace AbstractFactory
{
    public class MacLaptopFactory : IComputerFactory
    {
        public IComputerType ComputerType()
        {
            return new Laptop();
        }
        public IBrand Brand()
        {
            return new Mac();
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
