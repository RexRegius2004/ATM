using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    internal class InitializeClass
    {
        public static int attempts = 0;
        public static int balance = 0;
        public static int pin = 1111;
        public static int pin_signal = 0;
        public static int ammnt = 0;
        public static void Initialize() 
        {
            Console.WriteLine("Welcome to ROJK Banks");
            PinumClass pinumclass = new PinumClass();
            PinumClass.Pinum();
        }
    }

}
