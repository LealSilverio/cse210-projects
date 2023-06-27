public abstract class Goal
{
    protected int _points;
    protected string _name;
    protected string _description;    
    protected string _break = "~~";
    protected bool _isCompleted;
    string _checkList;

    virtual public void AddGoal(){
        Console.Write("\nWhat is the name of your goal? ");
        _name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _points = Console.Read();
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
}