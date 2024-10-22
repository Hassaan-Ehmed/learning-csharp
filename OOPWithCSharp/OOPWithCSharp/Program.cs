using System;

namespace OOPWithCSharp
{

   class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World !!");

            //int count = 0;
            //Player tommy = new Player();

            //Console.WriteLine($"Hey, {tommy.name} your helath is {tommy.getHealth()}%\a");

            //tommy.setHealth(tommy.getHealth() + 5);

            //Console.WriteLine($"After Midkit +5 point, {tommy.name} now your helath is {tommy.getHealth()}%\a");

            //do
            //{
            //    Console.Beep();
            //    count++;

            //}while(count <= 5 );


            // creating a savings account
            SavingsAccount mySavings = new SavingsAccount("Harry", 1000, 0.05);

            Console.WriteLine("Amount: " + mySavings.GetBalance());
            mySavings.Deposit(415);
            mySavings.WithDraw(200);

            mySavings.ApplyInterest(); // Apply interest


            Console.WriteLine($"Final balance in saving account: {mySavings.GetBalance()}");


            // creating a checking
            CheckingAccount myChecking = new CheckingAccount("Mahnoor", 500, 200);
                                                            // 200 is overdraft limit

            myChecking.Deposit(300);
            myChecking.WithDraw(700);// Can withdraw up to balance + overdraft limit
            myChecking.WithDraw(350); // Should trigger overdraft exceeded

            Console.WriteLine($"Final balance in saving account: {mySavings.GetBalance()}");

        }
    }

}



                                               
