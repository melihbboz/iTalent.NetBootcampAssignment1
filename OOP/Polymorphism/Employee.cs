using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    abstract class Employee
    {
        public abstract void employeePayment();

        public void payment()
        {
            Console.WriteLine("7500");
        }
    }

    class JuniorDeveloperEmployee : Employee
    {
        public override void employeePayment()
        {
            Console.WriteLine("12000");
        }
    }
}
