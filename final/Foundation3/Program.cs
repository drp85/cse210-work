using System;

class Program
{
    static void Main(string[] args)
    {

        Lecture lectureEvent = new Lecture("Programming for Smart People", "Lecture event", new DateTime(2023, 4, 10), "10:00 AM", new Address("14 Tough St", "Waconom", "MT", "24356"), "Manley", 50);
        Reception receptionEvent = new Reception("Programming Final Reception", "Reception event", new DateTime(2023, 4, 11), "6:30 PM", new Address("1 Constitution Ave", "Arlington", "VA", "22047"), "rsvp@scientistmc.com");
        Outdoor outdoorEvent = new Outdoor("End of Semester Celebration", "Outdoor gathering event", new DateTime(2023, 4, 12), "9:00 PM", new Address("2377 Leesburg Pike", "Falls Church", "VA", "22043"), "Starry");


        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Standard details:");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(outdoorEvent.GetStandardDetails());

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nFull details:");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(outdoorEvent.GetFullDetails());

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nShort details:");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(lectureEvent.GetShortDetails());
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(receptionEvent.GetShortDetails());
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(outdoorEvent.GetShortDetails());
        Console.ResetColor();
    }
}