using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    //Dynamic Polymorphism Or Method Overriding OR Runtime poly...
    // Method Name same parameter is also same but in different classes , it follows Parent child relationships.


    // Parent class or Base class

    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing Shapes");
        }

        // Derived or Child Class

      

    }
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing circle.");
        }
    }

    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing Rectangle.");
        }
    }

    internal class DynamicPolymorphism
    {
        static void Main()
        {
            Shape shape = new Shape();  
            
            Shape Shape1 = new Circle();
            Shape Shape2 = new Rectangle();
            shape.Draw();
            Shape1.Draw();
            Shape2.Draw();

        }
    }


    // Assignment 

   
}
