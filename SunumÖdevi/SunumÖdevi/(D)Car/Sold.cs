using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunumÖdevi._D_Car
{
    public class Sold
    {
        private ICar car;
        public Sold(ICar car)
        {
            this.car = car;
        }

        public void Delivered()
        {
            car.Brand();
        }
    }
}
