using System;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // Abstract methods must be overridden by derived classes
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    // Virtual method can be overridden if needed, but has a default behavior
    public virtual string GetDetailsString()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} {_shortName} ({_description})";
    }

    public string GetName()
    {
        return _shortName;
    }
    
    public int GetPoints()
    {
        return int.Parse(_points);
    }
}