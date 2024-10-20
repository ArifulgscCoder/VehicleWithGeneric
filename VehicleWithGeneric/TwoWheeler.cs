using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleWithGeneric
{
    public class TwoWheeler<T> : Vehicle,IExteriorDesign<T> where T : Vehicle
    {
        public TwoWheeler(string model, int makeYear, string numberOfGears, int engineCapacity, VehicleType type)
            : base(model, makeYear, numberOfGears, engineCapacity, type)
        {
        }

        public override string Model { get; set; }
        public override int MakeYear { get; set; }
        public override string NumberOfGears { get; set; }
        public override int EngineCapacity { get; set; }
        public override VehicleType Type { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("abstract method overridden in two wheeler");
        }

        public string[] GetExteriorDesigns(string data)
        {
            string[] designs = data.Split(',');
            return designs;
        }

        public virtual void Start()
        {
            Console.WriteLine("I'm in virtual method");
        }
    }
}
