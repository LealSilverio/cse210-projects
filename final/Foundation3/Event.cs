public class Event
{
    protected string _title;
    protected string _eventType;
    protected string _description;
    protected string _date;
    protected string _time;
    Address address = new Address();

    virtual public void SetEvent()
    {
        Console.Write("Title: ");
        _title = Console.ReadLine();

        Console.Write("Description: ");
        _description = Console.ReadLine();

        Console.Write("Date: ");
        _date = Console.ReadLine();

        Console.Write("Time: ");
        _time = Console.ReadLine();
    }
    public void SetAddress(string street, string city, string state, string country)
    {
        address.SetAddress(street, city, state, country);
    }
    public string StandardDetails()
    {
        return $"{_title} - {_description}\n{_date} {_time}\n{address.Stringify()}";
    }
    virtual public string FullDetails()
    {
        string normalMessage = StandardDetails();
        return normalMessage;
    }
    public string ShortDescription()
    {
        return $"{_eventType} - {_title} - {_date}";
    }
}