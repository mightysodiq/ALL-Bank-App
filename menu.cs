using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskwk3
{
    internal class menu:Register
    {
        public void men() 
        {
            Console.WriteLine("press 1 for deposit, 2 for withdrawal ,3 for account statement, 4 for account balance, 5 to transfer, 6 to LOG OUT");
            string click = Console.ReadLine();
            do
            {
                if (click == "1")
                {
                    Console.WriteLine("how much do you want to deposit");
                }
                else if (click == "2")
                {
                    Console.WriteLine("how much do you want to withdraw");
                }
                else if (click == "3")
                {
                    Console.WriteLine("here is your account statement");
                }
                else if (click == "4")
                {
                    Console.WriteLine("here is your account balance");
                }
                else if (click == "5")
                {
                    Console.WriteLine("enter the account number you wish to send money");
                }
                else if (click == "6")
                {
                    Console.WriteLine($"-------GOODBYE {Firstname} -----------");
                }
                else
                {
                    Console.WriteLine("you have enter an invalid number");
                    men();
                }
            } while (click == "1" || click == "2" || click == "3" || click == "4" || click == "5" || click == "6");
        }
    }
}
