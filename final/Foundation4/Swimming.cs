public class Swimming:Activity
{
    private int _laps;

    public Swimming()
    {

    }

    private void SetLaps()
    {
        Console.Write("Please enter the number of laps: ");
        _laps = int.Parse(Console.ReadLine());
    }

    private int GetLaps()
    {
        return _laps;
    }

    public override double CalculateDistance()
    {
        double distance = 0;
        if (GetMetric() == "km")
        {
            distance = GetLaps() * 50 / 1000;
        }
        else if (GetMetric() == "miles")
        {
            distance = GetLaps() * 50 / (1000 * 0.62);
        }
        return distance;
    }

    public override double CalculatePace()
    {
        double computePace = GetDuration() / CalculateDistance();
        return computePace;
    }
    
    public override double CalculateSpeed()
    {
        double computeLaps = (CalculateDistance() / GetDuration()) * 60;
        return computeLaps;
    }

    public void StartSwimming()
    {
        Start();
        SetLaps();
    }

}