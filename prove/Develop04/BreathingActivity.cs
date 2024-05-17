public class BreathingActivity : Activity
{         
    public BreathingActivity()
    {    
        SetName("Breathing Activity");
        SetDescription($"This activity will help you relax by walking you through your breathing in and breathing out slowly.\nPlease take this time to clear your mind and focus on your breathing.");
    }

    public void RunBreathing()
    {
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            Console.Write($"\n\nBreathe in...");
            ShowCountDown(5);
            Console.Write($"\nBreathe out...");
            ShowCountDown(5);
            currentTime = DateTime.Now;
        }
    }
}