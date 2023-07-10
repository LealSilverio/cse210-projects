public abstract class Exercise
{
    protected string _date;
    protected int _length;
    protected string _exerciseType;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    public void setData()
    {
        Console.WriteLine($"{_exerciseType}:");
        Console.Write("\nWhat is the date? [ex: 29 Feb 2000] ");
        _date = Console.ReadLine();

        Console.Write("How long did you exercise for in minutes? ");
        string userInput = Console.ReadLine();
        _length = int.Parse(userInput);
        
        CalculateDistance();
    }
    public virtual double CalculateDistance()
    {
        Console.Write("How many km? ");
        string input = Console.ReadLine();
        _distance = double.Parse(input);
        return _distance;
    }
    public virtual double CalculateSpeed()
    {
        _speed = (_distance / _length) * 60;
        return Math.Round(_speed, 1);
    }
    public virtual double CalculatePace()
    {
        _pace = _length / _distance;
        return Math.Round(_pace, 1);
    }
    public virtual void Display(Exercise e)
    {   
        Console.WriteLine($"\nYour {_exerciseType} Summary:");
        Console.Write($"\n{_date} {_exerciseType} ({_length} min) - {GetSummary(e)}");
    }
    public string GetSummary(Exercise e)
    {
        
        _speed = e.CalculateSpeed();
        _pace = e.CalculatePace();
        return $"Distance {_distance} km, Speed {_speed} kph, Pace: {_pace} min per km\n";
    }
}