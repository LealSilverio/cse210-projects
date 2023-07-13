public class Eternal : Goal
{

    public Eternal()
    {
        _type = "Eternal";
    }
    public override void CreateFromList(string[] list){
        _name = list[1];
        _description = list[2];
        _points = int.Parse(list[3]);
    }
    public override string Stringify()
    {
        List<string> list = new List<string>
        {
            "EternalGoal",
            _name,
            _description,
            _points.ToString(),
        };
        return string.Join(_break, list);
    }
    override public void CompleteGoal()
    {
        _isCompleted = true;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        SetPoints(_points);
    }
}