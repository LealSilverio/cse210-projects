public class Lecture : Event
{
    string _speaker;
    int capacity; 
    public Lecture()
    {
        _eventType = "Lecture";
    }
    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }
    public override void SetEvent()
    {
        base.SetEvent();
        checkCapacity();
    }
    public void checkCapacity()
    {
        Console.Write("How many people will be attending? ");
        string userInput = Console.ReadLine(); 
        capacity = int.Parse(userInput);
        if (capacity > 25)
        {
            Console.WriteLine("You can't have more than 25 people.\nThe amount will be set as 25.");
            capacity = 25;
        }
    }
    override public string FullDetails()
    {
        string normalMessage = StandardDetails();
        return normalMessage + $"\n{_eventType} - {_speaker}, {capacity}";
    }
}