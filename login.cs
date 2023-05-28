using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskwk3
{
    internal class login: Register
    {
        string myemail;
        string mypassword;

        
      public void Log()
      {
            Console.WriteLine("--------WELCOME TO THE LOGIN PORTAL----------");
            Console.WriteLine("enter your email address");
        myemail = Console.ReadLine();
        Console.WriteLine("enter your password");
        mypassword = Console.ReadLine(); 
            if(myemail == Email && mypassword == Password) 
            {
                Console.WriteLine("Successful Login");
                Console.WriteLine($"welcome{Firstname} to the best bank in the world!" );
                Console.WriteLine("press 1 for deposit, 2 for withdrawal ,3 for account statement, 4 for account balance, 5 to transfer, 6 to LOG OUT" );
                string click  = Console.ReadLine();
                if (click == "1")
                {
                    Console.WriteLine ("how much do you want to deposit ");
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
                }
            }
            else
            {
                Console.WriteLine("invalid Email and Password");
            }

            
      }

    }

   
      
}
