using System;

namespace OOPWithCSharp
{
    class BankAccount {

        private double balance;
        private string accountHolder;

        //Constructor of class
        public BankAccount(string holder, double initialBalance){

            accountHolder = holder;
            balance = initialBalance;


        }

        public double GetBalance() {

            return balance;
           
        }

        //Method to deposit money
        public void Deposit(double amount) {

           try {

             if (amount > 0) {

                balance += amount;
             
                    Console.WriteLine($"{amount} deposited. New Balance: {balance}");
             
                }else {
              
                    Console.WriteLine("Deposit amount must be positive !");
             }

            }catch(Exception e) {
                Console.WriteLine("Invalid amount !"+e.Message);
            }
        }

        public virtual void WithDraw(double amount) {

            if (amount > 0 && amount <= balance) {

                balance -= amount;
                Console.WriteLine($"{amount} withdrawn. New Balance: {balance}");
            }else {

                Console.WriteLine("Invalid withdrawn amount OR insufficient balance.");
            }
        }

    }

    // Derived class  SavingsAccount with specific behavior
    class SavingsAccount : BankAccount {

        private double interestRate;

            // Constructor 
           public SavingsAccount(string holder, double initialBalance , double rate)
           :base(holder,initialBalance) { // Call the base class constructor
                                          // providing their required values to prepare 
                                          // that class so i can inherit and use them
                                          // in this class!!!
                interestRate = rate;

           }

        // Method to apply interest 
        public void ApplyInterest() {

            double interest = GetBalance() * interestRate;

            Deposit(interest); // Deposit interest into balance
            Console.WriteLine($"Interest of {interest} applied.");

        }


    }

    class CheckingAccount : BankAccount {

        private double overdraftLimit;
        
        // Constructor
        public CheckingAccount(string holder , double initialBalance , double overdraft)
            :base(holder,initialBalance) {

            overdraftLimit = overdraft;
        }


        public override void WithDraw(double amount) {

            if (amount  > 0 && amount <= (GetBalance() + overdraftLimit)) {
                
                base.WithDraw(amount); // Call the base class's Withdraw method

            }
            else {

                Console.WriteLine("Overdraft limit exceeded.");
            }
        }
    }

}