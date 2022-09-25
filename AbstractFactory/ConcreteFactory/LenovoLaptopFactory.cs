using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class LenovoLaptopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Lenovo();
        }

        public IProcessor Processor()
        {
            return new I5();
        }

        public IComputerType ComputerType()
        {
            return new Laptop();
        }

        public IStorage Storage()
        {
            return new HDD();
        }
    }
}
