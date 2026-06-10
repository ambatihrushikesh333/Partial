using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealedclass
{
    sealed class BankAccount
    {
        public int AccountNo;
        public double Balance;

        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine("Deposited: " + amount);
        }
        public void DisplayBalance()
        {
            Console.WriteLine("Balance: " + Balance);
        }
        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawn: " + amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount();

            b.AccountNo = 1001;

            b.Deposit(5000);
            b.DisplayBalance();
            Console.WriteLine("=========================================");
            b.Withdraw(2000);
            Console.WriteLine("=========================================");
            b.DisplayBalance();
        }
    }
}
