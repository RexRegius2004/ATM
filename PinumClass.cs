using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class PinumClass
    {
        public static void Pinum() 
        {
            Console.WriteLine("Enter your PIN:");

            int enterpin = Convert.ToInt32(Console.ReadLine());
            if (enterpin == InitializeClass.pin)
            {
                switch (InitializeClass.pin_signal) 
                {
                    case 0:
                        MenuATMClass menuATMclass = new MenuATMClass();
                        MenuATMClass.MenuATM();
                        break;
                    case 1:
                        DepositClass depositClass = new DepositClass();
                        DepositClass.Deposit();
                        break;
                    case 2:
                        WithdrawClass drawClass = new WithdrawClass();
                        WithdrawClass.Withdraw();
                        break;
                    case 3:
                        ChangePinClass changePinClass = new ChangePinClass();
                        ChangePinClass.ChangePin();
                        break;
                }
                
            
            }
            else if (InitializeClass.attempts <= 1)
            {
                Console.WriteLine("Wrong Pin. Please try again");
                InitializeClass.attempts++;
                Pinum();
            }
            else
            {
                Console.WriteLine("Account locked |Exiting");
                Console.WriteLine("|Press enter to exit|");
                Console.ReadLine();

            }
        }
    }
}
