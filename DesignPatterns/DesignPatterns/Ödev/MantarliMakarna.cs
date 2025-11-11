using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Ödev
{
    public class MantarliMakarna : ISiparis
    {
        private Logger _logger;

        public MantarliMakarna(Logger? log) => _logger = log;
        public void Hazırla()
        {
            Console.WriteLine("Mantarlı makarnanız şiparişiniz alındı.");
            Thread.Sleep(5000);
            _logger.Log("Mantarlı makarnanız hazır :)");
        }
    }
}
