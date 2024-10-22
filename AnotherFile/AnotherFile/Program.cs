using System;

namespace AnotherFile
{

    class Program
    {
        static void Main(string[] args)
        {
            string name = "Hassaan";
            int age= 20;
            // 0 for rows 1 for column (Length) not working here cause it's multi dimension 😎

            //int[,] arrOfNumz = { // 3 rows (each column contain 3 elements)
            //                                 { 1 , 2 , 3 },
            //                                 { 0 , 9 , 8 },
            //                                 { 5 , 6 , 1}
            //                    };

            //for (int i = 0; i < arrOfNumz.GetLength(0); i++ ){ // outer , please run dimension 0 ->(howManyRows) 

            //    if (i != 0) Console.WriteLine($"\n");

            //    for(int j=0; j < arrOfNumz.GetLength(1); j++) { 

            //    Console.Write($"{arrOfNumz[i, j]}");
            //    Console.Write("\t");
            //    }

            //    Console.WriteLine();
            //}



            //double totalValue = CheckOut(19.45,8.58,87); 
            //Console.WriteLine("Total payment " + totalValue);

            Messages.Hello();
            Messages.Waiting();
            Messages.Bye();
            
        }

        static void singForBirtday(String name,int age)
        {

            Console.WriteLine("Happy Birthday to you"+name);
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday to dear");
            Console.WriteLine("Happy Birthday to you!!");

            Console.WriteLine("your age is :"+age);
        }

       static double CheckOut(params double[] prices)
        {

            double total = 0;

            foreach (double price in prices) {

                total += price;
            }

            return total;
           

        } 

    }
}