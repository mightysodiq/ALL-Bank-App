using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskwk3
{
    internal class Withdraw:Deposit
    {
        public string with = "";

        public void withdraw() 
        {
            Console.WriteLine("How Much Do you want to Withdraw?");
            string with =Console.ReadLine();
            Withdraw draw = new Withdraw();
        }

    }
}
