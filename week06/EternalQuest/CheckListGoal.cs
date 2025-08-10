// I displayed a prompt, when you want to record event for a goal which has already been completed
using System;

public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal(string shortName, string description, string points, int amountCompleted, int target, int bonus)
        : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;

            if (!int.TryParse(Points, out int basePts))
                basePts = 0;

            _lastPointsAwarded = basePts;

            if (_amountCompleted == _target)
            {
                
                _lastPointsAwarded += _bonus;
                Console.WriteLine($"Checklist goal '{ShortName}' completed! You earned {basePts} + bonus {_bonus} = {_lastPointsAwarded} points.");
            }
            else
            {
                Console.WriteLine($"Checklist goal '{ShortName}' progress: {_amountCompleted}/{_target}. You earned {_lastPointsAwarded} points.");
            }
        }
        else
        {
            _lastPointsAwarded = 0;
            Console.WriteLine($"Checklist goal '{ShortName}' already completed.");
        }
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        string checkBox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkBox} {ShortName} ({Description}) -- {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
       
        return $"CheckListGoal|{ShortName}|{Description}|{Points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}




// using System;

// public class CheckListGoal : Goal
// {
//     private int _amountCompleted;
//     private int _target;
//     private int _bonus;

//     // For gamification: XP and Level
//     private int _experiencePoints = 0;
//     private int _level = 1;
//     private int _xpToNextLevel = 100;  // Threshold for leveling up

//     // Assuming _lastPointsAwarded is declared in base Goal or declare here if missing:
//     // protected int _lastPointsAwarded;

//     // amountCompleted default 0
//     public CheckListGoal(string shortName, string description, string points, int amountCompleted, int target, int bonus)
//         : base(shortName, description, points)
//     {
//         _amountCompleted = amountCompleted;
//         _target = target;
//         _bonus = bonus;
//     }

//     public override void RecordEvent()
//     {
//         if (_amountCompleted < _target)
//         {
//             _amountCompleted++;

//             if (!int.TryParse(Points, out int basePts))
//                 basePts = 0;

//             _lastPointsAwarded = basePts;

//             // Award XP equal to base points for progress
//             _experiencePoints += basePts;

//             if (_amountCompleted == _target)
//             {
//                 // award bonus points and bonus XP when goal finishes
//                 _lastPointsAwarded += _bonus;
//                 _experiencePoints += _bonus * 2;  // XP bonus multiplier on completion

//                 Console.WriteLine($"Checklist goal '{ShortName}' completed! You earned {basePts} + bonus {_bonus} = {_lastPointsAwarded} points.");
//             }
//             else
//             {
//                 Console.WriteLine($"Checklist goal '{ShortName}' progress: {_amountCompleted}/{_target}. You earned {_lastPointsAwarded} points.");
//             }

//             CheckLevelUp();
//         }
//         else
//         {
//             _lastPointsAwarded = 0;
//             Console.WriteLine($"Checklist goal '{ShortName}' already completed.");
//         }
//     }

//     private void CheckLevelUp()
//     {
//         while (_experiencePoints >= _xpToNextLevel)
//         {
//             _experiencePoints -= _xpToNextLevel;
//             _level++;
//             _xpToNextLevel = (int)(_xpToNextLevel * 1.5);  // Increase XP needed for next level
//             Console.WriteLine($"🎉 '{ShortName}' leveled up! New Level: {_level}");

//             // Example level-based bonus: increase _bonus by 10% every level
//             _bonus = (int)(_bonus * 1.1);
//             Console.WriteLine($"Bonus increased to {_bonus} points per completion!");
//         }
//     }

//     public override bool IsComplete()
//     {
//         return _amountCompleted >= _target;
//     }

//     public override string GetDetailsString()
//     {
//         string checkBox = IsComplete() ? "[X]" : "[ ]";
//         return $"{checkBox} {ShortName} ({Description}) -- {_amountCompleted}/{_target} | Level: {_level} | XP: {_experiencePoints}/{_xpToNextLevel}";
//     }

//     public override string GetStringRepresentation()
//     {
//         // Add XP and level info in string representation if desired
//         // CheckListGoal|name|desc|points|amountCompleted|target|bonus|level|experiencePoints
//         return $"CheckListGoal|{ShortName}|{Description}|{Points}|{_amountCompleted}|{_target}|{_bonus}|{_level}|{_experiencePoints}";
//     }
// }

