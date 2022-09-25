namespace AbstractFactory
{
    internal class Lenovo : IBrand
    {
        public string GetBrand()
        {
            return Constants.Brand.Lenovo.ToString();
        }
    }
}
