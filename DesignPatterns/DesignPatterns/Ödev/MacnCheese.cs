using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Ödev
{
    public class MacnCheese : ISiparis
    {
        private Logger _logger;
        private MacnCheese(Logger? log) => _logger = log;

        public void Hazırla()
        {
            Console.WriteLine("Mac'n'Cheese makarna şiparişiniz alındı.");
            Thread.Sleep(5000);
            _logger.Log("Mac'n'Cheeese makarnanız hazır :)");
        }
    }
}
