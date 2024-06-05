using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Event Planning Program!\n");
        string[] events = {"Lectures", "Receptions", "Outdoors"};
        Console.WriteLine("***** T A EVENT PLANNING *****\n");
        Console.WriteLine($"Which event would you like to plan? 1. {events[0]} | 2. {events[1]} | 3. {events[2]}");
        string theEvent = Console.ReadLine().ToLower();
        Console.WriteLine();

        void StandardMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Standard Format - Event Information: ");
            Console.WriteLine("_____________________________________");
        }

        void FullMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Full Format - Event Information: ");
            Console.WriteLine("_________________________________");
        }

        void ShortMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Short Format - Event Information: ");
            Console.WriteLine("__________________________________");
        }

        switch (theEvent)
        {
            case "lectures":
                Lecture lecture = new();
                lecture.BookLectureEvent();

                StandardMessage();
                lecture.DisplayStandardDetails();

                FullMessage();
                lecture.DisplayFullDetails();

                ShortMessage();
                lecture.DisplayShortDetails();

                break;

            case "receptions":
                Reception reception = new();
                reception.BookReceptionEvent();

                StandardMessage();
                reception.DisplayStandardDetails();

                FullMessage();
                reception.DisplayFullDetails();

                ShortMessage();
                reception.DisplayShortDetails();

                break;

            case "outdoors":
                Outdoor outdoor = new();
                outdoor.BookEvent();

                StandardMessage();
                outdoor.DisplayStandardDetails();

                FullMessage();
                outdoor.DisplayFullDetails();

                ShortMessage();
                outdoor.DisplayShortDetails();

                break;

            default: 
                Console.WriteLine("Invalid event - Please choose an event in the list of events we plan.");
                break;

        }
    }
}