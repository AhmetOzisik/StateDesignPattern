using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesign
{
    public class KargoDagıtımaCıktı : IKargoDurum
    {
        public override void MusteriyeHaberGonder(Musteri musteri)
        {
            Console.WriteLine("{0} adlı musterinin kargosu dagıtıma cikarilmistir." , musteri.name);
            musteri._kargoDurum = new KargoTeslimEdildi();
        }
    }
}
