using System;

class Program
{
    static void Main()
    {
        Random roulette = new Random();

        int randomNumber = roulette.Next(1, 101);

        int guess = 0;
        int attempts = 0;

        while (guess != randomNumber)
        {
            Console.Write("What is your guess? ");
            
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                attempts++;

                if (guess < randomNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > randomNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {attempts} attempts.");
                }
            }
            else
            {
                Console.WriteLine("Please, type a valid number.");
            }
        }
    }
}

