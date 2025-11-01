using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.DependencyInversion
{
    public class MessageService : IMessageService
    {
        public void Send()
        {
            Console.WriteLine("Send ------> 1");
        }

        public void Send2()
        {
            Console.WriteLine("Send ------> 2");
        }

        public void Send3()
        {
            Console.WriteLine("Send ------> 3");
        }

        public void Send4()
        {
            Console.WriteLine("Send ------> 4");
        }

        public void Send5()
        {
            Console.WriteLine("Send ------> 5");
        }

        public void Send6()
        {
            Console.WriteLine("Send ------> 6");
        }

        public void Send7()
        {
            Console.WriteLine("Send ------> 7");
        }

        public void Send8()
        {
            Console.WriteLine("Send ------> 8");
        }
    }
}
