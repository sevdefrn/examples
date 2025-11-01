using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregatiton
{
    public class WashingMachine : IWashing, IElectricUsing
    {
        public void UseElectric()
        {
            Console.WriteLine("Washing Machine use electric...");
        }

        public void Washing()
        {
            Console.WriteLine("Washing Machine is wasing clotch...");
        }
    }
}
