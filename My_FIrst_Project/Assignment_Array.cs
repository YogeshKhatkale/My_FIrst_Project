using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    internal class Assignment_Array
    {
        static void Main()
        {
            // Sum of numbers in an array.
            int sum = 0;
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, };
            for ( int i = 0; i < Numbers.Length; i++ )
            {
            sum += Numbers[i];

            }
            Console.WriteLine( "Sum of all values in an array is : " + sum );


            // Program  to calculate the average of values of array elements.

            int[] NUM = { 1, 2, 3, 4, 6, 7, 8, 9, 7, 5, 44, 6, 677, 4, 6, };
            int sum1 = 0;
            for ( int j = 0;j < NUM.Length; j++)
            {
                sum1 += NUM[j];
            }
            int avg = sum1/NUM.Length;
            Console.WriteLine( "Average of all avlues in an array is : " + avg );
        }
    }
}
