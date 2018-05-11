using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class Client
    {
        public abstract string FName { get; set; }
        public abstract string LName { get; set; }
        public abstract string AcctNum { get; set; }

        public abstract string ShowClient();
        

       
    }
}
