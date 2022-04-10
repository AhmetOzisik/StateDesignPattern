using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri("Ahmet");
            musteri.Do();
            musteri.Do();
            musteri.Do();
            Console.ReadLine();
        }
    }
}
