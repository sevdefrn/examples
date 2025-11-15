using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class Yuzde10 : IIndirim
    {
        public decimal Hesapla(decimal tutar) => tutar * 0.9m;
    }
    public class Yuzde20 : IIndirim
    {
        public decimal Hesapla(decimal tutar) => tutar * 0.8m;
    }
}
