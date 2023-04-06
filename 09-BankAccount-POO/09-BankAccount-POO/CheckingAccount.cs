using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_BankAccount_POO
{
    public class CheckingAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }
        public decimal InterestRate { get; set; }

        public CheckingAccount(string accountHolder, string accountNumber, decimal initialBalance, decimal overdraftLimit, decimal interestRate)
            : base(accountHolder, accountNumber, initialBalance)
        {
            OverdraftLimit = overdraftLimit;
            InterestRate = interestRate;
        }

        public decimal CalculateInterest()
        {
            return CurrentBalance() * InterestRate;
        }

        public decimal CalculateOverdraftCharge(decimal amount)
        {
            //Si la cantidad es negativa (es decir, se trata de una cantidad retirada)
            //y su valor absoluto es mayor que la suma del saldo actual y el límite de sobregir
            if (amount < 0 && Math.Abs(amount) > CurrentBalance() + OverdraftLimit)
            {
                //cargo por sobregiro igual a la diferencia entre la cantidad
                //y la suma del saldo actual y el límite de sobregiro.
                return Math.Abs(amount) - (CurrentBalance() + OverdraftLimit);
            }
            else
            {
                return 0;
            }
        }
    }
}
