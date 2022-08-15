// See https://aka.ms/new-console-template for more information
using OOP.Encapsulation;
using OOP.Inheritance;
using OOP.Polymorphism;

Console.WriteLine("----------------Polymorphism example-------------");

JuniorDeveloperEmployee jr = new JuniorDeveloperEmployee(); 
jr.employeePayment();

jr.payment();

Console.WriteLine("----------------Inheritance example-------------");

Phone myPhone = new Phone();

myPhone.alarm();

Console.WriteLine(myPhone.brand + " " + myPhone.modelName);


Console.WriteLine("----------------Encapsulation example-------------");

User u = new User();

u.Name = "Melih Boz";

u.Location = "Adana";

Console.WriteLine("Name: " + u.Name);

Console.WriteLine("Location: " + u.Location);

