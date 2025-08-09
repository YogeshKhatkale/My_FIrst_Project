using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{

    class Boy
    {
        public void Nature()
        {
            Console.WriteLine("Boy is shy. ");
        }
    }

    class Student : Boy
    {
        public void clever()
        {
            Console.WriteLine("Student is clever.");
        }
    }

     class Siddharth
    {
        public void info()
        {
            Student std = new Student();
            std.Nature();
            std.clever();
        }
    }
    internal class MultipleInheritance
    {
        static void Main()
        {
            Siddharth sid = new Siddharth();
            sid.info();
        }
    }
}
