namespace FactoryMethod
{
    using System.Text;

    public abstract class FlowersShop
    {
        public string Country { get; set; }

        public string YearOfSort { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            var flowerAsString = new StringBuilder();
            flowerAsString.AppendFormat("Flower name: {0}", this.Name);
            flowerAsString.AppendLine();
            flowerAsString.AppendFormat("Country: {0}", this.Country);
            flowerAsString.AppendLine();
            flowerAsString.AppendFormat("Year of flower sort: {0}", this.YearOfSort);
            flowerAsString.AppendLine();

            return flowerAsString.ToString();
        }
    }
}
