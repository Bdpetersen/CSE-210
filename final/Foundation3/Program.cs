using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Addresses
        Address a1 = new Address("123 University Ave", "Rexburg", "ID", "83440");
        Address a2 = new Address("500 S Temple", "Salt Lake City", "UT", "84101");
        Address a3 = new Address("789 Park Lane", "Idaho Falls", "ID", "83402");

        // Create Events
        Lecture lecture = new Lecture("Tech Talk", "Latest in AI", "2024-10-15", "10:00 AM", a1, "Dr. Smith", 100);
        Reception reception = new Reception("Networking Night", "Meet industry professionals", "2024-10-20", "6:00 PM", a2, "rsvp@company.com");
        OutdoorGathering outdoor = new OutdoorGathering("Summer Picnic", "Fun in the sun", "2024-07-04", "12:00 PM", a3, "Sunny and 85 degrees");

        // Display Results
        Console.WriteLine("--------------------------------------------------");
        
        // Event 1: Lecture
        Console.WriteLine("EVENT 1: LECTURE");
        Console.WriteLine("-- Standard Details --");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine("\n-- Full Details --");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine("\n-- Short Description --");
        Console.WriteLine(lecture.GetLectureShortDescription());
        
        Console.WriteLine("--------------------------------------------------");

        // Event 2: Reception
        Console.WriteLine("EVENT 2: RECEPTION");
        Console.WriteLine("-- Standard Details --");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine("\n-- Full Details --");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine("\n-- Short Description --");
        Console.WriteLine(reception.GetReceptionShortDescription());

        Console.WriteLine("--------------------------------------------------");

        // Event 3: Outdoor Gathering
        Console.WriteLine("EVENT 3: OUTDOOR GATHERING");
        Console.WriteLine("-- Standard Details --");
        Console.WriteLine(outdoor.GetStandardDetails());
        Console.WriteLine("\n-- Full Details --");
        Console.WriteLine(outdoor.GetFullDetails());
        Console.WriteLine("\n-- Short Description --");
        Console.WriteLine(outdoor.GetOutdoorShortDescription());

        Console.WriteLine("--------------------------------------------------");
    }
}