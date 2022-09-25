using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class LenovoDesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new Lenovo();
        }

        public IProcessor Processor()
        {
            return new I3();
        }

        public IComputerType ComputerType()
        {
            return new Desktop();
        }

        public IStorage Storage()
        {
            return new HDD();
        }
    }
}
