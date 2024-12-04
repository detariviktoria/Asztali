using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DV_Bank
{
    internal class BankAccount
    {
        //adattagok
        private string accountHolder, accountNumber;
        private double balance;
        private int accountCount;

        // Getterek, Setterek
        public string AccountHolder
        {
            get;
            private set;
        }

        public string AccountNumber
        {
            get;
            private set;
        }
        public double Balance
        {
            get;
            private set;
        }

        //Konstruktorok
        public BankAccount(string accountHolder, string accountNumber, double balence)
        {
            this.accountHolder = accountHolder;
            this.accountNumber = accountNumber;
            this.balance = balence;
        }

        public BankAccount(string nev)
        {
            nev = accountHolder;
            nev = accountHolder;
            accountNumber = "";
            balance = 0;
        }
        
        public int GetAccountCount()
        {
            return accountCount;
        }

        public void Deposit(double osszeg)
        {
            balance += osszeg;
            accountCount++;
        }

        public void Withdraw(double osszeg)
        {
            if(balance-osszeg >=0)
            {
                balance -= osszeg;
                accountCount++;
            }
        }

        public override string ToString()
        {
            return string.Format("Nev: {0}, Egyenleg: {1}, Szamlaszám: {2}, Szamlak: {3}", accountHolder, balance, accountNumber, accountCount);
        }
    }
}
