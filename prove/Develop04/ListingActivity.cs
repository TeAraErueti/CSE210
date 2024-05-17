public class ListingActivity : Activity
{
    private List<string> _prompts= new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?", 
        "What are some Christlike attributes you admire in others?",
        "What things in your life are you proud of overcoming or achieved with gratitude?",
        "What skills have you acquired from something you are proud of this past year?",
        "What activities have you done within the past week that have made you happy?",
        "What are some things you would like to achieve or work on over the next few months?",
        "What piece of advice could you give to your younger self if they were looking for guidance and inspiration?",
        "What advice would you give to someone who is stepping into the roles and responsibilities you are currently undertaking in your life?",
    };

    private List<string> _userList = new List<string>();
     
    public ListingActivity()
    {
        SetName("Listing Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);

        return _prompts[index];
    }

    public void RunListing()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nPlease list as many responses you can to the following prompt:\n");
        Console.WriteLine($"----- {prompt} -----");
        Console.Write($"\nYou may begin writing in... ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            Console.Write(">");
            _userList.Add(Console.ReadLine());
            currentTime = DateTime.Now;
        }
        int listLength = _userList.Count;
        Console.WriteLine($"You listed {listLength} items!");
    }
}