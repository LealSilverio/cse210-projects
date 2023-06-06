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
    _prompts.Add("Think of a time when you stood up for someone else.");
    _prompts.Add("Think of a time when you did something really difficult.");
    _prompts.Add("Think of a time when you helped someone in need.");
    _prompts.Add("Think of a time when you did something truly selfless.");
  }
}