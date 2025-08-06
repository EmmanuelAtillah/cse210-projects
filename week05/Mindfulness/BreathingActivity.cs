
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description,  duration) { }

  public void Run()
  {
    DisplayStartingMessage();

    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(GetDuration());

    while (DateTime.Now < endTime)
    {
      Console.WriteLine("\nBreathe in... ");
      ShowCountDown(5);

      if (DateTime.Now >= endTime) break;

      Console.WriteLine("\nBreathe out... ");
      ShowCountDown(5);
    }

    DisplayEndingMessage();

    }
}
