public class Listing : Activity
{
    List<string> _prompts = new List<string>(){     
    "Who are people that you appreciate?",
    "What are personal strengths of yours?",
    "Who are people that you have helped this week?",
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};
    List<string> _usedPrompts = new List<string>();
    List<string> _entries = new List<string>();
    int _entriesCount;
    public Listing()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public int EntriesCount()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.WriteLine(string.Empty);
            string entry = Console.ReadLine();
            _entries.Add(entry);
            currentTime = DateTime.Now;
        }
        _entriesCount = _entries.Count();
        Console.Write($"You listed {_entriesCount} items!");
        return _entriesCount;
    }
    public void GetPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"\n--- {GetRandomFromList(_prompts, _usedPrompts)} ---\n");
        Console.Write("You may begin in: ");
        numberCountdown();
        Console.WriteLine(string.Empty);
    }
    public override void Display()
    {
        base.Display();
        GetPrompt();
        EntriesCount();
        DisplayEndMessage();
    }
}