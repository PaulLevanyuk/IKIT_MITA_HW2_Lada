using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Car
    {
        public Car(string model, char category)
        {
            Model = model;
            Category = category;
            CarPassport=new CarPassport(this);
        }


        public readonly string Model;
        public Color Color { get; set; } = Color.Blue;
        public string CarNumber { get; private set; }
        public readonly char Category;
        public readonly CarPassport CarPassport;
        public void ChangeOwner(Driver driver, string carnumber)
        {
           
            driver.OwnCar(this);
            CarPassport.Owner = driver;
            CarNumber = carnumber;
        }
    }
}
