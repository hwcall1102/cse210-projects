using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?  ");
        string gPercent = Console.ReadLine();
        int gNumber = int.Parse(gPercent);

        string letter = "";
        
        if (gNumber >= 90)
        {
            letter = "A";
        }
        else if (gNumber >= 80)
        {
            letter = "B";
        }
        else if (gNumber >= 70)
        {
            letter = "C";
        }
        else if (gNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign = "";

        if (gNumber % 10 >= 7)
        {
            sign = "+";
        }
        else if (gNumber % 10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }


        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (gNumber >= 70)
        {
            Console.WriteLine("Congratulations! You Passed!");
        }
        else 
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}