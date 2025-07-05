using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareTheNumber(number);
        DisplayResult(userName, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareTheNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Brother {name}, the square of your number is: {squaredNumber}");
    }
}
