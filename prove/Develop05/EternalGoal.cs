public class EternalGoal : Goal
{
    private string _typeOfGoal;
    private bool _isComplete = false;

    public EternalGoal(string name, string description, int points, string goal) : base(name, description, points)
    {
        _typeOfGoal = goal;
    }

    public override void RecordEvent()
    {
        if (IsComplete())
        {
            AddSetPointToCurrentPoint();
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void SetIsCompleteToTrue()
    {
        _isComplete = true;
    }


    public override string GetStringRepresentation()
    {
        return $"{_typeOfGoal}: {_shortName} | {_description} | {_setPoints} | {IsComplete()}";
    }

}