public class Swimming : Exercise
{
    int numberOfLaps;
    public Swimming()
    {
        _exerciseType = "Swimming";
    }
    public override double CalculateDistance()
    {
        Console.Write("How many laps? ");
        string input = Console.ReadLine();
        numberOfLaps = int.Parse(input);
        _distance = numberOfLaps * 50 / 1000;
        return _distance;
    }
}