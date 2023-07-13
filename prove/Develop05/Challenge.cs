public class Challenge : Goal
{
    int _timesAccomplished;
    int _toAccomplish;
    public Challenge()
    {
        _type = "Challenge";
    }
    public override void AddGoal()
    {
        base.AddGoal();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _toAccomplish = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }
    public override void CreateFromList(string[] list){
        _name = list[1];
        _description = list[2];
        _points = int.Parse(list[3]);
        _timesAccomplished = int.Parse(list[4]);
        _toAccomplish = int.Parse(list[5]);
        _bonusPoints = int.Parse(list[6]);
    }
    public override string Stringify()
    {
        List<string> list = new List<string>
        {
            "ChallengeGoal",
            _name,
            _description,
            _points.ToString(),
            _timesAccomplished.ToString(),
            _toAccomplish.ToString(),
            _bonusPoints.ToString()
        };
        return string.Join(_break, list);
    }
    override public void CompleteGoal()
    {
        ++_timesAccomplished;
        if (_timesAccomplished == _toAccomplish)
        {
            _isCompleted = true;
            Console.WriteLine("You got extra points! Nice!");
            SetPoints(_points, _bonusPoints);
        }
        else{
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            SetPoints(_points);
        }
    }
    override public void Display()
    {   
        base.Display();
        Console.WriteLine($" -- Currently completed: {_timesAccomplished}/{_toAccomplish}");
    }
}