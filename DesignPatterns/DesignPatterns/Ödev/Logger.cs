using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Ödev
{
    public class Logger
    {
        private static Logger bildirim;
        private Logger() { }
        public static Logger GetBildirim()
        {
            if (bildirim == null)
            {
                bildirim = new Logger();
            }
            return bildirim;
        }
        public void Log(string message)
        {
            Console.WriteLine($"Bildirim:{message}");
        }
    }
}
