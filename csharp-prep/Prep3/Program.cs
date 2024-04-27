using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        string response = Console.ReadLine();
        int guess = int.Parse(response);

        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            Console.Write("What is your guess? ");
            response = Console.ReadLine();
            guess = int.Parse(response);
        }
        Console.WriteLine("You guessed it!");

    }
}