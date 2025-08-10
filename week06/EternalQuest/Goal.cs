
using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;


    protected int _lastPointsAwarded;

    
    protected Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description ;
        _points = points ?? "0";
        _lastPointsAwarded = 0;
    }

    
    public string ShortName => _shortName;
    public string Description => _description;
    public string Points => _points;

 
    public int LastPointsAwarded => _lastPointsAwarded;

   
    public abstract void RecordEvent();

    public abstract bool IsComplete();

   
    public virtual string GetDetailsString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {ShortName} ({Description})";
    }

    public abstract string GetStringRepresentation();
}
