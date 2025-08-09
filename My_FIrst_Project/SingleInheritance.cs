using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{

    class Bike
    {
        public string Brand { get; set; }
        public void Drive()
        {
            Console.WriteLine("Driving bike.");
        }


    }


    class Bullet : Bike
    {
        public string colour { get; set; }

        public void info()
        {
            Console.WriteLine($"This is {Brand}'s bike . Its colour is {colour}");
        }
    }
    internal class SingleInheritance
    {
      


        static void Main()
        {
            Bullet gt = new Bullet();
            gt.Brand = "Royal Enfield";
            gt.colour = "Black";
            gt.info();
            gt.Drive();


        }
    }

}