using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IWayCsTraining
{
    //Design a BankAccount class with attributes accountNumber, balance, and accountHolderName.
    //Implement methods for deposit, withdrawal, and checking balance.
    //Incorporate error handling for insufficient balance.
    class BankAccount
    {
        int accountNumber;
        private double balance;
        string accountHolderName;

        //properties
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        } 

        public BankAccount(string name, int accoutNo)
        {
            accountHolderName = name;
            accountNumber = accoutNo;
        }

        public void Deposit(double amountToBeDeposited)
        {
            balance += amountToBeDeposited;
        }

        public double CheckBalance()
        {
            return balance;
        }

        public void Withdrawal(double amountToBeWithdrawn)
        {
            if(balance < amountToBeWithdrawn)
            {
                Console.WriteLine("You have insufficient funds in your account.");
            }
            else
            {
                balance -= amountToBeWithdrawn;
                Console.WriteLine($"Rs. {amountToBeWithdrawn} have been debited from your account.");
                Console.WriteLine($"Your new account balance is: {CheckBalance()}");
            }
        }
    }
}
