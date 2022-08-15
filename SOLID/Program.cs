// See https://aka.ms/new-console-template for more information
using SOLID.OCP;

Console.WriteLine("--------------OCP example----------");

CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
customerManager.Add();

CustomerManager customerManager2 = new CustomerManager(new NhCustomerDal());
customerManager2.Add();





