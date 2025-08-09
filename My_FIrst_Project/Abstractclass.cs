 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    // Abstract Class
    public abstract class Animal1
    {
        public int a,b;

        // abstract method (No Implementation)

        public abstract void MakingSound();

        // non abstract method(must do Implementation)

        public void Eat()
        {
            Console.WriteLine("Animal Is eating.");
        }

    }


    // Derived class
    public class Cow : Animal1 
    {
        public override void MakingSound() 
        {
            Console.WriteLine("Sound of Cow is moo.");
        }
        
    }
    public class Cat : Animal1
    {
        public override void MakingSound()
        {
            Console.WriteLine("Sound of cat is Meow.");
        }
       
    }



    internal class Abstractclass
    {
        static void Main()
        {
            Cat cat = new Cat();
            Cow ca = new Cow();
            ca.MakingSound();
            ca.Eat();
            cat.MakingSound();
            cat.Eat();
        }

    }
}
