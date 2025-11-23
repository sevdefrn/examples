using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Logger
    {
        private static Logger instance;
        private Logger() { }
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
        public void Log(string message)
        {
            Console.WriteLine($"Log----->{message}");
        }
    }
}
