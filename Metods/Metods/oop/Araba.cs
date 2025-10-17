using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods.oop
{
    public class Araba
    {
        //Yıkıcı METOD (Consturctor)
        public Araba(string marka)
        {
            Console.WriteLine($"Yapıcı metod çalıştı.Araç{marka}");
        }

        ~Araba()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Yıkıcı metod (finalizer) çalıştı!");
            Console.ResetColor();
        }
    }
}





