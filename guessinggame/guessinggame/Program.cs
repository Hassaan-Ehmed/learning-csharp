using System;

namespace MyGuessGame
{

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String response = "";
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;


            while (playAgain)
            {


                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1); // ends number excluded (1 to 100)

                while (guess != number)
                {
                    Console.WriteLine($"Guess the number between {min} - {max}: ");

                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Guess: {guess}");

                    if (guess > number)
                    {
                        Console.WriteLine($"{guess} is too high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine($"{guess} is too low!");

                    }
                    guesses++;


                }

                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guessess: " + guesses);

                Console.WriteLine("would you like to play again (Y/N)");
                response  = Console.ReadLine();
                response = response.ToUpper();
                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }


            Console.WriteLine("Thank you for playing!!");

        }
    }
}
