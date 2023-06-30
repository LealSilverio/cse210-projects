public class Event
{
    protected string title;
    protected string eventType;
    protected string description;
    protected int date;
    protected int time;
    Address address = new Address();

    public string StandardDetails(){
        return $"{title} - {description}\n{date} {time}\n{address}";
    }
    virtual public void FullDetails(){
        Console.WriteLine(StandardDetails());
    }
    public string ShortDescription(){
        return $"{eventType} - {title} - {date}";
    }
}