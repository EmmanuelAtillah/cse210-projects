using System.Security.Cryptography.X509Certificates;

public class ListingActivity : Activity
{
  private int _count;
  private List<string> _prompts;

  public ListingActivity(string name, string description, int duration, int count, List<string> prompts) : base(name, description, duration)
  {
    _count = count;
    _prompts = prompts;

  }


  public void Run()
  {

    DisplayStartingMessage();
    GetRandomPrompt();
    ShowCountDown(5);
    GetListFromUser(GetDuration());
    Console.WriteLine($"You listed {_count} items");
    DisplayEndingMessage();

 }
  public List<string> GetPrompts()
  {
    return _prompts;
}

  public void GetRandomPrompt()
  {
    _prompts = new List<string>()
    {
      "Who are people that you appreciate?",
      "What are personal strengths of yours?",
      "Who are people that you have helped this week?",
      "When have you felt the Holy Ghost this month?",
      "Who are some of your personal heroes?"
    };

    Random random = new Random();
    int index = random.Next(_prompts.Count);

    Console.WriteLine(_prompts[index]);

  }

  public List<string> GetListFromUser(int duration)
{
    List<string> userList = new List<string>();
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(duration);

    Console.WriteLine("Start listing items! Press Enter after each. Time starts now:");

    while (DateTime.Now < endTime)
    {
       
            string input = Console.ReadLine();
      if (!string.IsNullOrWhiteSpace(input))
      {
        userList.Add(input);
        _count++;
            }
    }

    return userList;
}


}