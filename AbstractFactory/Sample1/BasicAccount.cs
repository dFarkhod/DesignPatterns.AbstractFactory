using System;

namespace VirtualDars.DesignPatterns.AbstractFactory
{
    // konkret maxsulot
    public class BasicSavingsAccount : ISavingsAccount
    {
        public BasicSavingsAccount(string number)
        {
            Number = number;
            Console.WriteLine($"{this.GetType().Name} : {number}");
        }

        public string Number { get; set; }
    }


    // konkret maxsulot
    public class BasicCurrentAccount : ICurrentAccount
    {
        public BasicCurrentAccount(string number)
        {
            Number = number;
            Console.WriteLine($"{this.GetType().Name} : {number}");
        }

        public string Number { get; set; }
    }


    // konkret fabrika
    public class BasicAccountFactory : AccountAbstractFactory
    {
      
        public override ISavingsAccount CreateSavingsAccount()
        {
            string acNo = "SA" + Random.Shared.Next(10000000, 99999999).ToString();
            return new BasicSavingsAccount(acNo);
        }

        public override ICurrentAccount CreateCurrentAccount()
        {
            string acNo = "CA" + Random.Shared.Next(10000000, 99999990).ToString();
            return new BasicCurrentAccount(acNo);
        }
    }
}
