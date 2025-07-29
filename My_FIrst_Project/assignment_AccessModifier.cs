using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    public class PublicDemo()
    {
        public void ShowMessage()
        {
            Console.WriteLine("Hello From Public Demo !!!");
        }
    }

    class PrivateMethod()
    {
        private void ShowSecret()
        {
            Console.WriteLine("This is Secret Method !!");
        }
        public void UnlockSecret()
        {
            ShowSecret();
        }
    }








    class assignment_AccessModifier
    {
        static void Main()
        {
            PublicDemo Pub = new PublicDemo();
            Pub.ShowMessage();

            PrivateMethod Show = new PrivateMethod();
            Show.UnlockSecret();
        }

        static void Main2() 
        {
          
        }
    }
}

