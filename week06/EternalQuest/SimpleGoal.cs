// I displayed a prompt, when you want to record event for a goal which has already been completed
using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortName, string description, string points, bool isComplete = false)
        : base(shortName, description, points)
    {
        _isComplete = isComplete;
    }

  
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;

            if (!int.TryParse(Points, out int pts))
                pts = 0;

            _lastPointsAwarded = pts;

            Console.WriteLine($"Simple goal completed: {ShortName}. You earned {_lastPointsAwarded} points.");
        }
        else
        {
            _lastPointsAwarded = 0;
            Console.WriteLine($"Simple goal '{ShortName}' was already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{ShortName}|{Description}|{Points}|{_isComplete}";
    }
}
