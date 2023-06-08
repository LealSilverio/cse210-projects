public class Reflection : Activity
{
    public Reflection()
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strengh and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    public void GetPrompt(List<string> list)
    {

    }
    public override void Display()
    {
        base.Display();
        DisplayEndMessage();
    }
}