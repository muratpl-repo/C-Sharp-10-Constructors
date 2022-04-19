using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51DersConstructorMetotu //Constructor metodu, obje ilk olusturuldugunda otomatik olarak cagrilir..

{

    class Insan
    {
        string isim;
        int yas;

        public Insan()
        {
            Console.WriteLine("Yeni bir obje yaratıldı...");
        }
        public Insan(string isim)
        {
            this.isim = isim;
        }
        public Insan(string isim, int yas) //Ayni zamanda Constuctor metota overloading yapabiliyoruz.
        {
            this.isim = isim;
            this.yas = yas;
        }
        public void bilgileriSoyle()
        {
            Console.WriteLine("Adım {0}, yasim {1}", isim, yas);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Insan i1 = new Insan();
            Insan i2 = new Insan("Muhammet Murat Pala");
            Insan i3 = new Insan("Muhammet Murat Pala", 26);

            i1.bilgileriSoyle();
            i2.bilgileriSoyle();
            i3.bilgileriSoyle();
        }
    }
}
