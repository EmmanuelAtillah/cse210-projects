using System;

// I gave the user an option to choose wheather 
// he/she want to see the first letters of the disappeared words


class Program
{
    static void Main()
    {
        
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string verseText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";

        Scripture scripture = new Scripture(reference, verseText);

        Console.WriteLine("Do you want to show the first letter of hidden words? (y/n)");
        bool showFirstLetter = Console.ReadLine().Trim().ToLower() == "y";

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText(showFirstLetter));

            Console.WriteLine("\nPress [Enter] to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText(showFirstLetter));
        Console.WriteLine("\nAll words hidden or user exited.");
    }
}
