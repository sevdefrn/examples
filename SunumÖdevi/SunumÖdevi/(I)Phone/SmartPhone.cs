using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SunumÖdevi.Phone
{
    public class SmartPhone : IGames, ICharGe, IPhoneCall, ITouchscreen
    {
        public void Charge()
        {
            Console.WriteLine("The smart phone works with a charger.");
        }

        public void Game()
        {
            Console.WriteLine("You can play games on the smart phone.");
        }

        public void PhoneCall()
        {
            Console.WriteLine("The smart phone can make calls.");
        }

        public void Touchscreen()
        {
            Console.WriteLine("The smartphone has a touchscreen.");
        }
    }
}
