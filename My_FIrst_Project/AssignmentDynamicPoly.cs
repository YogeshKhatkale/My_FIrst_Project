using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{



    class Vehicle
    {
        public virtual void StartEngine()
        {
            Console.WriteLine("Engine Started");
        }
    }

    class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car Engine Started.");
        }
    }
    class Truck : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Truck Engine Started.");
        }
    }
    internal class AssignmentDynamicPoly
    {
        static void Main()
        {
            Vehicle vehicle = new Vehicle();
            Vehicle car = new Car();
            Vehicle Truck = new Truck();

            vehicle.StartEngine();
            car.StartEngine();
            Truck.StartEngine();
        }

    }
}
