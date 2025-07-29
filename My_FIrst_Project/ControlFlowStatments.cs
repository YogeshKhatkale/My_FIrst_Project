using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    internal class ControlFlowStatments
    {
        static void Main() 
        { 
       
            //If Statment
            int age = 25;
            if (age == 25)
            {
                Console.WriteLine("The person is not senior citizen.");
            }
            // If-Else Statmenet
            string username = "Test";
            if (username == "Test1") 
            {
                Console.WriteLine("This is active user.");
                            }
            else
            {
                Console.WriteLine("This is invalid user.");
            }
            //If-Else-if-else Or Nested if
            int number = 104;
            if (number == 0)
            {
                Console.WriteLine("   ");
            }
            else if (number == 1)
            {
                Console.WriteLine("455");
            }
            else if(number > 100 && number <102)
            {
                Console.WriteLine("aaaa");
            }
            else
            {
                Console.WriteLine("Right");
            }


        }
    }
}
