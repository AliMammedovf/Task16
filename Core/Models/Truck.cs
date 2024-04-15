using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Truck: Vehicle
    {

        public int CarryingCapacity { get; set; }

        public Truck(string marka, string model, int year, int carryingcapacity) : base(marka, model, year)
        {
            CarryingCapacity = carryingcapacity;
        }

        public Truck()
        {
            
        }

        public override string ShowInfo()
        {
            return $" CarryingCapacity:{CarryingCapacity}";
        }

    }
}
