public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        else
        {
            return 0;
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        if (_isComplete)
        {
            return "[X] " + _shortName + " (" + _description + ")";
        }
        else
        {
            return "[ ] " + _shortName + " (" + _description + ")";
        }
    }

    public override string GetStringRepresentation()
    {
        return "SimpleGoal|" + _shortName + "|" + _description + "|" + _points + "|" + _isComplete;
    }
}