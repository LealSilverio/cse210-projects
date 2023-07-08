public class Reception : Event
{
    string emailToRSVP;
    public Reception()
    {
        _eventType = "Reception";
    }
    // public void PromptRSVP()
    // {
    //     Console.Write("Have you confirmed your presence?[y/n] ");
    //     string answer = Console.ReadLine();
    //     if (answer == "y")
    //     {
    //         Console.WriteLine("You are set");
    //     } 
    // }
    public override void SetEvent()
    {
        base.SetEvent();
        PromptEmail();
    }
    public string PromptEmail()
    {   
        Console.Write("Email for RSVP: ");
        emailToRSVP = Console.ReadLine();
        return emailToRSVP;
    }
    override public string FullDetails()
    {
        string normalMessage = StandardDetails();
        return normalMessage + $"\n{_eventType} - {emailToRSVP}";
    }
}