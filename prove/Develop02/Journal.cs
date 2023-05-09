public class Journal
{
  List<Entry> _entries = new List<Entry>();
  public Entry _entry;
  public Prompt _prompt;

  public Journal()
  {

  }
  public void SaveAndLoad()
  {

  }
  public void NewEntry()
  {
    Console.WriteLine(_prompt.GetRandomPrompt());
    string userInput = Console.ReadLine();

    _entries.Add($"{userInput}");
  }
  public void ShowAllEntries()
  {
    foreach (Entry _entry in _entries)
    {
      Console.WriteLine(_entry);
    }
  }
}