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
            Console.WriteLine("enter your email address");
            myemail = Console.ReadLine();
            Console.WriteLine("enter your password");
            mypassword = Console.ReadLine();
            if (myemail == Email && mypassword == Password)
            {
                 Console.WriteLine("Successful Login");
                 Console.WriteLine($"welcome  {Firstname} to the best bank in the world!");
                 Random random = new Random();
                 int i = random.Next(1000000000, 2100000000);
                 AccountNo = i.ToString();
                 Console.WriteLine($"your accoount number is {AccountNo}");
                 Console.WriteLine($"your full name is{Firstname}{Lastname}");
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
                    Console.WriteLine("enter correct number");
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
