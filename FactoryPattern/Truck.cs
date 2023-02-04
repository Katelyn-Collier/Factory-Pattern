using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Truck : IVehicle
    {
        public string Color { get; set; }
        public bool HasBed { get; set; }


        public void Drive()
        {
            Console.WriteLine("This is the truck you have built.");
        }
    }
}
