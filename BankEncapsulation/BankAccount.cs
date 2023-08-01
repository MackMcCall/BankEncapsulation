using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0;

        public void Deposit(double depositAmt)
        {
            _balance += depositAmt;
        }
        public void Withdraw(double withdrawalAmt)
        {
            _balance -= withdrawalAmt;
        }
        public double GetBalance()
        {
            return _balance;
        }
    }
}
