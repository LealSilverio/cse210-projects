public class Outdoor : Event
{
    string weather;
    public Outdoor()
    {
        _eventType = "Outdoor Gathering";
    }
    public override void SetEvent()
    {
        base.SetEvent();
        CheckWeather();
    }
    public string CheckWeather()
    {
        var random = new Random();
        int randomNumber = random.Next(0,3);
        if (randomNumber == 1)
        {
            weather = "The weather will be nice and sunny";
        } else if (randomNumber == 2)
        {
            weather = "It will rain";
        } else if (randomNumber == 3)
        {
            weather = "The weather will be cloudy";
        }
        return weather;
    }
    override public string FullDetails()
    {
        string normalMessage = StandardDetails();
        string fullMessage = normalMessage + $"\n{_eventType} - {weather}";
        return fullMessage;
    }
}