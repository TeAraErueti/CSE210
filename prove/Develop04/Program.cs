//Exceeding requirements : Added an activity log to keep track of how many times the user participated in the activities during the program.

using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "";
        int breathingLog = 0;
        int reflectingLog = 0;
        int listingLog = 0;

        void DisplayLog()
        {
            Console.WriteLine("***** Activity Log - Current Session *****\n");
            Console.WriteLine($"Breathing Activity: {breathingLog}");
            Console.WriteLine($"Reflecting Activity: {reflectingLog}");
            Console.WriteLine($"Listing Activity: {listingLog}\n");
        }
        
        while (input != "4")
        {
            Console.Clear();
            DisplayLog();
            Console.WriteLine("***** Mindfulness Menu Options *****\n");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit\n");
            Console.Write("Please choose a number from the menu above:");

            input = Console.ReadLine();

            switch (input)
            {
                case "1":

                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.RunActivity();
                    breathingActivity.RunBreathing();
                    breathingActivity.DisplayEndingMessage();

                    breathingLog++;
                    break;

                case "2":

                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.RunActivity();
                    reflectingActivity.RunReflecting();
                    reflectingActivity.DisplayEndingMessage();

                    reflectingLog++;
                    break;

                case "3":

                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.RunActivity();
                    listingActivity.RunListing();
                    listingActivity.DisplayEndingMessage();

                    listingLog++;
                    break;

                case "4":

                    Console.WriteLine("\n***** Thank you for doing your mindfulness wellbeing for today *****");
                    Environment.Exit(0);
                    break;

                default:

                    Console.WriteLine("***** Please choose a number from the menu options available *****");
                    break;
            }

        }
        Environment.Exit(0);
    }
}