using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Car: Vehicle
    {

        public int PassengerCapacity { get; set; }

        public Car(string marka, string model, int year, int passengercapacity) : base(marka, model, year)
        {
            PassengerCapacity = passengercapacity;
        }

        public Car()
        {
            
        }

        public override string ShowInfo()
        {
            return $" PassengerCapacity:{PassengerCapacity}";
        }


    }
}
