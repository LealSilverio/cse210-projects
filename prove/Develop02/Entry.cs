public class Entry
{

  private string _date;
  private string _text;
  private string _prompt;
  private string _break = "~~";

  public Entry()
  {
    _prompt = new Prompt().GetRandomPrompt();
    DateTime theCurrentTime = DateTime.Now;
    _date = theCurrentTime.ToShortDateString();
  }
  public void EntryList(string[] items)
  {
    _date = items[0];
    _prompt = items[1];
    _text = items[2];
  }
  public void Display()
  {
    Console.WriteLine($"{_date}\n{_prompt}\n{_text}");
  }
  public string Stringify()
  {
    return $"{_date}{_break}{_prompt}{_break}{_text}";
  }
}