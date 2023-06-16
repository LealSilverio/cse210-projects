public class Reflection : Activity
{
    protected List<string> _prompts = new List<string>(){
    "Think of a time when you stood up for someone else.",
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."};

    List<string> _reflections = new List<string>(){
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"};

    protected List<string> _usedPrompts = new List<string>();
    List<string> _usedReflections = new List<string>();

    public Reflection()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void GetPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n--- {GetRandomFromList(_prompts, _usedPrompts)} ---\n");
        Console.Write("When you have something in mind, press enter to continue.\n");
        var response = Console.ReadLine();
        if (Console.ReadKey().Key == ConsoleKey.Enter) { 
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Thread.Sleep(500);
            Console.Write("You may begin in: ");
            numberCountdown();
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
        };
    }
    public void ReflectionPrompts()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Pause(GetRandomFromList(_reflections, _usedReflections));
            Thread.Sleep(1000);
            currentTime = DateTime.Now;
        }
    }
    public override void Display()
    {
        base.Display();
        GetPrompt();
        ReflectionPrompts();
        DisplayEndMessage();
    }
}