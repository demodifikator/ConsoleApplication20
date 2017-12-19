using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
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
            Car[] cars = new Car[5];
            cars[0] = new Car("Volvo", 1999, 2.5, 15000);
            cars[1] = new Car("Nissan", 2004, 3, 23000);
            cars[2] = new Car("Jeep", 2000, 4.3, 30000);
            cars[3] = new Car("Renault", 1997, 2.3, 13500);
            cars[4] = new Car();
            Console.Write("Вводите данные о машине:\nНазвание:");
            cars[4].Name = Console.ReadLine();
            Console.Write("Год выпуска: ");
            cars[4].Year = short.Parse(Console.ReadLine());
            Console.Write("Объем бака: ");
            cars[4].Capacity = double.Parse(Console.ReadLine());
            Console.Write("Цена: ");
            cars[4].Price = int.Parse(Console.ReadLine());

            Console.WriteLine("Название\tГод\tОбъем бака\tЦена");
            Car tmp;
            for (int i = 0; i < cars.Length-1; i++)
            {
                for (int j = 0; j < cars.Length; j++)
                {
                    if (cars[i].Price > cars[i+1].Price)
                    {
                        tmp = cars[i];
                        cars[i] = cars[i + 1];
                        cars[i + 1] = tmp;
                    }
                }
            }

            for (int i = 0; i < cars.Length; i++)
                Console.WriteLine(cars[i]);
        }
    }
}
