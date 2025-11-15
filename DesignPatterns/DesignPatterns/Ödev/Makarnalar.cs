using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Ödev
{
    public class ZeytinliMakarna : ISiparis
    {
        public void Hazırla()
        {
            Logger logger = Logger.GetBildirim();
            Console.WriteLine("Zeytinli makarna siparişiniz alındı.");
            Thread.Sleep(5000);
            logger.Log("Zeytinli makarnanız hazır :)");
        }
    }
    public class MantarliMakarna : ISiparis
    {
        public Logger _logger;

        public MantarliMakarna(Logger? log) => _logger = log;
        public void Hazırla()
        {
            Console.WriteLine("Mantarlı makarnanız şiparişiniz alındı.");
            Thread.Sleep(5000);
            _logger.Log("Mantarlı makarnanız hazır :)");
        }
    }

    public class KoriliMakarna : ISiparis
    {
        public Logger _logger;
        public KoriliMakarna(Logger? log) => _logger = log;

        public void Hazırla()
        {
            Console.WriteLine("Körili makarna şiparişinizi alındı.");
            Thread.Sleep(5000);
            _logger.Log("Körüli makarnanız hazır :)");
        }
    }

    public class MacnCheese : ISiparis
    {
        public Logger _logger;
        public MacnCheese(Logger? log) => _logger = log;

        public void Hazırla()
        {
            Console.WriteLine("Mac'n'Cheese makarna şiparişiniz alındı.");
            Thread.Sleep(5000);
            _logger.Log("Mac'n'Cheeese makarnanız hazır :)");
        }
    }

    public class KozluMakarna : ISiparis
    {
        public Logger _logger;
        public KozluMakarna(Logger? log) => _logger = log;

        public void Hazırla()
        {
            Console.WriteLine("Közlü makarna şipariniz alındı.");
            Thread.Sleep(5000);
            _logger.Log("Közlü makarnanızz hazır :)");
        }
    }
}
