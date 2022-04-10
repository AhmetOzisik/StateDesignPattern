using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesign
{
    public class KargoTeslimEdildi : IKargoDurum
    {
        public override void MusteriyeHaberGonder(Musteri musteri)
        {
            Console.WriteLine("{0} adlı musteriye kargo teslim edildi." , musteri.name);
        }
    }
}
