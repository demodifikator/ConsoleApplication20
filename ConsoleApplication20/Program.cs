using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication20
{
    class Program
    {
        struct Car
        {
            public string Name;
            public short Year;
            public double Capacity;
            public int Price;
            
            public Car(string Name, short Year, double Capacity, int Price)
            {
                this.Name = Name;
                this.Year = Year;
                this.Capacity = Capacity;
                this.Price = Price;
            }

            public override string ToString()
            {
                return String.Format($"{Name}\t{Year}\t{Capacity}\t{Price}");
            }
        }
        static void Main(string[] args)
        {
            Car car1 = new Car("Volvo", 1999, 2.5, 15000);
            Car car2 = new Car("Nissan", 2004, 3, 23000);
            Car car3 = new Car("Jeep", 2000, 4.3, 30000);
            Car car4 = new Car("Renault", 1997, 2.3, 13500);

            Console.WriteLine($"{car1}\n{car2}\n{car3}\n{car4}");
        }
    }
}
