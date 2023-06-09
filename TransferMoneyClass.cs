using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class TransferMoneyClass
    {
        public static void TransferMoney() 
        {
            Console.WriteLine("Your Balance is: " + InitializeClass.balance);
            Console.WriteLine("Enter Account Number: ");
            string AccountNumber = Console.ReadLine();
            Console.WriteLine("Enter Amount: ");
            string TransferAmount = Console.ReadLine();
            int NewBalance = InitializeClass.balance - Convert.ToInt32(TransferAmount);
            if (NewBalance < 0)
            {
                Console.WriteLine("Insufficient Balance.");
                MenuATMClass menuATMClass = new MenuATMClass();
                MenuATMClass.MenuATM();
            }
            else
            {
                InitializeClass.balance -= Convert.ToInt32(TransferAmount);
                Console.WriteLine("Transferred " + TransferAmount + " to Account Number " + AccountNumber + " successfully");
                MenuATMClass.MenuATM();
            }
        }
    }
}
