using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LiskovSubstitution
{
    public class Penguen: Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Penguen not flying...Because, penguen is short of wings...");
        }

    }
}
