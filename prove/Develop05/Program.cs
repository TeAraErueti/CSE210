// exceeding requirement: setup a folder called Goalfolder for goals to be saved for easy use in future.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n***** Welcome to the Eternal Quest Program *****\n");

        GoalManager goalManager = new();

        goalManager.Start();

    }
}
