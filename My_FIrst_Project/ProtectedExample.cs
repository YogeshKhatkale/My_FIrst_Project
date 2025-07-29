using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{ 

    // Protected class
    // parent class // super class // Base class
    
    class Animal
    {
        // Protrcted Member 

        protected string sound;
         
        // Protected Method
        protected void Makesound()
        {
            Console.WriteLine($"Sound Of Amimal : {sound}");
        }
    }

    // Derived class // child class// Sub class

    class Dog : Animal
    {
        public Dog()
        {
            sound = "Dog : Barkss!!";
        }
        public void Displaysound()
        {
            Makesound();
        }
    }



    class ProtectedExample
    {
    static void Main()
        {
            Dog dog = new Dog();
            dog.Displaysound();
        }

    }
}
