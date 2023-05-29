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
            Console.WriteLine("press 1 for deposit, 2 for withdrawal ,3  for Transfer, 4 for account balance, 5 to for account statement, 6 to LOG OUT");
            string click = Console.ReadLine();
            
                if (click == "1")
                {
                    Deposit deposi = new Deposit();
                     deposi.deposit(); 
                }
                else if (click == "2")
                {
                    Withdraw draw = new Withdraw();
                     draw.withdraw();
                }
                else if (click == "3")
                {
                    Transfer too = new Transfer();
                    too.VTransfer();
                }
                else if (click == "4")
                {
                    Console.WriteLine("here is your account balance");
                }
                else if (click == "5")
                {
                    Console.WriteLine("here is your account statement");
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
            
        }
    }
}
