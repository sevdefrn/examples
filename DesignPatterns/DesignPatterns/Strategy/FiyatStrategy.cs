using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class FiyatStrategy
    {
        public IIndirim strateji;
        public decimal Hesapla(decimal tutar) => strateji.Hesapla(tutar);
    }
}
