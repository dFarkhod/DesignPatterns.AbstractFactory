using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IComputerFactory
    {
        IComputerType ComputerType();
        IProcessor Processor();
        IStorage Storage();
        IBrand Brand();
    }
}
