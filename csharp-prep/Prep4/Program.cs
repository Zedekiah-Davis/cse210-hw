using System;

class Program
{
    static void Main(string[] args)
    {
        int active = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        do
        {
            Console.Write("Enter Number: ");
            int completeTest = int.Parse(Console.ReadLine());
            
            if (completeTest == 0)
            {
                Console.WriteLine($"The sum is: {numbers.Sum()}");
                Console.WriteLine($"The average is: {numbers.Average()}");
                Console.WriteLine($"The largest number is: {numbers.Max()}");
                active = 0;
            }
            else
            {
                numbers.Add(completeTest);
            }
        } while (active == 1);
    }
}