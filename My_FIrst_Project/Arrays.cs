using My_FIrst_Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    internal class Arrays
    {

       


        //Arrays
        static void Main()



        {


            // AccessModifier obj = new AccessModifier();
            // obj.Score = 101;
            // obj.Display();
           // obj.show();


        // Method 1 to create array

        string[] Mobile = new string[4];
            Mobile[0] = "Apple";
            Mobile[1] = "Oneplus";
            Mobile[2] = "Samsung";
            Mobile[3] = "Oppo";

            // Method 2 to create array

            string[] City = {"Pune", "Solapur","Mumbai","Banglore"} ;


            //Accessing Values from array

            for(int i =0; i< Mobile.Length; i++)
            {
                Console.WriteLine("Mobile Name :" + Mobile[i]);
            }


            // Multi-dimensional Array

            int[,] matrix = new int[,]
            {
                {1, 2, 3, },
                {4, 5, 6, },
                {5, 6, 7, }
            };
            Console.WriteLine(matrix[1,1]);


            // Jagged Array

            // Declaration of jagged array

            int[][] jagged = new int [][]
            {
                new int []{1, 2, 3, },
                new int []{5,6,8,4,2, },
                new int []{1,8}
            };
            // Accessing the Jagged array
            Console.WriteLine(jagged[0][1]);
            for(int i = 0; i< jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Reverse the string using array.

            string Sent = "Hello Pune";
            Console.WriteLine(Sent);

            char[] chars = Sent.ToCharArray();
            Console.WriteLine(chars);

            char[] Reversed_str = new char[chars.Length];
            for(int i = 0;i< chars.Length; i++)
            {
                Reversed_str[i] = chars[chars.Length -1 -i];
            }
            string reversed = new string(Reversed_str);
            Console.WriteLine(reversed);

            // using reverse func

           // string Sent = "Hello Pune";


            char[] chars1 = Sent.ToCharArray();
            Array.Reverse(chars);
            string reversed1 = new string(chars);
            Console.WriteLine(reversed);  // Output: enuP olleH

        }
    }
}
