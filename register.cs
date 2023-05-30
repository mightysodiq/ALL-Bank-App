using System;
using System.Text.RegularExpressions;
using ConsoleTables;

namespace taskwk3
{
    internal class Register
    {
        

        public static string Firstname = "";
        public static string Lastname = "";
        public static string Email = "";
        public static string Accounttype = "";
        public static string Password = "";
        public static int Balance = 0;
        
        

        public void Details()
        {
            

        Console.WriteLine("Please enter your firstname:");
            string fname = Console.ReadLine();
            Firstname += fname;

            Console.WriteLine("Please enter your lastname:");
            string lname = Console.ReadLine();
            Lastname += lname;

            Console.WriteLine("Please enter your email:");
            string email = Console.ReadLine();
            Email += email;

            Console.WriteLine("Press 1 for savings, press 2 for current:");
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
                Console.WriteLine("Please input the right number.");
            }

            ValidatePassword();

            var table = new ConsoleTable("FULLNAME", "ACCOUNT TYPE", "BALANCE");
            table.AddRow(Firstname + Lastname, Accounttype, Balance);
            table.Write();

            Console.WriteLine("Here are your details below:");
            Console.WriteLine($"Firstname: {Firstname}");
            Console.WriteLine($"Lastname: {Lastname}");
            Console.WriteLine($"Fullname: {Firstname} + {Lastname}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Accounttype: {Accounttype}");
            Console.WriteLine($"Password: {Password}");
            Console.WriteLine($"Your Balance is: {Balance}");
        }

        private void ValidatePassword()
        {
            bool isValidPassword = false;
            while (!isValidPassword)
            {
                Console.WriteLine("Enter your password (minimum 6 characters including alphanumeric and at least one special character):");
                Password = Console.ReadLine();

                // Password validation using regular expression
                string passwordPattern = @"^(?=.*[@#$%^&!])(?=.*[a-zA-Z0-9]).{6,}$";
                if (Regex.IsMatch(Password, passwordPattern))
                {
                    isValidPassword = true;
                }
                else
                {
                    Console.WriteLine("Invalid password. Please make sure your password is minimum 6 characters, including alphanumeric and at least one special character (@, #, $, %, ^, &, !).");
                }
            }
        }
    }
}
