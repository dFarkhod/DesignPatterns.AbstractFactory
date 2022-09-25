namespace VirtualDars.DesignPatterns.AbstractFactory
{
    // abstrakt fabrika
    public abstract class AccountAbstractFactory
    {
        public abstract ISavingsAccount CreateSavingsAccount();
        public abstract ICurrentAccount CreateCurrentAccount();
    }


    // abstrakt maxsulot
    public interface ISavingsAccount : IAccount 
    { 
    
    }

    // abstrakt maxsulot
    public interface ICurrentAccount : IAccount 
    { 
    
    }
    public interface IAccount
    {
        string Number { get; set; }
    }
    
}
