using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Ödev
{
    //public class ZeytinliMakarna : ISiparis
    //{
    //    private Logger _logger;
    //    private ZeytinliMakarna(Logger? log) => _logger = log;
    //    public void Hazırla()
    //    {
    //        Console.WriteLine("Zeytinli makarna siparişiniz alındı.");
    //        Thread.Sleep(5000);
    //        _logger.Log("Zeytinli makarnanız hazır :)");

    //    }
    //}
    //public class MantarliMakarna : ISiparis
    //{
    //    private Logger _logger;

    //    public MantarliMakarna(Logger? log) => _logger = log;
    //    public void Hazırla()
    //    {
    //        Console.WriteLine("Mantarlı makarnanız şiparişiniz alındı.");
    //        Thread.Sleep(5000);
    //        _logger.Log("Mantarlı makarnanız hazır :)");
    //    }
    //}

    //public class KoriliMakarna : ISiparis
    //{
    //    private Logger _logger;
    //    private KoriliMakarna(Logger? log) => _logger = log;

    //    public void Hazırla()
    //    {
    //        Console.WriteLine("Körili makarna şiparişinizi alındı.");
    //        Thread.Sleep(5000);
    //        _logger.Log("Körüli makarnanız hazır :)");
    //    }
    //}

    //public class MacnCheese : ISiparis
    //{
    //    private Logger _logger;
    //    private MacnCheese(Logger? log) => _logger = log;

    //    public void Hazırla()
    //    {
    //        Console.WriteLine("Mac'n'Cheese makarna şiparişiniz alındı.");
    //        Thread.Sleep(5000);
    //        _logger.Log("Mac'n'Cheeese makarnanız hazır :)");
    //    }
    //}

    public class KozluMakarna : ISiparis
    {
        private Logger _logger;
        private KozluMakarna(Logger? log) => _logger = log;

        public void Hazırla()
        {
            Console.WriteLine("Közlü makarna şipariniz alındı.");
            Thread.Sleep(5000);
            _logger.Log("Közlü makarnanızz hazır :)");
        }
    }
}
