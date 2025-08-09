using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    public class Copyconstructor
    {

        // Paramer Declaration

        public string Name {  get; set; }
        public int Age {  get; set; }

         public string nameNew {  get; set; }

        public int ageNew {  get; set; }

        // parametrized constructor

        public Copyconstructor(string name,int  age)
        {
            Name = name;
            Age = age;
        }

        // copy constructor
        public Copyconstructor(Copyconstructor example)
        {
            nameNew = example.Name;
            ageNew = example.Age;
        }

        // creating method for cpy const
        public void Show()
        {
            Console.WriteLine($"new age is {ageNew} : name  {nameNew}");
        }


        public void display1()
        {
            Console.WriteLine($"Name {Name} ; Age  {Age} ");
        }
    }
    internal class Example_Copy
    {
         static void Main()
        {
            // creating object with pass the value for parameterized constructor

            Copyconstructor obj1 = new Copyconstructor("Ajay",25);
            obj1.display1();

            // copy constructor---- object creation
            Copyconstructor obj = new Copyconstructor(obj1);
            obj.Show();

        }
    }
}
