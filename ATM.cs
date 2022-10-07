using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLabJT
{
    internal class ATM
    {
        public List<Account> Accounts{ get; set; }
        public ATM (List<Account> Accounts)
        {
            this.Accounts = Accounts;
        }


        public void AddBalance(string name, int BalanceChange) //function to add or subtract(?) funds from each account
        {
            if (Accounts.Where(a => a.Name == name).Count() > 0)
            {
                Account Account = Accounts.Where(a => a.Name == name).First();
                Account.Balance += BalanceChange;
            }
            else
            {
                Console.WriteLine("No Account Found with that name");
            }
        }

        public void AddAccount(string newName, string newPass)
        {
            Accounts.Add(new Account(newName, newPass, 0));
        }

    }
}
