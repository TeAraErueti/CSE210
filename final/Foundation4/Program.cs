using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Exercise Tracker!\n");
        List<Activity> activities = new();
        string menu = "\n| 1. Running \n| 2. Cycling \n| 3. Swimming \n| 4. Get Summary \n| 5. Quit\n";
        int response;

        do
        {
            Console.Write(menu);
            Console.Write("\nPlease chooose your preferred menu option number: ");
            string input = Console.ReadLine();
            Console.WriteLine();
            if (int.TryParse(input, out response))
            {
                switch (response)
                {
                    case 1:
                        Running running = new();
                        running.StartRunning();
                        activities.Add(running);
                        break;
                    
                    case 2:
                        Cycling cycling = new();
                        cycling.StartCycling();
                        activities.Add(cycling);
                        break;

                    case 3:
                        Swimming swimming = new();
                        swimming.StartSwimming();
                        activities.Add(swimming);
                        break;

                    case 4:
                        foreach (Activity activity in activities)
                        {
                            activity.GetSummary();
                        }
                        break;                   

                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number from the menu.");
            }       

        } while (response < 5);
    }
}