using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class DepositClass
    {
        public static void DepositStart() 
        {
            InitializeClass.pin_signal = 1;
            Console.WriteLine("DEPOSIT");
            Console.WriteLine("Enter your Account Number: ");
            PinumClass pinumClass = new PinumClass();
            PinumClass.Pinum();
            
        }
        public static void Deposit() 
        { 
            Console.WriteLine("Enter Amount: ");
            InitializeClass.balance += Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Deposit Successful");
            MenuATMClass menuATMClass = new MenuATMClass(); 
            MenuATMClass.MenuATM();}
    }
}
