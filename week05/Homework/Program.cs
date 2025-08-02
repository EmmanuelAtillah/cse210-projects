using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Emmamuel", "Substitution");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Emmanuel Atillah", "Algebra", "92.5", "12 -24");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("The Causes of World War II", "Emmanue Atillah", "Indices");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());




    }
}