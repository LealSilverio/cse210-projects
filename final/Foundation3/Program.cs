using System;

class Program
{
    static void Main(string[] args)
    {
        // Lecture l = new Lecture();
        // Console.WriteLine("\n\tLecture");
        // l.SetSpeaker("Jose");
        // l.SetEvent();
        // l.SetAddress("604 S 4th E", "Richmond", "ID", "USA");

        // Reception r = new Reception();
        // Console.WriteLine("\n\tReception");
        // r.SetEvent();
        // r.SetAddress("2734 BroadStreet", "Woodland", "WA", "USA");

        Outdoor o = new Outdoor();
        Console.WriteLine("\n\tOutdoor Gathering");
        o.SetEvent();
        o.CheckWeather();
        o.SetAddress("7439 E 21th N", "city", "VA", "USA");

        // Console.WriteLine("\nStandard Details: " + l.StandardDetails());
        // Console.WriteLine("\nFull Details: " + l.FullDetails());
        // Console.WriteLine("\nShort Details: " + l.ShortDescription());
        
        // Console.WriteLine("\nStandard Details: " + r.StandardDetails());
        // Console.WriteLine("\nFull Details: " + r.FullDetails());
        // Console.WriteLine("\nShort Details: " + r.ShortDescription());

        Console.WriteLine("\nStandard Details: " + o.StandardDetails());
        Console.WriteLine("\nFull Details: " + o.FullDetails());
        Console.WriteLine("\nShort Details: " + o.ShortDescription());
    }
}