using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskwk3
{
    internal class login: Register
    {
        string myemail;
        string mypassword;

        
      public void Log()
      {
        Console.WriteLine("enter your email address");
        myemail = Console.ReadLine();
        Console.WriteLine("enter your password");
        mypassword = Console.ReadLine(); 
            if (myemail == Email && mypassword == Password ) 
            {
                Console.WriteLine("Successful Login");
            }
            else
            {
                Console.WriteLine("invalid Email and Password");
            }
            
      }

    }

   
      
}
