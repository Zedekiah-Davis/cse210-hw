using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());
        if (grade >= 90)
        {
            string letter = ("A");
        }
        else if (grade >= 80)
        {
            letter = ("B");
        }
        else if (grade >= 70)
        {
            
        }
        else if (grade >= 60)
        {
            
        }
        else
        {
            
        }
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass.");
        }
    }
}