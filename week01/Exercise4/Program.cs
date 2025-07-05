using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userInput = 1;
        int total = 0;
        int numberOfNumbers = 0;
        int max = 0;
      



        Console.WriteLine("Enter the list of numbers, type 0 when finished");

        while (userInput != 0)
        {
            Console.Write("Enter the number: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0)
            {
                numbers.Add(userInput);
                numberOfNumbers++;


            }
        }
        foreach (int number in numbers)
        {
            total += number;

            if (number > max)
            {
                max = number;
            }
        }

        double avg = (double)total / numberOfNumbers;
        Console.WriteLine(numberOfNumbers);
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");

    }
}