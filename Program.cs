using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace ATMLabJT
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Account> Accounts = new List<Account>()
            {
                new Account("Jack","pass1",100),
                new Account("Bill","pass2", 200),
                new Account("Fran","pass3", 300),
                new Account("Aaron","pass4", 400)
            };
            ATM atm = new ATM (Accounts);

            //allow user to log in with their own login (username and password)

            //set default "account" in class to default, as the user will need to log in.
            // in atm class, use a constructor to call the a.account.
                //have a list that is empty, and add usernames/pass/ect to it as the program runs.



            //Console.WriteLine("Please enter your username to login (case sensitive)");
            //string accUser = Console.ReadLine();
            //if (accUser.Contains( Accounts a.Name ))



            //allow user to register a new account
            string newName;
            string newPass;
            Console.WriteLine("To create a new account, please state your username:");
            newName = Console.ReadLine();

            Console.WriteLine("Please enter your password. (case-sensitive)");
            newPass = Console.ReadLine();

            atm.AddAccount(newName, newPass);

            printAccountList(Accounts);


            //allow user (when logged in) to deposit or withdraw money



        }
        
        public static void printAccountList(List<Account> Accounts)
        {
            for (int i = 0; i < Accounts.Count; i++)
            {
                Account a = Accounts[i];
                Console.WriteLine($" {a.Name}");
            }
        }
    }
}