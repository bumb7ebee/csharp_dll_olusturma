using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futbol
{
    public class Futbolcu
    {
        private string ad;
        private string soyad;
        private int yas;
        private string takim;

        public void setBilgi()
        {
            Console.Write("Ad: ");
            ad = Console.ReadLine();
            Console.Write("Soyad: ");
            soyad = Console.ReadLine();
            Console.Write("Yaş: ");
            yas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Takım: ");
            takim = Console.ReadLine();
        }

        public void getBilgi()
        {
            Console.WriteLine();
            Console.WriteLine("************Futbolcu Bilgileri************");
            Console.WriteLine("Adı: "+ ad);
            Console.WriteLine("Soyad: "+ soyad);
            Console.WriteLine("Yaşı: "+ yas);
            Console.WriteLine("Takımı: "+ takim);
            Console.WriteLine("******************************************");
        }
    }
}
