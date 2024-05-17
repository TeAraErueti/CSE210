public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;       
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"********** Welcome to the {_name} **********\n");
        Console.WriteLine(_description);
    }

    public void AskDuration()
    {
        Console.Write($"\nHow long in seconds would you like to participate in your activity? \n\nIdeally, 10 seconds or more is best to get the most out of your activity: ");
        string durationString = Console.ReadLine();
        SetDuration(Convert.ToInt32(durationString));
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void RunActivity()
    {
        Console.Clear();
        DisplayStartingMessage();
        AskDuration();
        GetReady();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\n\n********** Well done! **********");
        ShowSpinner(5);
        Console.WriteLine($"\nYou have completed {_duration} seconds of the {_name}.");
        ShowSpinner(5);
        Console.WriteLine();
    }

    public void ShowSpinner(int seconds)
    {
        DateTime futureTime = GetFutureTime(5);

        while(DateTime.Now < futureTime)
        {
            char[] spinChars = new char[]{'|','/','-','\\'};
            foreach (char spinChar in spinChars)
            {
                Console.Write(spinChar);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
        Console.Write(" ");
    }
    
    public void ShowCountDown(int seconds)
    {
        for (int i = 0; i <= seconds; i++)
        {
            Console.Write(seconds - i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }        
        Console.Write(" ");
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
    }

    public DateTime GetFutureTime(int duration)
    {
        DateTime futureTime = new DateTime();
        futureTime = DateTime.Now.AddSeconds(duration);

        return futureTime;
    }

    public DateTime GetCurrentTime()
    {
        DateTime currentTime = new DateTime();
        currentTime = DateTime.Now;
        
        return currentTime;
    }
}