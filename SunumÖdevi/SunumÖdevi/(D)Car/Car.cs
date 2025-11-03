using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunumÖdevi._D_Car
{
    public class Car : ICar
    {
        public void Brand()
        {
            Console.WriteLine("Brand -----> Mercedes-Benz");
        }

        public void Brand2()
        {
            Console.WriteLine("Brand -----> Fiat");
        }

        public void Brand3()
        {
            Console.WriteLine("Brand -----> Lamborghini");
        }

        public void Brand4()
        {
            Console.WriteLine("Brand -----> Maserati");
        }

        public void Brand5()
        {
            Console.WriteLine("Brand -----> Volkswogen");
        }
    }
}
