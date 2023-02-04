using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public IVehicle CreateVehicle(string userInput)
        {
            switch (userInput.ToLower())
            {
                case "car":
                    return new Car() { Color = "Silver", IsDrivebale = true };
                    break;
                case "truck":
                    return new Truck() { Color = "White", HasBed = true };
                    break;
                default:
                    break;

            }
        }
    }
}
