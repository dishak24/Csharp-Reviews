using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review3
{
    internal class WithdrawTransaction
    {
        BankAccount bankAccount = new BankAccount(1000);

        public void Transaction()
        {
            Console.WriteLine("-----------------Bank Application------------------ \n\n");
            try
            {
                Console.WriteLine("Enter your Withdrawal Amount :");
                bankAccount.WithdrawMoney(Convert.ToDouble(Console.ReadLine()));
            }
            catch(InsufficientFundsException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
