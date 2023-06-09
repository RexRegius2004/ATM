using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class PayBillsClass
    {
        public static void PayBills() 
        {
            Console.WriteLine("Your Balance is: " + InitializeClass.balance);
            Console.WriteLine("Enter Amount: ");
            string BillAmount = Console.ReadLine();
            int NewBalance = InitializeClass.balance - Convert.ToInt32(BillAmount);
            if (NewBalance < 0)
            {
                Console.WriteLine("Insufficient Balance.");
                MenuATMClass menuATMClass = new MenuATMClass();
                MenuATMClass.MenuATM();
            }
            else
            {
                InitializeClass.balance -= Convert.ToInt32(BillAmount);
                Console.WriteLine("Bill amounting to: " + BillAmount + " paid successfully");
                MenuATMClass.MenuATM();
            }
        }
    }
}
