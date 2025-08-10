
using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nEternal Quest Goal Manager ");
            Console.WriteLine($"Current Score: {_score}");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create New Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine()?.Trim();

            switch (choice)
            {
                case "1": DisplayPlayerInfo(); break;
                case "2": ListGoalNames(); break;
                case "3": ListGoalDetails(); break;
                case "4": CreateGoal(); break;
                case "5": RecordEvent(); break;
                case "6": SaveGoals(); break;
                case "7": LoadGoals(); break;
                case "8": running = false; break;
                default: Console.WriteLine("Invalid choice. Try again."); break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYour current score is: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("\nGoal Names");
        if (_goals.Count == 0) { Console.WriteLine("No goals yet."); return; }

        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoal Details");
        if (_goals.Count == 0) { Console.WriteLine("No goals yet."); return; }

        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }

    public void CreateGoal()
    {
        
        Console.WriteLine("\nChoose goal type:");
        Console.WriteLine("1.Simple Goal");
        Console.WriteLine("2.Eternal Goal");
        Console.WriteLine("3.Checklist Goal");
        string typeChoice = Console.ReadLine()?.Trim();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string desc = Console.ReadLine();

        Console.Write("Enter points (integer): ");
        string pointsStr = Console.ReadLine();
        if (!int.TryParse(pointsStr, out _)) pointsStr = "0"; 

        Goal newGoal = null;

        switch (typeChoice)
        {
            case "1":
                newGoal = new SimpleGoal(name, desc, pointsStr, false);
                break;

            case "2":
                newGoal = new EternalGoal(name, desc, pointsStr);
                break;

            case "3":
                Console.Write("Enter target count : ");
                if (!int.TryParse(Console.ReadLine(), out int target)) { Console.WriteLine("Invalid target."); return; }

                Console.Write("Enter bonus points : ");
                if (!int.TryParse(Console.ReadLine(), out int bonus)) { Console.WriteLine("Invalid bonus."); return; }

               
                newGoal = new CheckListGoal(name, desc, pointsStr, 0, target, bonus);
                break;

            default:
                Console.WriteLine("Invalid type. Goal not created.");
                return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal created successfully!");
    }

    public void RecordEvent()
    {
        if (_goals.Count == 0) { Console.WriteLine("No goals to record."); return; }

        ListGoalNames();
        Console.Write("\nEnter goal number to record: ");
        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }

        Goal selected = _goals[choice - 1];

        selected.RecordEvent();

        
        int earned = selected.LastPointsAwarded;
        _score += earned;

        if (earned > 0)
            Console.WriteLine($"You earned {earned} points. Total score: {_score}");
        else
            Console.WriteLine($"No points were earned from '{selected.ShortName}'. Total score: {_score}");
    }

    public void SaveGoals()
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(filename)) filename = "goals.txt";

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
                writer.WriteLine(goal.GetStringRepresentation());
        }
        Console.WriteLine("Goals saved successfully!");
    }

    public void LoadGoals()
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(filename) || !File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        if (lines.Length == 0) { Console.WriteLine("Save file empty."); return; }

        if (!int.TryParse(lines[0], out _score)) _score = 0;

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split('|');
            if (parts.Length == 0) continue;

            string type = parts[0].Trim();

            try
            {
                if (type == "SimpleGoal" && parts.Length >= 5)
                {
                    string name = parts[1];
                    string desc = parts[2];
                    string pts = parts[3];
                    bool isComplete = bool.Parse(parts[4]);
                    _goals.Add(new SimpleGoal(name, desc, pts, isComplete));
                }
                else if (type == "EternalGoal" && parts.Length >= 4)
                {
                    string name = parts[1];
                    string desc = parts[2];
                    string pts = parts[3];
                    _goals.Add(new EternalGoal(name, desc, pts));
                }
                else if (type == "CheckListGoal" && parts.Length >= 7)
                {
                    string name = parts[1];
                    string desc = parts[2];
                    string pts = parts[3];
                    int amountCompleted = int.Parse(parts[4]);
                    int target = int.Parse(parts[5]);
                    int bonus = int.Parse(parts[6]);
                    _goals.Add(new CheckListGoal(name, desc, pts, amountCompleted, target, bonus));
                }
                else
                {
                    Console.WriteLine($"Skipping malformed line: {line}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading line: {line} => {ex.Message}");
            }
        }

        Console.WriteLine("Goals loaded.");
    }
}
