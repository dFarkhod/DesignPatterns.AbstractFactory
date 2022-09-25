namespace AbstractFactory
{
    public class SSD : IStorage
    {
        public string GetStorage()
        {
            return Constants.Storage.SSD.ToString();
        }
    }
}
