using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    internal class Product
    {
        public string brand = "Iphone";  
        public void alarm()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzz");
        }
    }

    class Phone: Product
    {
        public string modelName = "13 pro max";  
    }
}
