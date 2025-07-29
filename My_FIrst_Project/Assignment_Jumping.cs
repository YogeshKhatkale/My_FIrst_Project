using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    internal class Assignment_Jumping
    {
        static void Main()
        {
            // Go-to

            Console.WriteLine("Enter your age :");
            int age = int.Parse(Console.ReadLine());
        startloop:
            if (age > 0 && age <= 120)
            {
                Console.WriteLine($"Your Age is Valid {age}");
                age -= age;
                goto startloop;
                Console.WriteLine("hugyfthrdt");
            }

            // Continue
            Console.WriteLine("Printing numbers 1 to 20 except numbers divisible by 3.");
            for (int i = 0; i <= 20; i++)
            {

                if (i % 3 == 0)
                {
                    continue;

                }
                Console.WriteLine(i);
            }

            // Break

            int sum = 0;
            Console.WriteLine("Enter numbers (Negative to stop.)");

            while (true)
            {
                Console.Write("Enter numbers :");
                int numbers = Convert.ToInt32(Console.ReadLine());
                if (numbers < 0)
                {
                    break;
                }
                sum += numbers;

            }
            Console.WriteLine("\n The sum of all positive Numbers is : " + sum);
            
        }

            
            

        
    }
}
