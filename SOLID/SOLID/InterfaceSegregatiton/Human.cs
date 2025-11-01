using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregatiton
{
    public class Human : ITalking, IWorking
    {
        public void Talk()
        {
            Console.WriteLine("Human is talking...");
        }

        public void Work()
        {
            Console.WriteLine("Human is working...");
        }
    }
}
