﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1
{

    internal class Account
    {
        public decimal balance;
        private String name;

        //constructor
        public Account(String name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }



        //deposit method
        public bool Deposit(decimal amount)
        {
            

            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine();
                Console.WriteLine($"Amount deposited successfully");
                Console.WriteLine($"Account Balance after Depositing {amount:C}: {balance:C}");
                return true; // deposit is a success
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Amount entered for deposit {amount}");
                Console.WriteLine("Invalid deposit amount. Please enter a positive value");
                return false; // deposit failed 
            }
        }

        //withdraw method
        public bool Withdraw(decimal amount)
        {

            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                Console.WriteLine();
                Console.WriteLine("Withdraw successful");
                Console.WriteLine($"Account Balance after Withdrawing {amount:C}: {balance:C}");
                return true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Amount entered for withdrawal {amount}");
                Console.WriteLine("Your account has Insufficient balance or Invalid withdrawal amount. Please enter a positive value.");
                return false;
            }
        }

       /* public bool Transfer(Account toAccount, decimal amount)
        {
            TransferTransaction transferTransaction = new TransferTransaction(this, toAccount, amount);

            // Execute the transfer transaction
            transferTransaction.Execute();

            // Print the details of the transfer
            transferTransaction.Print();

            return true;
        }*/

        // method to print the name and balance
        public void Print(Account myAccount, Account myAccount2)
        {
            Console.WriteLine("");
            Console.WriteLine($"Account Holder Name: {myAccount.Name}");
            Console.WriteLine($"Account Balance: {myAccount.balance:C}");
            Console.WriteLine();
            Console.WriteLine($"Account Holder2 Name: {myAccount2.Name}");
            Console.WriteLine($"Account Balance: {myAccount2.balance:C}");
        }

        // property to get account name
        public String Name
        {
            get
            {
                return name;
            }
        }

    }
}
