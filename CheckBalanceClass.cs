using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class CheckBalanceClass
    {
        public static void CheckBalance() 
        {
            Console.WriteLine("Your Balance is: " + InitializeClass.balance);
            MenuATMClass menuATMClass = new MenuATMClass();
            MenuATMClass.MenuATM();

        }
    }
}
