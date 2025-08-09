using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    public class Defaultconstructor
    {
        public int Value;

        //Defaultconstructor

        public Defaultconstructor()
        { 
            Value = 19;
        }

        public void Display()
        {
            Console.WriteLine("test  " + Value);       
        }
    }

    public class Example
    {
        static void Main()
        {

            // obj Creation 

            Defaultconstructor obj = new Defaultconstructor();
            obj.Display();
        }
    }
}
