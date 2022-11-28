using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment02
{
    class Account
    {
        long accNo;
        double bal;
        string[] payees;
        long[] payeesAccount;

        public Account(long accNo, double bal)
        {
            this.accNo = accNo;
            this.bal = bal;
        }

        public Account(long accNo, double bal, string[] payees, long[] payeesAccount)
        {
            this.accNo = accNo;
            this.bal = bal;
            this.payees = payees;
            this.payeesAccount = payeesAccount;
        }

        public bool DebitAmount(double amount)
        {
            if(amount<=this.bal)
            {
                this.bal = this.bal - amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransferMoney(long payeesAccNo, double amount)
        {
            foreach (var item in payeesAccount)
            {
                DebitAmount(amount);
                return true;
            }
            return false;
        }

        public bool TransferMoney(String payee, double amount)
        {
            foreach (var item in payees)
            {
                DebitAmount(amount);
                return true;
            }
            return false;
        }
        class program
        {
            static void Main(String[] args)
            {
                long accNo=123;
                double bal=10000;
                string[] payees= { "Thomas Shelby", "Aurthor Shelby" };
                long[] payeesAccount= { 123, 456 };

                Account account = new Account(accNo, bal);
                new Account(accNo, bal, payees, payeesAccount);

                account.TransferMoney(accNo, 5000);

                account.TransferMoney("Thomas Shelby", 2000);
            }
        }

    }
}
