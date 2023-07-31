using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Overdraft : IBasicBankingInterface
    {
        public int amount { get; set; }
        private int overdraftLimit;

        public Overdraft(int amount, int overdraftLimit)
        {
            this.amount = amount;
            this.overdraftLimit = overdraftLimit;
        }

        public void Deposit(int amount)
        {
            this.amount += amount;
        }

        public void Withdraw(int amount)
        {
            this.amount -= amount;
        }
    }
}
