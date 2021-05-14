using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int lowerbound;
            int higherBound;
            int counter = 5;
            int userInput;

            Random random = new Random();
            number = random.Next(0, 100);
            lowerbound = random.Next(number - 10, number);
            higherBound = random.Next(number + 1, number + 10);

            Console.WriteLine($"Guess the secret number, it's higher than {lowerbound}, and lower that {higherBound}");
            while (counter-- > 0)
            {
                Console.Write("Type here the number you're trying to guess: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == number)
                {
                    Console.WriteLine("CORRECT");
                    break;
                }
                else
                {
                    Console.WriteLine("WRONG!");
                }
            }
            if (counter < 0)
            {
                Console.WriteLine("Sorry you've lost!");
                Console.WriteLine($"The secret number was {number}");
            }
        }
    }
}
