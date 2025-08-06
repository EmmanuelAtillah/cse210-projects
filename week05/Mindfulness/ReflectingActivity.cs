// I maked sure that none of the questions are repeated untill all are displayed

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        ShowSpinner(4);
        DisplayQuestions();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestions(List<string> remainingQuestions)
    {
        Random random = new Random();
        int index = random.Next(remainingQuestions.Count);
        string question = remainingQuestions[index];
        remainingQuestions.RemoveAt(index); 
        return question;
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine("\nTake a minute to reflect on the following prompt:");
        Console.WriteLine($"--{prompt}--\n");
    }

    private void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());

        List<string> remainingQuestions = new List<string>(_questions);

        while (DateTime.Now < endTime)
        {
            if (remainingQuestions.Count == 0)
            {
                remainingQuestions = new List<string>(_questions); 
            }

            string question = GetRandomQuestions(remainingQuestions);
            Console.WriteLine($">>> {question}");
            ShowSpinner(8);
            Console.WriteLine();
        }
    }
}
