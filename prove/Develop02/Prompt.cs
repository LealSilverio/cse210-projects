public class Prompt
{

  List<string> _usedPrompts = new List<string>();
  List<string> _prompts = new List<string>();

  public Prompt()
  {
    AddPrompts();

    if (_prompts.Count == 0)
    {
      AddPrompts();
      _usedPrompts.Clear();
    }
  }

  public string GetRandomPrompt()
  {
    var random = new Random();
    var randomNumber = random.Next(0,_prompts.Count);
    var randomPrompt = _prompts[randomNumber];

    _usedPrompts.Add(randomPrompt);
    _prompts.Remove(randomPrompt);

    return randomPrompt;
  }

  public void AddPrompts()
  {
    _prompts.Add("What was the best moment of your day?");
    _prompts.Add("What was something confusing that happened today??");
    _prompts.Add("How did you see the hand of the Lord today?");
    _prompts.Add("What was the strongest emotion you felt today?");
    _prompts.Add("What is something you want to do?");
  }
}