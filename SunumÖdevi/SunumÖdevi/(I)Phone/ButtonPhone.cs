using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunumÖdevi.Phone
{
    public class ButtonPhone : ICharGe, IPhoneCall, IGames
    {
        public void Charge()
        {
            Console.WriteLine("The button phone works with a charger.");
        }

        public void Game()
        {
            Console.WriteLine("You can play games on the button phone.");
        }

        public void PhoneCall()
        {
            Console.WriteLine("The button phone can make calls.");
        }

    }
}
