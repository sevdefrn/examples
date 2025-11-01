using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregatiton
{
    public class DeepFrezee : IElectricUsing, IFreezing
    {
        public void UseElectric()
        {
            Console.WriteLine("DeepFrezee is electric...");
        }

        public void Freezing()
        {
            Console.WriteLine("DeepFrezee is use frezeing...");
        }
    }
}
