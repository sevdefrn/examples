using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunumÖdevi._Open_Close_PaymentSystem
{
    public class Cart : IPaymentSystem
    {
        public double Fee;
        public Cart(double f)
        {
            Fee = f;
        }

        public double Payment() => 20 + Fee;

    }
}
