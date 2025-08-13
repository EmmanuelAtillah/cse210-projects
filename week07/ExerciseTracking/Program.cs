using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;
        DateTime date = now.Date;

        Running running = new Running(date, 10, 32);
        Cycling cycling = new Cycling(date, 20, 30);
        Swimming swimming = new Swimming(date, 30, 100);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach(var actvity in activities) {
            Console.WriteLine(actvity.GetSummary());
        }
        

    }
}