using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VehicleWithGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                DoTask();
			}
			catch (Exception ex)
			{

                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }

        private static void DoTask()
        {
            Console.WriteLine("How many operation would you like to perform?");
            int count=Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<count; i++)
            {
                Console.WriteLine("Enter type of operation\nHint: TwoWheeler -1\nFourWheeler -2");
                int operationType = Convert.ToInt32(Console.ReadLine());
                if (operationType == 1)
                {
                    GetMotorCycleInfo();
                }
                else if (operationType == 2)
                {
                    GetCarInfo();
                }
                else
                {
                    Console.WriteLine("Invalid operation");
                }
            }
            
        }

        private static void GetCarInfo()
        {
            Car<Vehicle> car = new Car<Vehicle>("Maruti-800", 1990, "5", 800, VehicleType.Rented, 5, 4);
            car.GetDetails();
            Console.WriteLine();
            car.GetDesign();
            Console.WriteLine();
            string[] carDesign = car.GetInterriordesigns("Tissue Box,Air Freshner,Pillow");
            for(int i = 0; i < carDesign.Length; i++)
            {
                Console.WriteLine((i+1).ToString()+" " + carDesign[i]);
            }
            Console.WriteLine("----------------------------------");
        }

        private static void GetMotorCycleInfo()
        {
            MotorCycle<Vehicle> cycle = new MotorCycle<Vehicle>("Yamaha", 2022, "5", 160, VehicleType.Personal, 200, 14.4, 45, "Hard Brake", "Light Brake");
            cycle.GetDetails();
            Console.WriteLine();
            cycle.Start();
            Console.WriteLine();
            cycle.Cooling();
            Console.WriteLine();
            string[] cycleDesign = cycle.GetExteriorDesigns("Sticker,LightHorn,FoggLight");
            for(int i = 0;i < cycleDesign.Length; i++)
            {
                Console.WriteLine((i+1).ToString()+ " " + cycleDesign[i]);
            }
            Console.WriteLine("----------------------------------");
        }
    }
}
