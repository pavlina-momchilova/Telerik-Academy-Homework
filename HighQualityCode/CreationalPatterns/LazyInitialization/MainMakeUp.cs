namespace LazyInitialization
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MainMakeUp
    {
        public static void Main()
        {
            var mascaraForVolume = new MakeUpFactory();
            var list = mascaraForVolume.GetMakeUpFactoryObject(MakeUpObjectType.Volume);
            Console.WriteLine(list.Price.Count);
        }
    }
}
