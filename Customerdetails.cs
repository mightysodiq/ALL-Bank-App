﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace taskwk3
{
    internal class Customerdetails
    {
        public string firstname;
        public string lastname;
        public int accountnumber;
        public double dateofbirth;
        public int Phonenumber;
        public string accounttype;

        public Customerdetails(int firstname, int lastname, string name)
        {
        }

        public Customerdetails(string firstname, string lastname, int accountnumber, double dateofbirth, int phonenumber, string accounttype)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.accountnumber = accountnumber;
            this.dateofbirth = dateofbirth;
            Phonenumber = phonenumber;
            this.accounttype = accounttype;
        }
        
    }
}
