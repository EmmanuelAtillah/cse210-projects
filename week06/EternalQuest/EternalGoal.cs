
using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points)
        : base(shortName, description, points)
    { }

   
    public override void RecordEvent()
    {
        if (!int.TryParse(Points, out int pts))
            pts = 0;

        _lastPointsAwarded = pts;
        Console.WriteLine($"Eternal goal '{ShortName}' recorded. You earned {_lastPointsAwarded} points.");
    }

    public override bool IsComplete() => false;

    public override string GetStringRepresentation()
    {
       
        return $"EternalGoal|{ShortName}|{Description}|{Points}";
    }
}
