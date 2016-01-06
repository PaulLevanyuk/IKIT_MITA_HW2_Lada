using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            var Car = new Car("Лада", 'D');
            Car.Color = Color.DarkRed;
            var Driver = new Driver(DateTime.Today, "Вольдемар", "BC");
            var CarPasport = new CarPassport(Car);
            if (Car.CarPassport.Owner != null)
                Console.WriteLine(Car.CarPassport.Owner.Name);
            else
            {
               Console.WriteLine("Нет владельца");
            }
         
            Car.ChangeOwner(Driver, "o777oo");
            Driver.Category += "D";
            Car.ChangeOwner(Driver, "o777oo");

            Console.WriteLine("CarNumber is {0}", Driver.Car.CarNumber);
            Console.WriteLine("Owner is {0}", Car.CarPassport.Owner.Name);


            Console.ReadKey();
        }
    }
}
