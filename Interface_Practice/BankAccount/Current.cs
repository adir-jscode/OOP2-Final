using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Current : IBasicBankingInterface
    {
        public int amount { get; set;}

        public Current(int amount)
        {
            this.amount = amount;
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
