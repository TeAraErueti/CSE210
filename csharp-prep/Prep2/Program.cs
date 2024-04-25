using System;

class Program
{
    static void Main(string[] args)
    {
    //Grade program

    Console.WriteLine("Please respond to the following question:");

    //Ask user for grade percentage
    
    Console.Write("What is your grade percentage? ");
    string userinput = Console.ReadLine();
    int grade = int.Parse(userinput);
    
    string letter = "";
    if (grade >= 90)
    {
        letter = "A";
    }

    else if (grade >= 80)
    {
        letter = "B";
    }

    else if (grade >= 70)
    {
        letter = "C";
    }

    else if (grade >= 60)
    {
        letter = "D";
    }

    else 
    {
        letter = "F";
    }
    
        
    //Stretch Challenge 1      

    int lastDigit = grade/10;
    string sign = "";
    
    if (lastDigit >= 7)
    {
        sign = "+";
    }
    
    else if (lastDigit < 3)
    {
        sign = "-";
    }
    
    else
        sign = "";

    //Stretch Challenge 2
    if (grade >= 93)
    {
        sign = "";
    }

    //Stretch Challenge 3
    if (letter == "F")
    {
        sign = "";
    }

    Console.WriteLine($"Your letter grade is: {letter}{sign}");
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry you did not pass this time.");
        }
    }
}
