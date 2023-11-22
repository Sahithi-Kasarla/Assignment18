using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone("Samsung Galaxy");
            smartphone.Connect();
            smartphone.Charge(60);
            string smartphoneInfo = smartphone.Display();
            Console.WriteLine("Smartphone Information: " + smartphoneInfo);

            Console.WriteLine();

            Laptop laptop = new Laptop("HP");
            laptop.Connect();
            laptop.Charge(90);
            string laptopInfo = laptop.Display();
            Console.WriteLine("Laptop Information: " + laptopInfo);
            Console.ReadKey();
        }
    }
}
