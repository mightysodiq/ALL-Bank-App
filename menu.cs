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
            Console.WriteLine("PRESS 1 FOR DEPOSIT");
            Console.WriteLine("PRESS 2 FOR WITHDRAWAL");
            Console.WriteLine("PRESS 3 FOR TRANSFER");
            Console.WriteLine("PRESS 4 FOR ACCOUNT BALANCE");
            Console.WriteLine("PRESS 5 FOR ACCOUNT STATEMENT");
            Console.WriteLine("PRESS 6 TO CREAT A NEW ACCOUNT");
            Console.WriteLine("PRESS 7 TO LOG OUT");
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
                    Console.WriteLine($"here is your account balance:{Balance}");
                }
                else if (click == "5")
                {
                    Console.WriteLine("here is your account statement");
                }
                else if (click == "6")
                {
                     Details();
                }
                else if (click == "7")
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
