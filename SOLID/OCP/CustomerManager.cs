using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OCP
{
    internal class CustomerManager
    {
        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add()
        {
            _customerDal.Add(); 
        }
    }

    class EfCustomerDal :ICustomerDal
    {
        public void Add()
        {
            //EF code
            Console.WriteLine("EF database'e eklendi");
        }
    }
    class NhCustomerDal : ICustomerDal
    {
        public void Add()
        {
            //EF code
            Console.WriteLine("Nh database'e eklendi");
        }
    }
    class DapperCustomerDal : ICustomerDal
    {
        public void Add()
        {
            //EF code
            Console.WriteLine("Dapper database'e eklendi");
        }
    }
    internal interface ICustomerDal
    {
        void Add();
    }
}
