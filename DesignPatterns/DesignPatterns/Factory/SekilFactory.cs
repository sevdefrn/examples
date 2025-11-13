//using DesignPatterns.Singleton;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DesignPatterns.Factory
//{
//    public class SekilFactory
//    {
//        public static ISekil GetSekil(string name)
//        {
//            var logger = Logger.GetInstance();
//            switch (name)
//            {
//                case "daire":
//                    return new Daire();
//                case "kare":
//                    return new Kare();
//                default:
//                    throw new Exception("Bilinmeyen şekil.");
//            }
//        }
//    }
//}
