public abstract class Goal
{
    protected int _points;
    protected int _bonusPoints;
    protected string _name;
    protected string _description;    
    protected string _break = "~~";
    protected bool _isCompleted;
    protected string _type;
    string _checkList;

    virtual public void AddGoal(){
        Console.Write("\nWhat is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public void SetPoints(int points, int bonusPoints)
    {
        _points = points;
        _bonusPoints = bonusPoints;
    }
    public int GetPoints()
    {
        if (_isCompleted == true)
        {
            return _points;
        }
        else
        {
            return _points = 0;
        }
    }
    public string GetGoalType()
    {
        return _type;
    }
    public abstract void CompleteGoal();
    public bool CheckCompletion()
    {
        return _isCompleted;
    }
    public abstract void CreateFromList(string[] list);
    abstract public string Stringify();
    virtual public void Display()
    {
        if (_isCompleted == true)
        {
            _checkList = "[X]";
        }
        else{
            _checkList = "[ ]";
        }
        Console.Write($"{_checkList} {_name} ({_description})");
    }
    public string ListItems()
    {
        return $"{_name}";
    }
}