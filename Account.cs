using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLabJT
{
    public class Account
    {
        
        public string Name { get; set; }

        public string Password { get; set; }

        public double Balance { get; set; }


        public Account(string Name, string Password, int Balance)
        {
            this.Name = Name;
            this.Password = Password;
            this.Balance = Balance;
        }

        public double Balance2()
        {
            return Balance;
        }
    }
}
