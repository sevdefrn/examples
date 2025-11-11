using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Ödev
{
    public class KoriliMakarna : ISiparis
    {
        private Logger _logger;
        private KoriliMakarna(Logger? log) => _logger = log;

        public void Hazırla()
        {
            Console.WriteLine("Körili makarna şiparişinizi alındı.");
            Thread.Sleep(5000);
            _logger.Log("Körüli makarnanız hazır :)");
        }
    }
}
