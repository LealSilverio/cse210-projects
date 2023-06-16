public class Breathing : Activity
{
    public Breathing()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void BreathMessage()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write($"Breathe in...");
            numberCountdown();
            Console.WriteLine(string.Empty);
            Console.Write($"Now breathe out...");
            numberCountdown();
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            currentTime = DateTime.Now;
        }
    }
    public override void Display()
    {
        base.Display();
        BreathMessage();
        DisplayEndMessage();
    }
}