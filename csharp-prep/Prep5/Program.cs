using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
    }
    static void DisplayWelcome()
        {
            Console.Write("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            return Console.ReadLine();
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            return int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int favorite_Number)
        {
           int squaredNumber = favorite_Number * favorite_Number;
           return squaredNumber;
        }
}