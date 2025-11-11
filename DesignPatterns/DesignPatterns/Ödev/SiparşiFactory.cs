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
            switch (name)
            {

                case "zeytinli":
                    return new ZeytinliMakarna();
                case "mantarlı":
                    return new MantarliMakarna();
                case "körili":
                    return new KoriliMakarna();
                case "macnCheese":
                    return new MacnCheese();
                case "közlü":
                    return new KozluMakarna();
                default:
                    throw new Exception("Bilinmeyen makarna çeşiti.");
            }
        }
    }
}
