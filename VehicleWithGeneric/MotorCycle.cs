using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleWithGeneric
{
    public sealed class MotorCycle<T> : TwoWheeler<T> where T : Vehicle
    {
        int maxPowerInBPH;
        double maxTorqueInNM;
        int mileageInKMPL;
        string frontBrake;
        string rearBrake;

        public int MaxPowerInBPH { get => maxPowerInBPH; set => maxPowerInBPH = value; }
        public double MaxTorqueInNM { get => maxTorqueInNM; set => maxTorqueInNM = value; }
        public int MileageInKMPL { get => mileageInKMPL; set => mileageInKMPL = value; }
        public string FrontBrake { get => frontBrake; set => frontBrake = value; }
        public string RearBrake { get => rearBrake; set => rearBrake = value; }

        public MotorCycle(string model, int makeYear, string numberOfGears, int engineCapacity, VehicleType type, int maxPowerInBPH, double maxTorqueInNM, int mileageInKMPL, string frontBrake, string rearBrake)
            : base(model, makeYear, numberOfGears, engineCapacity, type)
        {
            this.MaxPowerInBPH = maxPowerInBPH;
            this.MaxTorqueInNM = maxTorqueInNM;
            this.MileageInKMPL = mileageInKMPL;
            this.FrontBrake = frontBrake;
            this.RearBrake = rearBrake;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"Model No: {Model}" +
                $"\nMake Year: {MakeYear}" +
                $"\nNumber Of Gear: {NumberOfGears}" +
                $"\nEngine Capacity In CC: {EngineCapacity}" +
                $"\nVehicle Type: {VehicleType.Personal}" +
                $"\nMax Power In BPH: {MaxPowerInBPH}" +
                $"\nMax Torque In NM: {MaxTorqueInNM}" +
                $"\nMileage In KMPL: {MileageInKMPL}" +
                $"\nFront Brake: {FrontBrake}" +
                $"\nRear Brake: {RearBrake}");
        }
        public override void Start()
        {
            Console.WriteLine("Brahm.. Brahmmm");
        }
        public void Cooling()
        {
            Console.WriteLine("Cooling.......");
        }
    }
}
