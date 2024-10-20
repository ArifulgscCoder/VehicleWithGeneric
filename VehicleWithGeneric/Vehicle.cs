using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleWithGeneric
{
    public abstract class Vehicle
    {
        public abstract string Model { get; set; }
        public abstract int MakeYear { get; set; }
        public abstract string NumberOfGears { get; set; }
        public abstract int EngineCapacity { get; set; }
        public abstract VehicleType Type { get; set; }
        protected Vehicle()
        {
            
        }

        protected Vehicle(string model, int makeYear, string numberOfGears, int engineCapacity, VehicleType type)
        {
            Model = model;
            MakeYear = makeYear;
            NumberOfGears = numberOfGears;
            EngineCapacity = engineCapacity;
            Type = type;
        }

        public abstract void GetDetails();
    }
}
