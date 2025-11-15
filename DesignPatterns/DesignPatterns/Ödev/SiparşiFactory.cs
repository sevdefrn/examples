using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Ödev
{
    public class SiparisFactory
    {
        public static ISiparis GetSiparis(string name)
        {
            var logger = Logger.GetBildirim();
            switch (name)
            {
                case "zeytinli":
                    return new ZeytinliMakarna();
                case "mantarlı":
                    return new MantarliMakarna(logger);
                case "körili":
                    return new KoriliMakarna(logger);
                case "macnCheese":
                    return new MacnCheese(logger);
                case "közlü":
                    return new KozluMakarna(logger);
                default:
                    throw new Exception("Bilinmeyen makarna çeşiti.");
                    break;
            }
        }
    }
}
