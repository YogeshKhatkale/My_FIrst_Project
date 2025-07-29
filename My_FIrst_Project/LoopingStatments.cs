using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    internal class LoopingStatments
    {
        static void Main()
        {
            // Looping Statments
            // Switch

            int Day = 5;
            switch (Day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("Weekend");
                    break;



            }
            // For loop 

            int n = 5;

            //<variableInitilization;iterationCondition;IterationIncrement/Decrement
            for (n = 0; n < 5; n++)
            {
                Console.WriteLine("Iteration:" + n);
            }
            // While loop -- entry control loop

            int j = 0;
            while (j < 2)
            {
                Console.WriteLine("Iteration in while loop :" + j);
                j++;
            }
             
            // Do-While loop -- exit control loop
            int i = 0;
            do
            {
                Console.WriteLine("Iteration in do while loop : " + i);
                i++;
            }while(i < 0);

            // Foreach Loop

            string[] Fruits = { "Apple", "Banana", "Cherry", "Kivi", "Mango" };

            foreach(string f in Fruits)
            {
                Console.WriteLine("The Fruit is : " +  f);
            }
               

            // Jumping Statments


            // continue
               for (i=0;i < 5; i++)
                if (i == 3)
            {
                    continue;
    
            }
               Console.WriteLine(i);



            // Goto Statment


            int count = 0;
        startloop:

            if (count < 5)
            {
                Console.WriteLine($"Count is : {count}");
                count++;
                goto startloop;
                Console.WriteLine($"After goto count is {count}");
            }

            Console.WriteLine("loop with go to finished ");
        }
    }
}
