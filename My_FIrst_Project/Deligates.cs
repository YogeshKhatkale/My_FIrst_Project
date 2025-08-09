using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    // [Modifier] delegate returntype | void <name>([parameterslist])
    // deligate declaration

    public delegate void AddDelegate(int a, int b);
    public delegate string DisplayDelegate(string str);

    class MyDelegates
    {
        public void Addnumbers(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static string Display(string str)
        {
            return "hello" + str;
        }
    }
        internal class Deligates
        {
            static void Main()
            {
                // Calling Delegates
                MyDelegates md = new MyDelegates();  // class object creation
                AddDelegate ad = new AddDelegate(md.Addnumbers);
                ad(10, 20);
                md.Addnumbers(10, 20);


                DisplayDelegate dp = new DisplayDelegate(MyDelegates.Display);
                string str = dp(" Pune");
                Console.WriteLine(str);

            }

        }
    }

