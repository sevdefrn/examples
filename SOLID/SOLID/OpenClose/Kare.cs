using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClose
{
    public class Kare : ISekil
    {
        public double kenar;
        public Kare(double k){ kenar = k; }
    public double Alan() => kenar * kenar;
    }

}
