using System;

namespace GuessThatNum
{
    class Program
    {
        static void Main(string[] args)
        {

            bool isCorrectChoice = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);

            Console.WriteLine("Welcome to the number guessing game.");
            Console.WriteLine("A number between 1 and 10 will be generated");
            Console.WriteLine("If you guess right, then you win");

            while (!isCorrectChoice)
            {
                Console.WriteLine("Please enter your guess: ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNum)
                {
                    Console.WriteLine("Your guess is too hi.");
                }
                else if(guess < randomNum)
                {
                    Console.WriteLine("Guess too low");

                }
                else
                {
                    Console.WriteLine("right on!");
                    isCorrectChoice = true;
                }
            }
            Console.WriteLine("You won!!!");
            Console.ReadKey();

        }
    }
}
