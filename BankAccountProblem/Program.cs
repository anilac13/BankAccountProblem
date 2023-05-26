using System;
namespace BankAccountProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount firstAccount = new BankAccount(5000);
            BankAccount secondAccount = new BankAccount(3000);

            BankATM canaraATM = new BankATM(50000);

            canaraATM.FastWithdrawal(firstAccount, 2000);
            canaraATM.FastWithdrawal(secondAccount, 4000);
            canaraATM.FastWithdrawal(firstAccount, 2500);

        }
    }
}