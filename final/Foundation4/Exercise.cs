public abstract class Exercise
{
    protected int date;
    protected int length;
    protected string exerciseType;
    protected int distance;
    protected int speed;
    protected int pace;
    public abstract void CalculateDistance();
    public int CalculateSpeed()
    {
        speed = 60 / pace;
        return speed;
    }
    public int CalculatePace()
    {
        pace = 60 / speed;
        return pace;
    }
    public virtual void Display()
    {
        Console.Write($"{date} {exerciseType} ({length} min) - ");
    }
}