using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP
{
    public interface ICruiseControl
    {
        void CruiseControlActivate();
    }
    public abstract class Car
    {
        public abstract void OpenHeadlight();
    }
    public class Bmw : Car, ICruiseControl
    {
        public void CruiseControlActivate()
        {
            Console.WriteLine("Bmw Cruise Control activated successful");
        }

        public override void OpenHeadlight()
        {
            Console.WriteLine("Bmw Headlights opened");
        }
    }

    public class Fiat : Car
    {
        public override void OpenHeadlight()
        {
            Console.WriteLine("Fiat Headlights opened");
        }
    }


}
