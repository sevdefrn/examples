using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods.oop
{
    public class Ogrenci
    {
        private string ApiKey = " ";
        private string ApiSecret = " ";
        private decimal maas = 0;
        public string a1
        {
            get { return ApiKey; }
            set { ApiKey = value; }
        }
        public string a2
        {
            get { return ApiSecret; }
            set { ApiSecret = value; }
        }
        public decimal harcama
        {
            get { return maas; }
            set { maas = value; }

        }
    }
}
