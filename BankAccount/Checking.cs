using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Checking: Account
    {
        public Checking()
        {
            //Default Constructor
        }

        public override void ShowTransaction()
        {
            Console.WriteLine("Your " + AcctType + " Account Balance = " + AcctBal);
        }
    }
}
