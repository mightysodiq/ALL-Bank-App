using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace taskwk3
{
    internal class Transaction :Register
    {
        public static string accountname = "";
        public static string accountnumber ="";
        public static string deposits = "";
        public static string transfers = "";
        public static string widrawal = "";
        public void deposit() 
        {
            Console.WriteLine($"welcome  {Firstname}  your account type is {Accounttype} how much do you want to deposit ?");
            string depo = Console.ReadLine();
            depo += deposits;

        }

        public void withdrawal() 
        {
            Console.WriteLine($"hello! {Firstname} how much do you want to withdraw?");
            string with = Console.ReadLine();
           
           
        }
        public void transfer() 
        {
            Console.WriteLine("enter the account number you wish to send money");

        }
    }
}
