namespace AbstractFactory
{
    public class HDD : IStorage
    {
        public string GetStorage()
        {
            return Constants.Storage.HDD.ToString();
        }
    }
}
