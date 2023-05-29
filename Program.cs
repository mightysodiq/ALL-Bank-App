using System;
using taskwk3;

namespace bankapp;

class program
{
    static void Main(String[] args)
    {
        var reg = new Register();
        reg.Details();
        var logs = new login();
        logs.Log();
        var tra = new Transaction();
        tra.deposit();
        var mens = new menu();
        mens.men();


       // Console.WriteLine("if you want to register press1 if you want to login press2");

           // string n = Console.ReadLine();

            /*if (n == "1")
            {
            register();
            }
            else if (n == "2")
            {
            login();
            }
            else (n != 1 || n != 2)*/
    }
    
}
