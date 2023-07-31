using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Savings
    {
        public int amount { get; set; }

        public Savings(int amount)
        {
            this.amount = amount;
        }

        public void Deposit(int amount)
        {
            this.amount += amount;
        }

        public void Withdraw(int amount)
        {
            //account holder can withdraw maximum 80% of the amount
            if (amount > this.amount * 0.8)
            {
                Console.WriteLine("You cannot withdraw more than 80% of the amount");
            }
            else
            {
                this.amount -= amount;
            }


            
        }
    }
}
