namespace VirtualDars.DesignPatterns.AbstractFactory
{
    public class AccountFactoryProvider
    {
        public static AccountAbstractFactory GetAccountAbstractFactory(string categoryCode)
        {
            if (categoryCode.Contains("bsc"))
            {
                return new BasicAccountFactory();
            }
            else if (categoryCode.Contains("prf"))
            {
                return new PreferredAccountFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
