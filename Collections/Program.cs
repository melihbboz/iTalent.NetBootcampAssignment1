// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("-------------------ARRAYLIST---------------------------");

ArrayList arrayList = new ArrayList();
arrayList.Add("Metin"); 
arrayList.Add(12); 
arrayList.Add(8f); 
arrayList.Add(new string[]
    { "Ali", "Osman", "Hasan" }); 
Console.WriteLine(arrayList[0]);
Console.WriteLine(arrayList[1]);
Console.WriteLine(arrayList[2]);
Console.WriteLine((arrayList[3] as string[])[0]);
Console.WriteLine((arrayList[3] as string[])[1]);
Console.WriteLine((arrayList[3] as string[])[2]);


Console.WriteLine("----------------QUEUE------------------------------");



Queue queue = new Queue();
queue.Enqueue("Kalem");
queue.Enqueue("Kitap");
queue.Enqueue("Silgi");
Console.WriteLine("Kuyrukta " + queue.Count + " adet nesne var");
Console.WriteLine(queue.Dequeue());
Console.WriteLine("Kuyrukta " + queue.Count + " adet nesne var");
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.ReadKey();


Console.WriteLine("------------------LIST----------------------------");




List<string> countries = new List<string>();
countries.Add("Türkiye"); 
countries.Add("Azerbaycan");

countries.Add("Fransa");

countries.Add("Almanya");

countries.Add("Hollanda");

countries.Add("İspanya");

countries.Add("Şili");

countries.Remove("Almanya");
countries.RemoveAt(4); 
EkranaYaz(countries);
countries.Reverse(); 
EkranaYaz(countries);
countries.AddRange(new string[5]
{
        "Irak", "İran", "Pakistan", "Hindistan", "Çin"
}); 
EkranaYaz(countries);
countries.Insert(3, "Rusya");
EkranaYaz(countries);
string[] yeni_ulkeler = new string[]
    { "Norveç", "İsveç", "Danimarka" };
countries.InsertRange(5, yeni_ulkeler);
EkranaYaz(countries);
Console.WriteLine(countries.IndexOf("Türkiye"));




static void EkranaYaz(List<string> ulkeler)
{
    Console.Clear();
    foreach (var ulke in ulkeler)
        Console.WriteLine(ulke);
   
}


Console.WriteLine("----------------DICTIONARY------------------------------");


Dictionary<string, string> EmployeeList = new Dictionary<string, string>();
EmployeeList.Add("Melih Boz", "Programmer");
EmployeeList.Add("Hasan Kemer", "Project Manager");
EmployeeList.Add("Melek Kumar", "Architect");
EmployeeList.Add("Emrah Tosun", "Asst. Project Manager");
EmployeeList.Add("Deniz Çoğul", "Manager");
EmployeeList.Remove("Hasan Kemer");

foreach (var employee in EmployeeList)
    Console.WriteLine(employee);
