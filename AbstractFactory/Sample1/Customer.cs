using System.Collections.Generic;

namespace VirtualDars.DesignPatterns.AbstractFactory
{
    public class Customer
    {
        public Customer()
        {
            Accounts = new List<IAccount>();
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public string CategoryCode { get; set; }
        public List<IAccount> Accounts { get; set; }
    }
}
