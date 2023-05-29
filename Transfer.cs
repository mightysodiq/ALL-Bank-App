using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskwk3
{
    internal class Transfer
    {
        public string trans = "";
        public string acn = "";
        public string soo = "";

        public void  VTransfer() 
        {
            Console.WriteLine("Enter the account number you wish to send money to");
            string Acn=Console.ReadLine();
            Console.WriteLine("Enter the amount you wish to send");
            string soo=Console.ReadLine();

        }
    }
}
