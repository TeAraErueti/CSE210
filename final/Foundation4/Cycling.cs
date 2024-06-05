public class Cycling:Activity
{
    private int _cyclingSpeed;

    public Cycling()
    {

    }
    
    private void SetCyclingSpeed()
    {
        Console.Write("Please enter your cycling speed: ");
        _cyclingSpeed = int.Parse(Console.ReadLine());
    }

    private int GetCyclingSpeed()
    {
        return _cyclingSpeed;
    }

    public override double CalculateDistance()
    {
        double distance = 0;
        if (GetMetric() == "km")
        {
            distance = GetCyclingSpeed() * GetDuration() / 1000;
        }
        else if (GetMetric() == "miles")
        {
            distance = GetCyclingSpeed() * GetDuration() / (1000 * 0.62);
        }
        return distance;
    }

    public override double CalculatePace()
    {
        double computePace = (GetDuration() / CalculateDistance());
        return computePace;
    }

    public override double CalculateSpeed()
    {
        double computeSpeed = (CalculateDistance() / GetDuration()) * 60;
        return computeSpeed;
    }

    public void StartCycling()
    {
        Start();
        SetCyclingSpeed();
    }

}