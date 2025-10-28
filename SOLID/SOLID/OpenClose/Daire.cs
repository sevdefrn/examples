using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClose
{
    public class Daire : ISekil
    {
        public double YariCap;
        public Daire(double r) { YariCap = r;}

        public double Alan()
        {
            return (3.14 * YariCap * YariCap);
        }
    }
}
