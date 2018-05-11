using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class ClientInfo : Client
    {
        public ClientInfo()
        {
            //Default Constructor
        }

        public ClientInfo(string v1, string v2, string v3)
        {
            this.FName = v1;
            this.LName = v2;
            this.AcctNum = v3;
        }

        public override string FName { get; set; }
        public override string LName { get; set; }
        public override string AcctNum { get; set; }

        public override string ShowClient()
        {
            var response = ("Welcome " + FName + " " + LName + "." + "Your account number is " + AcctNum);
            return response;
        }
    }
}
