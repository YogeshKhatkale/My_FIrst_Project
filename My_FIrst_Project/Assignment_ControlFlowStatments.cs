using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    internal class Assignment_ControlFlowStatments
    {
        //  Number Check (Positive,Negative Or Zero)
        static void Main()
        {
            Console.Write("Enter a number :");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number);
            if (number > 0)
            {
                Console.WriteLine("Number is Positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Number is Negative.");
            }
            else
            {
                Console.WriteLine("Number is Zero");

            }
            // Numeric Grades TO letter Grades



            Console.Write("Enter Student's Marks :");
            int Marks = int.Parse(Console.ReadLine());
            Console.WriteLine(Marks);
            if (Marks >= 90)
            {
                Console.WriteLine("A Grade.");
            }

            else if (Marks >= 75 && Marks < 90)
            {
                Console.WriteLine("B Grade.");
            }
            else if (Marks >= 40 && Marks < 75)
            {
                Console.WriteLine("C Grade.");
            }
            else
            {
                Console.WriteLine("Fail.");
            }
            int a = 15, b = 4;

            Console.WriteLine("Addition: " + (a + b));          // Addition
            Console.WriteLine("Subtraction: " + (a - b));       // Subtraction
            Console.WriteLine("Multiplication: " + (a * b));    // Multiplication
            Console.WriteLine("Division: " + (a / b));          // Division
            Console.WriteLine("Modulus: " + (a % b));           // Modulus


            int x = 10, y = 20;

            Console.WriteLine("Equal to: " + (x == y));               // false
            Console.WriteLine("Not equal to: " + (x != y));           // true
            Console.WriteLine("Greater than: " + (x > y));            // false
            Console.WriteLine("Less than: " + (x < y));               // true
            Console.WriteLine("Greater than or equal to: " + (x >= y)); // false
            Console.WriteLine("Less than or equal to: " + (x <= y));    // true

        }

    }
}
