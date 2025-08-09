using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{

    // Single Inheritance

    class Person  // parent class
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void p_info()
        {
            Console.WriteLine($"My name is {Name},I'm {Age} years old.");
        }

    }
    class student : Person // Drived class from Person 
    {
        public void Info()
        {
            p_info();
        }

    }

    // Multiple Inheritanc 

    class Teacher : Person
    {
        public string Subject;
        public void Info()
        {
            p_info();
        }
    }

    class Principal : Teacher
    {
        public string school;
        public void Show_info ()
        {
            Console.WriteLine($" Principla's name : {Name}\n school name : {school}\n subject : {Subject} \n Age ; {Age}");
        }

    }
    internal class AssignmentInheritance
    {

        static void Main()
        {
            student std = new student();
            std.Name = "Yogesh K";
            std.Age = 21;
            std.Info();


            Principal p = new Principal();
            p.Name = "R.k.MIshra";
            p.Age = 42;
            p.Subject = "Maths";
            p.school = "Vidyamandir public School";
            p.Show_info();
        }
    }
}
