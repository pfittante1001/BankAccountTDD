using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        public double AcctBal { get; set; }
        public double Deposit { get; set; }
        public double Withdraw { get; set; }
        public string AcctType { get; set; }

        public Account()
        {
            //Default Constructor 
        }

        public Account(double v)
        {
            this.AcctBal = v;
        }

        public double GetWithdraw(double v)
        {
            this.Withdraw = v;
            AcctBal = AcctBal - Withdraw;
            return AcctBal;
        }

        public double GetDeposit(double v)
        {
            this.Deposit = v;
            AcctBal = AcctBal + Deposit;
            return AcctBal;
        }

        public virtual void ShowTransaction()
        {
        }
    }
}
