using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleWithGeneric
{
    public sealed class Car<T> : FourWheeler<T>
    {
        int numberOfSeat;
        int numberOfDoor;

        public int NumberOfSeat { get => numberOfSeat; set => numberOfSeat = value; }
        public int NumberOfDoor { get => numberOfDoor; set => numberOfDoor = value; }

        public Car(string model, int makeYear, string numberOfGears, int engineCapacity, VehicleType type, int numberOfSeat, int numberOfDoor)
            : base(model, makeYear, numberOfGears, engineCapacity, type)
        {
            this.numberOfSeat = numberOfSeat;
            this.numberOfDoor = numberOfDoor;
        }
        public override void GetDetails()
        {
            Console.WriteLine($"Model No: {Model}" +
                $"\nMake Year: {MakeYear}" +
                $"\nNumber Of Gear: {NumberOfGears}" +
                $"\nEngine Capacity In CC: {EngineCapacity}" +
                $"\nVehicle Type: {VehicleType.Rented}" +
                $"\nNumber Of Seat: {NumberOfSeat}" +
                $"\nNumber Of Door: {NumberOfDoor}");
        }
        public override void GetDesign()
        {
            Console.WriteLine("Good Design....");
        }
    }
}
