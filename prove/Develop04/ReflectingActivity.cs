public class ReflectingActivity : Activity
{
    private List<string> _prompts= new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you took a leap of faith to support a great cause.",
        "Think of a time when you overcame a major obstacle in your life.",
        "Think of a time when you went out of your way to give service to someone else.",
        "Think of a time when you prioritized the needs of others who were around you.",
        "Think of a time when you stood up for someone or spoke out about an injustice in your life.",
        "Think of a time when you demonstrated a Christlike love towards someone in need.",
        "Think of a time when you shared your time, talents, knowledge, skills or expertise to assist someone",
    };
    private List<string> _questions= new List<string>{
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };
     
    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription($"This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        
        return _questions[index];
    }

    public void RunReflecting()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"\nConsider the following prompt:\n");
        Console.WriteLine($"***** {prompt} *****\n");
        Console.WriteLine("When you have something in your mind please press enter to continue.");
        Console.ReadLine();
        Console.WriteLine($"Now ponder on each of the following questions as they relate to this experience.");
        Console.Write($"\nYou may begin in...");
        ShowCountDown(5);
        Console.Clear();

        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            string question = GetRandomQuestion();
            Console.Write(question + " ");
            ShowSpinner(15);
            Console.WriteLine();
            currentTime = DateTime.Now;            
        }
    }
}