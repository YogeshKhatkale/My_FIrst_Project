using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    internal class AssignmentStringBuilder
    {
        static void Main()
        {
            string input = "Hello World.";
            StringBuilder sb = new StringBuilder(input);
            

            // append func

            sb.Append("My name Is  Yogesh.");
           // Console.WriteLine(sb.ToString());

            // Inserting 

            sb.Insert(0 , "Khatkale \n");
            // Console.WriteLine(sb.ToString());

            // Replacing

            sb.Replace("World", "Pune");
            Console.WriteLine(sb.ToString());

            // removing data 

            sb.Remove(0, 8); // (index,length)
            Console.WriteLine(sb.ToString());

            // clear

            sb.Clear();
            Console.WriteLine(sb.ToString());
            int len = sb.Length;
            Console.WriteLine("len of sb = " + len);

        }
    }
}
