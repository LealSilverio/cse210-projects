public abstract class Goal
{
    int _points;
    string _goalType;
    string _description;
    List<Goal> goals = new List<Goal>();
    public Goal()
    {

    }
    public abstract void AddGoal();
}