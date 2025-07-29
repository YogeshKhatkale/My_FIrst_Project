using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
     class PrivateExample


    {
        // Private Property
        private int Privatefield;

        // private method

        private void setfield(int value)
        {
            Privatefield = value;
        }
        public void Show()
        {
            setfield(55);
            Console.WriteLine("Private field value :" + Privatefield);
        }
    }

    class program
    {
        static void Main()
        {
            Internal see = new Internal();
            see.showw();


            PrivateExample example = new PrivateExample();
            example.Show();
        }
    } 

}
