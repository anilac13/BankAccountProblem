using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountProblem
{
    public class BankATM
    {
        private int CashBalance;
        public BankATM(int cashInserted)
        {
            CashBalance = cashInserted;
        }
        public void FastWithdrawal(BankAccount account, int amount)
        {
            try
            {
                account.Withdraw(amount);
                Console.WriteLine($"Amount withdrawn: {amount}");
                Console.WriteLine($"Remaining Balance: {account.GetBalance()}");
                CashBalance -= amount;
            }
            catch(InsufficientFundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
