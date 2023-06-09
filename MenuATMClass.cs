using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class MenuATMClass
    {
        public static void MenuATM() 
        {
            Console.Clear();
            Console.WriteLine("(1)DEPOSIT (2)WITHDRAW (3)CHANGE PIN (4)CHECK BALANCE (5)TRANSFER MONEY (6)PAY BILLS (7)EXIT");
            
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1://DEPOSIT 
                    DepositClass depositClass = new DepositClass();
                    DepositClass.DepositStart();
                    break;
                case 2: //WITHDRAW
                    WithdrawClass withdrawClass = new WithdrawClass();
                    WithdrawClass.WithdrawStart();

                    break; 
                case 3: // CHANGE PIN> enter old pin, enter new pin, confirm pin
                    ChangePinClass changePinClass = new ChangePinClass();
                    ChangePinClass.ChangePinStart();
                    break;
                case 4: // CHECK BALANCE> display balance
                    CheckBalanceClass checkBalanceClass = new CheckBalanceClass();
                    CheckBalanceClass.CheckBalance();
                    break;
                case 5: // TRANSFER MONEY
                    TransferMoneyClass transferMoneyClass = new TransferMoneyClass();
                    TransferMoneyClass.TransferMoney();
                    break;
                case 6: // PAY BILLS> display balance
                    PayBillsClass payBillsClass = new PayBillsClass();
                    PayBillsClass.PayBills();
                    break;
                case 7: // EXIT> return to pin
                    Console.WriteLine("|Press enter to exit|");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("*** Select from 1-7 only ***");
                    MenuATM();
                    string MenuAnswer = Console.ReadLine();
                    break;
            }
        }
    }
}
