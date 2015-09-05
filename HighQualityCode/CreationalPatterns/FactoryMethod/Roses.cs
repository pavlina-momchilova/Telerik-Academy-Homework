namespace FactoryMethod
{
    public class Roses : Manufacturer
    {
        public override FlowersShop ManifactureFlowersShop()
        {
            var flower = new PinkRose { Country = "Bulgeran", YearOfSort = "1980" };
            return flower;
        }
    }
}
