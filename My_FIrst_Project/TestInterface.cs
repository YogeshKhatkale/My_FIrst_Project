using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_FIrst_Project
{
    internal interface ItestInterface
    {
        //method declaration

        void MakePayment(decimal amount);
        void RefundPayment(decimal amount);
    }

    internal interface Itestinterface1
    {
        // method declaration
        void UPIPayment(decimal amount);

    }
    class CreditCardPayment: ItestInterface, Itestinterface1  // can inherit multiple parents // over come the limitation of multiple inheritance
        {

        // method implementation that are declared in the interface above
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Credit card payment of {amount} has been maade");
        }
        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"the refund payment of {amount} has been done.");
        }
        public void UPIPayment (decimal amount)
        {
            Console.WriteLine($"Credit card payment of {amount} has been done using upi.");
        }
       
          
        }
   
    class PaypalPayment : Itestinterface1
    {
        public void UPIPayment( decimal amount)
        {
            Console.WriteLine($"The Paypal payment of amount {amount} has been done uing Upi .");
        }
    }

    internal interface TestInterface
    {
        static void Main()
        {
            ItestInterface credit = new CreditCardPayment();
            credit.MakePayment(125.33m);
            credit.RefundPayment(0.254m);
            Itestinterface1 credit1 = new CreditCardPayment();
            credit1.UPIPayment(100);

            // Another class
            Itestinterface1 Paypal = new PaypalPayment();
            Paypal.UPIPayment(1001);
            

        }
    }
}
