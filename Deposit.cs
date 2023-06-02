using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace taskwk3
{
    internal class Deposit:Register
    {
        public static int Amount;
        int  Date = 0;
        string Print = "";

        public void deposit()
        {
            Console.Clear();
            Console.WriteLine($"Welcome {Firstname} your account type is {Accounttype}");
            Console.Write("How much do you want to Deposit: ");
            Amount = Convert.ToInt32(Console.ReadLine());
            Balance += Amount;  
            Console.WriteLine($"Your Balance is: {Balance}");
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString());
            var table = new ConsoleTable("FIRSTNAME", "ACCOUNTTYPE","AMOUNT","BALANCE","DATE AND TIME");
            table.AddRow(Firstname + Lastname, Accounttype, Amount, Balance, dateTime);
            table.Write();
            Print = Print + $"{Firstname + Lastname} {Accounttype} {Amount} {Balance} {dateTime} \n";
            Console.WriteLine("|---------|-----------|------|-------|--------------|");
            Console.WriteLine("|FIRSTNAME|ACCOUNTTYPE|AMOUNT|BALANCE|DATE AND TIME |");
            Console.WriteLine("|---------|-----------|------|-------|--------------|");
            Console.WriteLine (Print);
            Console.WriteLine("|---------------------------------------------------|");



            Console.WriteLine("Enter 1 to go back to menu");
            string input = Console.ReadLine();
            if (input == "1")
            {
                menu menu = new menu();
                menu.men();
            }
        }
    }
}
