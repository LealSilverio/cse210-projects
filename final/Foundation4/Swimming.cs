public class Swimming : Exercise
{
    int numberOfLaps;
    public override void CalculateDistance()
    {
        distance = numberOfLaps * 50 / 1000;
    }
}