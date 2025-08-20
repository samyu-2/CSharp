using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class ManageAccount
    {
        public static void Display()
        {
            BankAccount account = new BankAccount("Alice", "1343", "CBE");
            account.DisplayInfo(); ;
            account.Deposit(500);
            account.withdraw(100);

            SavingsAccount savingsAccount = new SavingsAccount("1343", "Alice", 400, 3.5);
            savingsAccount.DisplayInfo();
            

        }
    }

    class BankAccount
    {
        protected decimal balance;
        public string AccountHolder { get; set; }
        protected string AccountNumber { get; set; }
        internal string BankBranch { get; set; }

        public BankAccount(string holder, string accNumber, string branch)
        {
            AccountHolder = holder;
            AccountNumber = accNumber;
            BankBranch = branch;
            balance = 0;
        }

        public void DisplayInfo()
        {
            showAccountNumber();
            Console.WriteLine($"Account Holder: {AccountHolder}\nBalance: {balance}");
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"{amount} deposited. Current Balance = {balance}");
        }

        public void withdraw(decimal amount)
        {
            if(amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"{amount} withdrawn. Current Balance = {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

        private protected void showAccountNumber()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
        }
    }

    class SavingsAccount : BankAccount
    {
        private double interestRate;

        public SavingsAccount(string holder, string accNum, decimal initialBalance , double rate) 
            : base(holder, accNum, "Default Branch") {
            balance = initialBalance;
            interestRate = rate;
        }


        public void DisplayInfo()
        {
            showAccountNumber();
            Console.WriteLine($"Holder: {AccountHolder}\nBalance: {balance}\nInterest Rate: {interestRate}%");
        }
    }
}
