using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    public class Daire : ISekil
    {
        public void Ciz()
        {
            Console.WriteLine("----> Daire çizildi.");
        }
    }
}
