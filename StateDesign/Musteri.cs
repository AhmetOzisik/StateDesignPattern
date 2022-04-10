using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesign
{
    public class Musteri
    {
        public string name;
        public Musteri(string name)
        {
            this.name = name;
            kargoDurum = new KargoyaVerildi();
        }

        private IKargoDurum kargoDurum { get; set; }
        public IKargoDurum _kargoDurum
        {
           
            set { kargoDurum = value; }
        }
        public void Do()
        {
            kargoDurum.MusteriyeHaberGonder(this);
        }
    }
}
