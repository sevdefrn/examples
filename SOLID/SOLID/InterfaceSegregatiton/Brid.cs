using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregatiton
{


    public class Brid : ITalking, IWorking, IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Brid is flying...");
        }

        public void Talk()
        {
            Console.WriteLine("Brid is talking...");
        }

        public void Work()
        {
            Console.WriteLine("Brid is working...");
        }
    }
}
