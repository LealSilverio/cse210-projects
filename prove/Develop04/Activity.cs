public class Activity
{
    protected string _name;
    protected string _description;
    protected int _seconds;
    private string _endMessage;

    public Activity(string name, string description, int seconds)
    {
        _name = name;
        _description = description;
        _seconds = seconds;
    }
    public void SetSeconds()
    {

    }
    public void Pause()
    {
        
    }
    public void Countdown()
    {
        
    }
    public void Spin()
    {
        
    }

    virtual public void Display()
    {
        
    }
}