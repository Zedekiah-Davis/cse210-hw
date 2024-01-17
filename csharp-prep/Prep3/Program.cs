using System;

class Program
{
    static void Main(string[] args)
    {
           string keepGuessing = "true";
           Random randomGenerator = new Random();
           int number = randomGenerator.Next(1,100);

           do 
           {
           Console.Write("What is your guess? ");
           int guess = int.Parse(Console.ReadLine());
           if (guess > number)
           {
            Console.WriteLine("Lower");
           }
            else if (guess < number)
           {
            Console.WriteLine("Higher");
           }
           else
           {
            Console.WriteLine("You guessed it!");
            keepGuessing = "false";
           }
           } while (keepGuessing == "true");
           
           
           
           
           
           
           
    }
}