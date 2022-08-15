using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP
{
    internal class CustomerManager
    {
        public void TransactionalOperation()
        {
            

            Insert();

            Update();
        }

        
        public void Insert()
        {
            MyContext context = new MyContext();
            context.Save();
        }
        public void Update()
        {
            MyContext context = new MyContext();
            context.Update();
        }
    }

    class PersonManager
    {
        public void Add()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Insert();
        }
    }
    internal class MyContext
    {
        public MyContext()
        {
        }

        internal void Save()
        {
            Console.WriteLine("Kaydedildi.");
        }

        internal void Update()
        {
            Console.WriteLine("Güncellendi");
        }
    }
}
