﻿using System;
using taskwk3;

namespace bankapp;

class program
{
    static void main(String[] args)
    {
        Console.WriteLine("if you want to register press1 if you want to login press2");
            string n = Console.ReadLine();

            if (n == "1")
            {
            register();
            }
            else if (n == "2")
            {
            login();
            }
            else (n != 1 || n != 2)
    }
   
   
    
}