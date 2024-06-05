public abstract class Activity
{
    private DateTime _date = DateTime.Now;
    private string[] _month = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"};
    private int _duration;
    private string _name;
    private double _distance;
    private double _speed;
    private double _pace;
    private string _metric;

    public Activity()
    {

    }

    private void SetName()
    {
        Console.Write("Please enter the exercise name: ");
        _name = Console.ReadLine();
    }

    private string GetName()
    {
        return _name;
    }

    private void SetDuration()
    {
        Console.Write("Please enter the duration of your exercise in minutes: ");
        _duration = int.Parse(Console.ReadLine());
    }

    protected int GetDuration()
    {
        return _duration;
    }

    public void SetCalculatedDistance()
    {
        _distance = Math.Round(CalculateDistance(),2);
    }
    private double GetCalculatedDistance()
    {
        SetCalculatedDistance();
        return _distance;
    }

    public void SetCalculatedSpeed()
    {
        _speed = Math.Round(60/CalculatePace(),2);
    }

    private double GetCalculatedSpeed()
    {
        SetCalculatedSpeed();
        return _speed;
    }

    public void SetCalculatedPace()
    {
        _pace = Math.Round(60/CalculateSpeed(),2);
    }
    
    private double GetCalculatedPace()
    {
        SetCalculatedPace();
        return _pace;
    }
    public string GetMetric()
    {
        return _metric;
    }

    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();

    public void WhichMetric()
    {
        Console.Write("\nPlease choose a unit for calculation (km for kilometers or mi for miles): ");
        string unit = Console.ReadLine();

        if (unit.ToLower() == "km")
        {
            _metric = "km";
        }
        else if (unit.ToLower() == "mi")
        {
            _metric = "miles";
        }
    }

    public virtual void GetSummary()
    {
        string dateFormat = $"{_date.Day} {_month[_date.Month - 1]} {_date.Year}";
        string summary = $"{dateFormat} {GetName()} ({GetDuration()} min): Distance {GetCalculatedDistance()} {GetMetric()}, Speed {GetCalculatedSpeed()} {GetMetric()} per hour, Pace {GetCalculatedPace()} min per {GetMetric()}";
        Console.WriteLine(summary);
    }   

    public void Start()
    {
        WhichMetric();
        SetName();
        SetDuration();
    }

}