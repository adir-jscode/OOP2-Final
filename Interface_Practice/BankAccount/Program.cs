using BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankAccount
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Current currentAccount = new Current(1000);
            Savings savingsAccount = new Savings(2000);
            Overdraft overdraftAccount = new Overdraft(3000, overdraftLimit: 1000);

            // Test deposit and withdraw
            Console.WriteLine("Current Account:");
            Console.WriteLine("Initial Balance: " + currentAccount.amount);
            currentAccount.Deposit(500);
            currentAccount.Withdraw(200);
            Console.WriteLine("Final Balance: " + currentAccount.amount);

            Console.WriteLine("\nSavings Account:");
            Console.WriteLine("Initial Balance: " + savingsAccount.amount);
            savingsAccount.Deposit(1000);
            savingsAccount.Withdraw(1500);
            Console.WriteLine("Final Balance: " + savingsAccount.amount);

            Console.WriteLine("\nOverdraft Account:");
            Console.WriteLine("Initial Balance: " + overdraftAccount.amount);
            overdraftAccount.Deposit(800);
            overdraftAccount.Withdraw(3500);
            Console.WriteLine("Final Balance: " + overdraftAccount.amount);

            //// Test changing account type
            //IBasicBankingInterface newSavingsAccount = ChangeAccountType(currentAccount, "Savings");
            //Console.WriteLine("\nChanged Current to Savings Account:");
            //Console.WriteLine("New Account Balance: " + (newSavingsAccount as SavingsAccount).Balance);

            //BasicBankingInterface newOverdraftAccount = ChangeAccountType(savingsAccount, "Overdraft", overdraftLimit: 2000);
            //Console.WriteLine("\nChanged Savings to Overdraft Account:");
            //Console.WriteLine("New Account Balance: " + (newOverdraftAccount as OverdraftAccount).Balance);

        }
    }
}