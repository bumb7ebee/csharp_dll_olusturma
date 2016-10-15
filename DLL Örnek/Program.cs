using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futbol;

namespace DLL_Örnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Futbolcu Messi = new Futbolcu();
            Messi.setBilgi();
            Messi.getBilgi();
            Console.ReadKey();
        }
    }
}
