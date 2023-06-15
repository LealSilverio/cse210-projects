public class Journal
{
  List<Entry> _entries = new List<Entry>();
  public Prompt _prompt = new Prompt();
  
  public void NewEntry()
  {
    Console.WriteLine(_prompt.GetRandomPrompt());
    string userInput = Console.ReadLine();
    AddEntry();
    // Console.Write(userInput);
  }
  public void AddEntry()
  {
    Entry _entry = new Entry();
    _entries.Add(_entry);
    Console.WriteLine("Entry added");
  }
  public void ShowAllEntries()
  { 
    Console.Clear();
    foreach (Entry _entry in _entries)
    {
      _entry.Display();
    }
  }
}