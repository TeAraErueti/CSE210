using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.Write("Please enter a number (Enter 0 to Quit): ");
            
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);
                
            // Add number to the list if not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        //calculate the sum

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        //find the average

        //change the average to a float like python so can get correct average value.

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //find the largest number

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");

        //find the smallest positive number

        int smallestNumberSoFar = 999999999;

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestNumberSoFar)
            {
                smallestNumberSoFar = number;
            }
        }

        Console.WriteLine($"The smallest positive number is: {smallestNumberSoFar}");

        //sort list

        numbers.Sort();

        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }

}


