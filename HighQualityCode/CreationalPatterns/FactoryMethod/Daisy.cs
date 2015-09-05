namespace FactoryMethod
{
    public class Daisy : Manufacturer
    {
        public override FlowersShop ManifactureFlowersShop()
        {
            var flower = new WhiteDaisy { Country = "USA", YearOfSort = "2000" };
            return flower;
        }
    }
}
