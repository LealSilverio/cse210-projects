public class FiveSenses : Activity
{
    public FiveSenses()
    {
        _name = "Five Senses";
        _description = "This activity will help you ground yourself by building awareness to your surroundings.";
    }
    public void AwarenessMessage()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);
        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine($"Notice five things that you can see...");
            Console.WriteLine(string.Empty);
            Thread.Sleep(5000);
            Console.WriteLine($"Notice five things that you can feel...");
            Console.WriteLine(string.Empty);
            Thread.Sleep(5000);
            Console.WriteLine($"Notice five things that you can hear...");
            Console.WriteLine(string.Empty);
            Thread.Sleep(5000);
            Console.WriteLine($"Notice five things that you can smell...");
            Console.WriteLine(string.Empty);
            Thread.Sleep(5000);
            Console.WriteLine($"Notice five things that you can taste...");
            Thread.Sleep(5000);
            currentTime = DateTime.Now;
        }
    }
    public override void Display()
    {
        base.Display();
        AwarenessMessage();
        DisplayEndMessage();
    }
}