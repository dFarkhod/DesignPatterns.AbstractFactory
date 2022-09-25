using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class StaffComputerProvider
    {
        IComputerFactory _iComputerFactory;
        public StaffComputerProvider(IComputerFactory iComputerFactory)
        {
            _iComputerFactory = iComputerFactory;
        }
        public string GetComputerDetails()
        {
            IComputerType computer = _iComputerFactory.ComputerType();
            IProcessor processor = _iComputerFactory.Processor();
            IStorage storage = _iComputerFactory.Storage();
            IBrand brand = _iComputerFactory.Brand();
            return $"Brand:{brand.GetBrand()}, Type:{computer.GetComputerType()}, CPU:{processor.GetProcessor()}, Storage:{storage.GetStorage()}.";
        }
    }
}
