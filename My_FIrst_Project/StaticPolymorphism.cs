using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    internal class StaticPolymorphism
    {
        // method name same class also same but different Parameters
        // static OR Compile time polymorphism OR method overloading  
        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Add(double x , double y)
        {
            return x - y;
        }

    }

    class Mathoperations
        
    {
        static void Main()
        {
            StaticPolymorphism ops = new StaticPolymorphism();

            int sum = ops.Add(5, 8);
            double sub = ops.Add(5.6, 1.2);

            Console.WriteLine("sum of integer is " + sum);
            Console.WriteLine("Substraction of Double is "+sub);

        }
        
    }


    // Assignment 

    class calculator
    {
        public int Sum(int x, int y) // Addition
        {
            return x + y;
        }

        public int Sub(int x, int y) // substraction
        {
            return x - y;
        }
        public int Div(int x, int y)     //division
        {
            return x /y;
        }
        
        public int product(int x, int y) //Multiplication
        {
            return x * y;
        }
    }
}
