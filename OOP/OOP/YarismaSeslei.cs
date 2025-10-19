using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public static class YarismaSeslei
    {
        public static void AlkısSesleri(int alkısSayısı , int beklmeSuresi)
        {
            Thread.Sleep(beklmeSuresi);
            for(int i=0; i<alkısSayısı; i++)
            {
                Console.Beep(800, 150);
            }
        }
    }
}
