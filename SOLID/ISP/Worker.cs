using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{

    internal interface IPayable
    {
        void Pay();

    }
    internal interface IWorkable
    {
        void Work();

    }
    internal interface IEatable
    {
        void Eat();

    }
    public class OutSourceWorker : IWorkable, IPayable
    {
        public void Pay()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    internal class CompanyWorker : IWorkable, IPayable, IEatable
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Pay()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
