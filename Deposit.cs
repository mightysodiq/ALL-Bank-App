﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskwk3
{
    internal class Deposit:Register
    {
        public static int Amount;

        public void deposit()
        {
            
            Console.WriteLine($"Welcome {Firstname} your account type is {Accounttype}");
            Console.Write("How much do you want to Deposit: ");
            Amount = Convert.ToInt32(Console.ReadLine());
            Balance += Amount;
        }
    }
}
