using System;

namespace VirtualDars.DesignPatterns.AbstractFactory
{
    // konkret maxsulot
    public class PreferredSavingsAccount : ISavingsAccount
    {
        public PreferredSavingsAccount(string number)
        {
            Number = number;
            Console.WriteLine($"{this.GetType().Name} : {number}");
        }
        public string Number { get; set; }

    }

    // konkret maxsulot
    public class PreferredCurrentAccount : ICurrentAccount
    {
        public PreferredCurrentAccount(string number)
        {
            Number = number;
            Console.WriteLine($"{this.GetType().Name} : {number}");
        }
        public string Number { get; set; }
    }

    // konkret fabrika
    public class PreferredAccountFactory : AccountAbstractFactory
    {
        public override ISavingsAccount CreateSavingsAccount()
        {
            string acNo = "SA" + Random.Shared.Next(10000000, 99999999).ToString();
            return new PreferredSavingsAccount(acNo);
        }
        public override ICurrentAccount CreateCurrentAccount()
        {
            string acNo = "CA" + Random.Shared.Next(10000000, 99999999).ToString();
            return new PreferredCurrentAccount(acNo);
        }

    }
}
