using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        public Driver(DateTime licenceDate, string name, string category)
        {
            LicenceDate = licenceDate;
            Name = name;
            Experience = DateTime.Now - licenceDate;
            Category = category;
        }
        public DateTime LicenceDate { get; }

        public readonly string Name;
        public TimeSpan Experience;
        public string Category;

        public void OwnCar(Car car)
        {
            bool categ = false;
            for (int i = 0; i < Category.Length; i++)
            {
                if (Category[i] == car.Category)
                    categ = true;
            }
            if (categ == false)
            {
                Console.WriteLine("Exception, no this category");
                
            }
            else
            {
                Car = car;
            }
        }
        public Car Car { get; private set; }
    }
}
