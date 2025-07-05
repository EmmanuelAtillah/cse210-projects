using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(0, 101);
      
        int userInput = 0;
        int numberOfGuesses = 0;

            while (userInput != magicNumber)
            {
                Console.Write("What is the magic number? ");
                userInput = int.Parse(Console.ReadLine());
                numberOfGuesses++;
                if (userInput > magicNumber)
                {
                    Console.WriteLine("Go lower");
                }
                else if (userInput == magicNumber)
                {
                    Console.WriteLine("Good!, You guessed it");
                }
                else
                {
                    Console.WriteLine("Go higher");
                }
            }

        Console.WriteLine($"You guessed {numberOfGuesses} times");
        
    }
}