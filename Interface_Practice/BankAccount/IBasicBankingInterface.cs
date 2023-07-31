using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public interface IBasicBankingInterface
    {
        //by default all methods in an interface are public and abstract
         void Deposit(int amount);
         void Withdraw(int amount);
        //double GetBalance();
    }
}
