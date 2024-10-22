using System;

namespace MyFirstProgram

{
    class Program
    {

        static void Calulator()
        {
            try
            {
                Console.WriteLine("Enter fisrt number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Beep();

                Console.WriteLine("Enter second number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Beep();

                Console.WriteLine("which operation you want to perform ??");
                //char op = Convert.ToChar( Console.ReadLine() ) ;
                char op = '+';
                Console.Beep();

                int result = 0;


                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + result);

                        break;

                    case '-':
                        result = num1 - num2;
                        Console.WriteLine("The minus of " + num1 + " and " + num2 + " is " + result);
                        result = 0;
                        break;


                    case '/':
                        result = num1 / num2;
                        Console.WriteLine("The division of " + num1 + " and " + num2 + " is " + result);
                        result = 0;
                        break;


                    case '*':
                        result = num1 * num2;
                        Console.WriteLine("The multiplication of " + num1 + " and " + num2 + " is " + result);
                        result = 0;
                        break;


                    case '%':
                        result = num1 + num2;
                        Console.WriteLine("The modulous of " + num1 + " and " + num2 + " is " + result);
                        result = 0;
                        break;


                    default:
                        Console.WriteLine("Invalid input!!");
                        break;






                }


            }
            catch (Exception e)
            {
                Console.WriteLine("Error while making calculations !!" + e);
            }
        }

        static void Main(string[] args)
        {


            
            Console.WriteLine("Hello World!!\a");

            Calulator();


            //const string name = "Hassaan"; // 2 bytes/character
            //char identificationAlpha = 'A'; // 2 bytes
            //int userAge = 20; // 4 bytes
            //long yearsOfYear = 1219231230213L; //; 8 bytes
            //float estimateAmount = 87.81F; // 4 bytes
            //double prodcutPrice = 24874219.88D; // 8 bytes
            //bool isMarried = false; // 1bit

            //Console.WriteLine("Hi, my name is " + name + " and my age is " + userAge + " It's " + isMarried+" that I'm married😅");

            //Console.WriteLine("Thank you !!");

            //Console.WriteLine($"Enter your name");
            //string userName  = Convert.ToString(Console.ReadLine());

            Console.Beep();

            //int charPos = userName.IndexOf(" ");

            //similart to JS template literal syntax for string concatination in better way  in C#, We have 'string interpolation'

            //Console.WriteLine($"Hey ,{userName.Substring(charPos)}");



            //int [,] numz = { { 1,5,7} , { 8,3,9 } };

            //Console.WriteLine($"Access the element of an Array:: {numz.GetType()}");


        }
    }
}