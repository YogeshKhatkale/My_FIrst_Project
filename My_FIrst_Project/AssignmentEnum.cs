using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    internal class AssignmentEnum
    {
        enum Year
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static void Main()
        {
            Year Month = Year.December;
            Console.WriteLine($"Selected month : {Month}");


            if (Month == Year.January)
            {
                Console.WriteLine("This is the starting month of the year.");
            }
            else if (Month == Year.December)
            {
                Console.WriteLine("This is the ending Month of the year.");

            }
            else { Console.WriteLine("This is the middle Month of the year."); }
        }
    }
}
