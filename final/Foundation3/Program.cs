using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address
        {
            StreetAddress = "456 Elm St",
            City = "Townsville",
            State = "NY",
            Country = "USA"
        };

        Event lecture = new Lecture("Lecture on AI", "Introduction to Artificial Intelligence", DateTime.Now.AddDays(7), "10:00 AM", address, "Dr. Smith", 100);
        Event reception = new Reception("Networking Event", "Networking event for professionals", DateTime.Now.AddDays(14), "6:00 PM", address, "info@example.com");
        Event outdoorGathering = new OutdoorGathering("Picnic in the Park", "Community picnic", DateTime.Now.AddDays(21), "12:00 PM", address, "Sunny");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetStandardDetails());
    }
}