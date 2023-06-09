using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class WithdrawClass
    {
        public static void WithdrawStart() 
        {
            InitializeClass.pin_signal = 2;
            Console.WriteLine("WITHDRAW");
            Console.WriteLine("Enter Amount: ");
            InitializeClass.ammnt = Convert.ToInt32(Console.ReadLine());  
            PinumClass pinumClass = new PinumClass();
            PinumClass.Pinum();
        }
        public static void Withdraw()
        {
            Console.WriteLine(InitializeClass.ammnt - InitializeClass.balance);
            Console.WriteLine("Withdraw Successful");
            MenuATMClass menuATMClass = new MenuATMClass(); 
            MenuATMClass.MenuATM();
        }
    }
}
