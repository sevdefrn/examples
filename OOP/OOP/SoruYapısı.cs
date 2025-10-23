using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class SoruYapısı : Soru
    {
        public string Metin { get; set; } 
        public string[] Seceneklar { get; set; }
        public char DogruCevap { get; set; }
   
    }

}

