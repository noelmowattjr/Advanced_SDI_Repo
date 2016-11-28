using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Demo
{
    class User
    {
        static int _NumUsers = 0;

        private string _Name;
        private Account _Account;

        public User(string userName)
        {
            // Setting the field directly instead of using the property
            _Name = userName;
            _NumUsers = _NumUsers + 1;
        }
        // Create a property to access the user's name
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                // Always want the name to be upper case
                _Name = value.ToUpper();
            }
        }

        public Account Acct
        {
            get
            {
                return _Account;
            }
            set
            {
                _Account = value;
            }
        }

        public static int GetNumUsers()
        {
            return _NumUsers;
        }
    }
}
