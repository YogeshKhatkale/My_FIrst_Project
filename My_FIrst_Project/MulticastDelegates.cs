using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project


{

    public delegate void Notification();

    class MDelegates
    {
        public void startingprocess()
        {
            Console.WriteLine("process started ......");
        }

        public void endingproocess()
        {
            Console.WriteLine("process ended .....");
        }
    }
    internal class MulticastDelegates
    {
        static void Main()
        {
            MDelegates md = new MDelegates();   //  class object
                                                
            Notification notify = md.startingprocess; // created the delegate instance
         
            notify += md.endingproocess;

            notify += () => Console.WriteLine("All process are stopped.");
            notify();
          
        }
    }
}
