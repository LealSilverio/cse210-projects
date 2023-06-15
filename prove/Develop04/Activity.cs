public class Activity
{
    protected string _name;
    protected string _description;
    protected int _seconds;

    public int SetSeconds()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string user_input = Console.ReadLine(); 
        _seconds = int.Parse(user_input);
        return _seconds;
    }
    public void Pause(string message)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_seconds);
        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.WriteLine(message);
            Spin();
        }
        Console.WriteLine(string.Empty);
    }
    public void numberCountdown()
    {
        Console.Write(4);
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Erase the + character
        Console.Write(3);
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Erase the + character
        Console.Write(2); // Replace it with the - character
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Erase the + character
        Console.Write(1); // Replace it with the - character
        Thread.Sleep(1000);
        Console.Write("\b \b"); // Erase the + character
    }
    public void Spin()
    {
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("/"); // Replace it with the - character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("/"); // Replace it with the - character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
    }
    public string GetRandomFromList(List<string> list, List<string> usedList)
    {
        var random = new Random();
        var randomNumber = random.Next(0,list.Count);
        var randomPrompt = list[randomNumber];

        usedList.Add(randomPrompt);
        list.Remove(randomPrompt);

        if (list.Count == 0)
        {
            foreach (string i in usedList)
            {
                list.Add(randomPrompt);
                usedList.Remove(randomPrompt);
            }
        }

        return randomPrompt;
    }
    virtual public void Display()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(string.Empty);
        Console.WriteLine(_description);
        Console.WriteLine(string.Empty);
        SetSeconds();
        Pause("Get Ready...");
    }

    public void DisplayEndMessage()
    {
        Pause("\nWell done!!");
        Pause($"You have completed another {_seconds} seconds of the {_name} Activity");
    }
}