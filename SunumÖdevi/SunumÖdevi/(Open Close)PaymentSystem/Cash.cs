using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunumÖdevi._Open_Close_PaymentSystem
{
    public class Cash : IPaymentSystem
    {
        public double Fee;
        public Cash(double f)
        {
            Fee = f;
        }

        public double Payment() => 20 + Fee;
    }
}
