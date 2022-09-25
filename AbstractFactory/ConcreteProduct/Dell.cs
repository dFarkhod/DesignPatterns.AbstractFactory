namespace AbstractFactory
{
    public class Dell : IBrand
    {
        public string GetBrand()
        {
            return Constants.Brand.Dell.ToString();
        }
    }
}
