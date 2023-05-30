using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskwk3
{
    internal class Withdraw:Register
    {
        public int Amount;

        public void withdraw() 
        {
            Console.Write("How Much Do you want to Withdraw: ");
             Amount = Convert.ToInt32(Console.ReadLine());
            Balance -= Amount;
            Console.WriteLine($"Your Balance is: {Balance}");
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
