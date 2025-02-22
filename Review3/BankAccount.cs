using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    internal class BankAccount
    {
        private double balance;
        public BankAccount( double balance)
        {
            this.balance = balance;
        }

        public void WithdrawMoney( double amount)
        {
            if ( balance < amount )
            {
                throw new InsufficientFundsException("Insufficient Balance in your accout. You cannot withdraw !!!");
            }

            else
            {
                balance -= amount;
                Console.WriteLine(" Withdraw Successfull. ");
                Console.WriteLine($"Available Balance : {balance}");
            }
        }


    }
}
