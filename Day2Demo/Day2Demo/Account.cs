using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Demo
{
    class Account
    {
        bool _IsCheckingAccount;
        decimal _Balance;

        public Account(bool ThisIsACheckingAccount, decimal StartingBalance)
        {
            // Usig the properties to modify the fields

            IsCheckingAccount = ThisIsACheckingAccount;
            Balance = StartingBalance;
        }

        public bool IsCheckingAccount
        {
            get
            {
                return _IsCheckingAccount;
            }
            // private set so that only the account class can modify this field
            private set
            {
                _IsCheckingAccount = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                _Balance = value;
            }
        }
    }
}
