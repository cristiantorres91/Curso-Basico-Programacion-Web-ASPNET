using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_BankAccount_POO
{
    public class BankAccount
    {
        public string Holder { get; set; }
        public string AccountNumber { get; set; }
        private decimal Balance;

        public BankAccount(string holder, string accountNumber, decimal balance)
        {
            Holder = holder;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }


        public bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            else
                return false;
        }

        public decimal CurrentBalance()
        {
            return Balance;
        }
    }
}
