using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregatiton
{
    public interface IElectricUsing
    {
        void UseElectric();
    }

    public interface IFreezing
    {
        void Freezing();
    }
    public interface IWashing
    {
        void Washing();
    }
}
