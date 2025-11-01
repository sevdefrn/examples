using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.InterfaceSegregatiton
{
    public interface ITalking
    {
        void Talk();
    }
    public interface IWorking
    {
        void Work();
    }
    public interface IFlying
    {
        void Fly();
    }
}
