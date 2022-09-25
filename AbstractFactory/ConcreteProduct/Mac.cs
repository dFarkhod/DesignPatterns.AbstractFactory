namespace AbstractFactory
{
    public class Mac : IBrand
    {
        public string GetBrand()
        {
            return Constants.Brand.Mac.ToString();
        }
    }
}
