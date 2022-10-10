using System.Diagnostics.Metrics;
using System.Security.Cryptography.X509Certificates;

namespace ATMLabJT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            
            
            //This code doesn't work at this moment.
            //unsure how to get the method or values from the other classes (ATM.CS and Account.CS) to show up in main.



            List<Account> Accounts = new List<Account>()
            {
                new Account("Jack","pass1",100),
                new Account("Bill","pass2", 200),
                new Account("Fran","pass3", 300),
                new Account("Aaron","pass4", 400)
            };
            ATM atm = new ATM(Accounts); //how to call a method from another class?

            Account account = new Account(Accounts);

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

            int switchNum;
            double withdraw;
            double newBalance;
            double deposit;

            //allow user (when logged in) to deposit or withdraw money
            Console.WriteLine("Welcome to the ATM service.");
            Console.WriteLine("1) Current Balance:");
            Console.WriteLine("2) Deposit:");
            Console.WriteLine("3) Withdraw:");
            Console.WriteLine("4) Exit:");
            switchNum = int.Parse(Console.ReadLine());
            switch (switchNum)
            {
                case 1: 
                    Console.WriteLine($"Your current balance is: {Account.Balance}");
                    break;

                case 2:
                    Console.WriteLine("enter amount to deposite:");
                    deposit = double.Parse(Console.ReadLine());
                    newBalance = Account.Balance + deposit;
                    Console.WriteLine($"Your new balance is {newBalance}");
                    break;    

                case 3:
                    Console.WriteLine("enter amount to withdraw:");
                    withdraw = double.Parse(Console.ReadLine());
                    if (withdraw % 100 != 0)
                    {
                        Console.WriteLine("Please enter a number");
                    }
                    else if (withdraw > Account.Balance)
                    {
                        Console.WriteLine("Invalid amount, insufficient amount in account");
                    }
                    else
                    {
                        newBalance = Account.Balance - withdraw;
                        Console.WriteLine($"Your new balance is {newBalance}");
                    }
                    break;

                case 4:
                    Console.WriteLine("Exiting..");
                    break;

            }


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