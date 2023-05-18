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

  public void Display()
  {
    Console.WriteLine($"{_date}\n{_prompt}\n{_text}");
  }
  public string Stringfy()
  {
    return $"{_date}{_break}{_prompt}{_break}{_text}";
  }
}