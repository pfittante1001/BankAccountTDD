using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Saving : Account
    {
        public double MinBal { get; set; }
        public Saving()
        {
            //Default Constructor
        }

        public override void ShowTransaction()
        {
            Console.WriteLine("Your " + AcctType + " Account Balance = " + AcctBal);
        }

        public void MinBalance()
        {
            MinBal = 150.00;
        }
    }
}
