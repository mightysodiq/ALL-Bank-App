using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace taskwk3
{
    internal class Register
    {
        public static string Firstname = "";
        public static string Lastname = "";
        public static string Email = "";
        public static string Accounttype = "";
        public static string Password = "";

        public void Details()
        {
            Console.WriteLine("pls enter your firstname");
            string fname = Console.ReadLine();
            Firstname += fname;
            Console.WriteLine("pls enter your lastname");
            string lname = Console.ReadLine();
            Lastname += lname;
            Console.WriteLine("pls enter your email");
            string email = Console.ReadLine();
            Email += email;
            Console.WriteLine("press 1 for savings, press 2 for current");
            string acctype = Console.ReadLine();
            if (acctype == "1")
            {
                Accounttype += "savings";
            }
            else if (acctype == "2")
            {
                Accounttype += "current";
            }
            else  
            {
                Console.WriteLine("pls, input the right number");
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
