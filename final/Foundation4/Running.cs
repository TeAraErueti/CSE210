public class Running:Activity
{
    private double _runningDistance;

    public Running()
    {
        
    }

    private void SetRunningDistance()
    {
        Console.Write("Please enter the distance you ran: ");
        _runningDistance = double.Parse(Console.ReadLine());
    }

    private double GetRunningDistance()
    {
        return _runningDistance;
    }

    public override double CalculateDistance()
    {
        double distance = 0;
        if (GetMetric() == "km")
        {
            distance = GetRunningDistance() * GetDuration() / 1000;
        }
        else if (GetMetric() == "miles")
        {
            distance = GetRunningDistance() * GetDuration() / (1000 * 0.62);
        }
        return distance;
    }

    public override double CalculatePace()
    {
        double computePace = GetDuration() / GetRunningDistance();
        return computePace;
    }

    public override double CalculateSpeed()
    {
        double computeSpeed = (GetRunningDistance() / GetDuration()) * 60;
        return computeSpeed;
    }

    public void StartRunning()
    {
        Start();
        SetRunningDistance();
    }

}