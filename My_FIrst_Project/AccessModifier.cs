using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    public class AccessModifier
    {
        // Define Property
        public int Score { get; set; }

        // Method
        public void Display()
        {
            Console.WriteLine("The Score is :" + Score);
        }
        public void show()
        {
            Console.WriteLine("Hello");
        }
    }

    public class Check
    {
        static void Main()
        {
            // Creating object/instance for another class
            AccessModifier obj = new AccessModifier();

            obj.Score = 100;
            obj.Display();
        }

    }

}
