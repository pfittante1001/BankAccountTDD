using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Test
{
    [TestFixture]
    class BankAccountTests
    {
        [Test]
        public void Test_Client_CTR()
        {
            var custOne = new ClientInfo(" ", " ", " ");
            var response = custOne.FName;
            Assert.That(response, Is.EqualTo(" "));
        }
        [Test]
        public void Test_LName_Prop()
        {
            var custOne = new ClientInfo();
            var response = custOne.LName = " ";
            Assert.That(response, Is.EqualTo(" "));
        }
        [Test]
        public void Test_AccountNum_Prop()
        {
            var custOne = new ClientInfo();
            var response = custOne.AcctNum = " ";
            Assert.That(response, Is.EqualTo(" "));
        }
        [Test]
        public void Test_Client_Menu_CTR()
        {
            var custOne = new ClientInfo("Pete", "Fittante", "0101010");
            var response = custOne.ShowClient();
            Assert.That(response, Is.EqualTo("Welcome Pete Fittante.Your account number is 0101010"));
        }
        [Test]
        public void Test_Account_CTR()
        {
            var acct = new Account();
            var response = acct.AcctBal = 0;
            Assert.That(response, Is.EqualTo(0));
        }
        [Test]
        public void Test_Account_CTR_1_Para()
        {
            var acct = new Account(0);
            var response = acct.AcctBal;
            Assert.That(response, Is.EqualTo(0));
        }
        [Test]
        public void Test_Deposit_Prop()
        {
            var acct = new Account();
            var response = acct.Deposit = 0;
            Assert.That(response, Is.EqualTo(0));
        }
        [Test]
        public void Test_WithDraw_Prop()
        {
            var acct = new Account();
            var response = acct.Withdraw = 0;
            Assert.That(response, Is.EqualTo(0));
        }
        [Test]
        public void Test_WithDraw_Method()
        {
            var acct = new Account();
            var response = acct.GetWithdraw(0);
            Assert.That(response, Is.EqualTo(0));
        }
        [Test]
        public void Test_Deposit_Method()
        {
            var acct = new Account();
            var response = acct.GetDeposit(0);
            Assert.That(response, Is.EqualTo(0));
        }
        [Test]
        public void Test_Account_Type_Prop()
        {
            var acct = new Account();
            var response = acct.AcctType = " ";
            Assert.That(response, Is.EqualTo(" "));
        }
        [Test]
        public void Test_Checking_Account_CTR()
        {
            var ckAcct = new Checking();
            var response = ckAcct.AcctBal = 110;
            Assert.That(response, Is.EqualTo(110));
        }
        [Test]
        public void Test_Checking_Deposit_Method()
        {
            var ckAcct = new Checking();
            ckAcct.AcctBal = 5;
            ckAcct.GetDeposit(110);
            var response = ckAcct.AcctBal;
            Assert.That(response, Is.EqualTo(115));
        }
        [Test]
        public void Test_Checking_Withdraw_Method()
        {
            var ckAcct = new Checking();
            ckAcct.AcctBal = 200;
            ckAcct.GetWithdraw(100);
            var response = ckAcct.AcctBal;
            Assert.That(response, Is.EqualTo(100));
        }
        [Test]
        public void Test_Min_Balance_Prop()
        {
            var savAcct = new Saving();
            var response = savAcct.MinBal = 150;
            Assert.That(response, Is.EqualTo(150));
        }
    }
}
