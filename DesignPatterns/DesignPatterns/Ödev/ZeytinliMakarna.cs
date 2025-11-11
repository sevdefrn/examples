using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Ödev
{
    public class ZeytinliMakarna : ISiparis
    {
        private Logger _logger;
        public ZeytinliMakarna(Logger? log) => _logger = log;
        public void Hazırla()
        {
            Console.WriteLine("Zeytinli makarna siparişiniz alındı.");
            Thread.Sleep(5000);
            _logger.Log("Zeytinli makarnanız hazır :)");

        }
    }
}
