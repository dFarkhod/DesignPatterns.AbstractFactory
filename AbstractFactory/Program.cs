using AbstractFactory;
using System;

namespace VirtualDars.DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var staff = new Staff { FullName = "Rais Bobo", StaffType= Constants.StaffType.Permanent, RoleType = Constants.RoleType.Director};

            var factory = new StaffComputerFactory().Create(staff);
            staff.ComputerDetails = new StaffComputerProvider(factory).GetComputerDetails();
            Console.WriteLine($"Staff: {staff.FullName}, Computer details = {staff.ComputerDetails}");

            Console.ReadLine();           
            
            #region yana boshqa misol
            /*var customer = new Customer { FullName = "Mehmonjon Mijozbek", CategoryCode = "prf" };

            AccountAbstractFactory abstractFactory = AccountFactoryProvider.GetAccountAbstractFactory(customer.CategoryCode);

            if (abstractFactory == null)
            {
                Console.WriteLine($"{customer.CategoryCode} kodi ostida maxsulot mavjud emas.");
            }
            else
            {
                customer.Accounts.Add(abstractFactory.CreateSavingsAccount());
                customer.Accounts.Add(abstractFactory.CreateCurrentAccount());
            }*/
            #endregion
        }

    }
}
