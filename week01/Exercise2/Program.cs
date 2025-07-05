using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        string sign = "";

        Console.Write("Please enter your marks: ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        // Determine letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        
        int gradeSign = grade % 10;

        
        if (letter != "F")
        {
            if (gradeSign >= 7)
            {
                sign = "+";
            }
            else if (gradeSign < 3)
            {
                sign = "-";
            }

            
            if (letter == "A" && sign == "+")
            {
                sign = "";
            }
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations. You passed the course");
        }
        else
        {
            Console.WriteLine("SORRY to say, You fell below the pass mark. Better luck next time");
        }
    }
}
