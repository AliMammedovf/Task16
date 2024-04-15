using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Vehicle
    {
        public string Marka { get; set; }
        public string Model { get; set; }

        public int Year { get; set; }

        public Vehicle(string marka, string model, int year)
        {
            Marka = marka;
            Model = model;
            Year = year;
        }

        public Vehicle()
        {
            
        }

        public virtual string ShowInfo()
        {
            return $" Marka:{Marka}\n Model:{Model}\n Year:{Year}";
        }
    }
}
