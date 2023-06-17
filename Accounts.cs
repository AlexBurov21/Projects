using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Account 
    {
        public Account(string username, string password, int balance, int failedAttempts, int moneyOnHand)
        {
            this.username = username;
            this.password = password;
            this.balance = balance;
            this.failedAttempts = failedAttempts;
            this.moneyOnHand = moneyOnHand;
        }
        public string username { get; set; }
        public string password { get; set; }
        public int balance { get; set; }
        public int failedAttempts { get; set; }

        public int moneyOnHand { get; set; }
    }
            
}
