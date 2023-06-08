public class Breathing : Activity
{
    public Breathing()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }
    public void BreathMessage()
    {
        Console.Write($"Breathe in...");
        Countdown();
        Console.WriteLine(string.Empty);
        Console.Write($"Now breathe out...");
        Countdown();
        Console.WriteLine(string.Empty);
    }
    public override void Display()
    {
        base.Display();
        BreathMessage();
        DisplayEndMessage();
    }
}