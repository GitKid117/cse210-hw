using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int percentage = int.Parse(grade);
        string letter;

        if (percentage >= 90)
        {
            letter = "A";
            Console.WriteLine("You passed, congratulations!");
        }
        else if (percentage >= 80)
        {
            letter = "B";
            Console.WriteLine("You passed, congratulations!");
        }
        else if (percentage >= 70)
        {
            letter = "C";
            Console.WriteLine("You passed, congratulations!");
        }
        else if (percentage >= 60)
        {
            letter = "D";
            Console.WriteLine("You did not pass, try again.");
        }
        else
        {
            letter = "F";
            Console.WriteLine("You did not pass, try again.");
        }

        Console.WriteLine($"You got a {letter}");


    }
}