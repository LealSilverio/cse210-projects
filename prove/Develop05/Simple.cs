public class Simple : Goal
{
    public override void CreateFromList(string[] list){
        _name = list[1];
        _description = list[2];
        _points = int.Parse(list[3]);
        _isCompleted = false;
    }
    public override string Stringify()
    {
        List<string> list = new List<string>
        {
            "SimpleGoal",
            _name,
            _description,
            _points.ToString(),
            _isCompleted.ToString()
        };
        return string.Join(_break, list);
    }
}