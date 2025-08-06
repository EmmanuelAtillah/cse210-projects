using System.Runtime.Intrinsics.Arm;

public class Activity
{
  private string _name;
  private string _description;
  private int _duration;

  public Activity(){}
  public Activity(string name, string description, int duration)
  {
    _name = name;
    _description = description;
    _duration = duration;
  }

  public int GetDuration()
  {
    return _duration;
  }

  public void DisplayStartingMessage()
  {
    Console.Clear();
    Console.WriteLine($"Welcome to the {_name}");
    Console.WriteLine(_description);
    Console.Write("How long in seconds would you like for your session: ");
    string input = Console.ReadLine();

    while (!int.TryParse(input, out _duration) || _duration <= 0)
    {
      Console.Write("Invalid input. Please enter a positive number: ");
      input = Console.ReadLine();
    }

    Console.WriteLine("\nGet ready to begin...");
    ShowSpinner(5);


  }


  public void DisplayEndingMessage()
  {
    Console.WriteLine("You have done a good job");
    ShowSpinner(5);
    Console.WriteLine($"You have completed {_name} in {_duration} in seconds");
    ShowSpinner(5);
    Console.WriteLine("Welldone");
    
  }
  public void ShowSpinner(int seconds)
  {
    List<string> animationString = new List<string>();
    animationString.Add("|");
    animationString.Add("/");
    animationString.Add("-");
    animationString.Add("\\");
    animationString.Add("|");
    animationString.Add("/");
    animationString.Add("-");
    animationString.Add("\\");
    
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(seconds);
    int i = 0;
    while (DateTime.Now < endTime)
    {
      string s = animationString[i];

      Console.Write(s);
      Thread.Sleep(1000);
      Console.Write("\b \b");
      i++;

      if (i >= animationString.Count)
      {
        i = 0;

      }

    }

  }
  public void ShowCountDown(int seconds)
  {
    for (int i = 5; i > 0; i--)
    {
      Console.Write(i);
      Thread.Sleep(1000);
      Console.Write("\b \b");
    }

  }


}