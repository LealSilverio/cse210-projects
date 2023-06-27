public class Eternal : Goal
{
    List<Eternal> _eternalGoals = new List<Eternal>();

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
            _points.ToString()
        };
        return string.Join(_break, list);
    }
}