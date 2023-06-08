public class ListingPrompt : Prompt
{
    public ListingPrompt()
    {
        AddPrompts();

        if (_prompts.Count == 0)
        {
        AddPrompts();
        _usedPrompts.Clear();
        }
    }
    public void AddPrompts()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
}