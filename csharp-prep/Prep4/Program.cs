using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int userNumber = -1;

        do
        {
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);
            
            if(userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);
        
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        int largestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {largestNumber}");

    }
}