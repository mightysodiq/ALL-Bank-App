using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace taskwk3
{
    internal class login : Register
    {

       
        string myemail;
        string mypassword;
        String AccountNo;


        public void Log()
        {
            //Console.Clear();
             Console.WriteLine("--------WELCOME TO THE LOGIN PORTAL----------");
            Console.WriteLine("ENTER YOUR EMAIL ADDRESS;");
            myemail = Console.ReadLine();
            Console.WriteLine("ENTER YOUR PASSWORD;");
            mypassword = Console.ReadLine();
            if (myemail == Email && mypassword == Password)
            {
                 Console.WriteLine("|------------SUCCESSFUL LOGIN--------------------|");
                 Console.WriteLine($"WELCOME! {Firstname} TO THE BEST BANK IN THE WORLD!");
                 Random random = new Random();
                 int i = random.Next(1000000000, 2100000000);
                 AccountNo = i.ToString();
                 Console.WriteLine($"YOUR ACCOUNT NUMBER IS: {AccountNo}");
                 Console.WriteLine($"YOUR FULLNAME IS:{Firstname} {Lastname}");
                 Console.Clear();
                 Console.WriteLine("press 1 to go to menu");
                 string clck = Console.ReadLine();
                if (clck == "1") 
                {
                    menu mens = new menu();
                    mens.men();
                }
                else
                {
                    Console.WriteLine("ENTER CORRECT NUMBER!");
                    Log();
                }
            }
             else
             {
                 Log();
             }
        }
    }
}
