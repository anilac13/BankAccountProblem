using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProblem
{
    public class BankAccount
    {
        private decimal Balance;
        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
                throw new InsufficientFundException("Insufficient fund to carry out transaction");
            Balance -= amount;
        }
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
        public decimal GetBalance()
        {
            return Balance;
        }
    }
}
