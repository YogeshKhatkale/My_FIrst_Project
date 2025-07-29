using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    internal class Data_Types

    {
        static void Main()
        {
            //Declaration 
            int age = 25;
            float price = 50.14f;
            double pi = 3.14325;
            decimal salary = 100000.00012m;
            char grade = 'A';
            bool is_active = false;
            DateTime today = DateTime.Now;
            object data = 126;
            int? score = null;
            string name = "Yogesh";
            //print data types
            Console.WriteLine("int" + age);
            Console.WriteLine("float" + price);
            Console.WriteLine("double" + pi);
            Console.WriteLine("decimal" + salary);
            Console.WriteLine("char" + grade);
            Console.WriteLine("bool" + is_active);
            Console.WriteLine("datetime" + today);
            Console.WriteLine("object" + data);
            Console.WriteLine(name);



        }
       


    }
}
