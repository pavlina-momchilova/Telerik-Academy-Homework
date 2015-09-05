namespace LazyInitialization
{
    using System.Collections.Generic;

    public class MakeUpFactory
    {
        private readonly IDictionary<MakeUpObjectType, MakeUpObject> mackeUpList = new Dictionary<MakeUpObjectType, MakeUpObject>();

        public MakeUpObject GetMakeUpFactoryObject(MakeUpObjectType name)
        {
            MakeUpObject mascara;

            if (!this.mackeUpList.TryGetValue(name, out mascara))
            {
                mascara = new MakeUpObject { Name = name, Price = this.Price(name) };

                this.mackeUpList.Add(name, mascara);
            }

            return mascara;
        }

        private IList<double> Price(MakeUpObjectType name)
        {
            IList<double> price;

            switch (name)
            {
                case MakeUpObjectType.Volume:
                    price = this.MakeUpExpensiveList(1, 10);
                    break;
                case MakeUpObjectType.Length:
                    price = this.MakeUpExpensiveList(1, 20);
                    break;
                case MakeUpObjectType.Waterproof:
                    price = this.MakeUpExpensiveList(1, 30);
                    break;
                case MakeUpObjectType.VolumeAndLength:
                    price = this.MakeUpExpensiveList(1, 40);
                    break;
                default:
                    price = null;
                    break;
            }

            return price;
        }

        private IList<double> MakeUpExpensiveList(int start, int end)
        {
            IList<double> price = new List<double>();

            for (int i = 0; i < (end - start); i++)
            {
                price.Add(start + i);
            }

            return price;
        }
    }
}
