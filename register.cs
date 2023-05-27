using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace taskwk3
{
    internal class Register
    {
        public string Firstname = "";
        public string Lastname = "";
        public string Email = "";
        public string Accounttype = "";
        public string Password = "";

        public void Details()
        {
            Console.WriteLine("pls enter your firstname");
            Firstname = Console.ReadLine();
            Firstname += Firstname;
            Console.WriteLine("pls enter your lastname");
            Lastname = Console.ReadLine();
            Lastname += Lastname;
            Console.WriteLine("pls enter your email");
            Email = Console.ReadLine();
            Email += Email;
            Console.WriteLine("press 1 for savings, press 2 for current");
            Accounttype = Console.ReadLine();
            if (Accounttype == "1") 
            {
                Accounttype +="savings";
            }
            else if  (Accounttype == "2")
            {
                Accounttype += "current";
            }
            Console.WriteLine("enter your password");
            Password = Console.ReadLine();
            Console.WriteLine("here are your details below");
            Console.WriteLine($"firstname: {Firstname}");
            Console.WriteLine($"lastname:{Lastname}");
            Console.WriteLine($"email: {Email}");
            Console.WriteLine($"accounttype: {Accounttype}");
            Console.WriteLine($"password: {Password}");
        }
    }  
    

}
