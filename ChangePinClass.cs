using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class ChangePinClass
    {
        public static void ChangePinStart()
        {
            Console.WriteLine("CHANGE PIN");
            InitializeClass.pin_signal = 3;
            PinumClass pinumClass = new PinumClass();
            PinumClass.Pinum();
            
            
            
        }
        public static void ChangePin() 
        { 
            Console.WriteLine("Enter new PIN: ");
            InitializeClass.pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Change Successful");
            MenuATMClass menuATMClass = new MenuATMClass();
            MenuATMClass.MenuATM();
        }
    }
}
