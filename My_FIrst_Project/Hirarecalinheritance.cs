using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    class Myshape   // Base Class or parent class
    {
        public void Sketch()
        {
            Console.WriteLine("Drawing a Shape");
        }
    }



    class Mycircle : Myshape // child class
    {
        public void DrawCircle()
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }

    class MyRectangle : Myshape  // child class
    {
        public void DrawRectangle()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
    }

    internal class Hirarecalinheritance
    {
        static void Main()
        {
            MyRectangle rect = new MyRectangle();
            Mycircle circle = new Mycircle();

            rect.Sketch();
        }

        

        
    }
}
