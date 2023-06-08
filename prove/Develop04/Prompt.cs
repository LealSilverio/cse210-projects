public class Prompt
{

  protected List<string> _usedPrompts = new List<string>();
  protected List<string> _prompts = new List<string>();

  public string GetRandomFromList(List<string> list, List<string> usedList)
  {
    var random = new Random();
    var randomNumber = random.Next(0,list.Count);
    var randomPrompt = list[randomNumber];

    usedList.Add(randomPrompt);
    list.Remove(randomPrompt);

    return randomPrompt;
  }
}