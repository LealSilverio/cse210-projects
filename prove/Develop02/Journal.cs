public class Journal
{
  List<Entry> _entries = new List<Entry>();
  
  public void LoadEntries(List<Entry> entries)
  {
    _entries = entries;
  }
  public List<Entry> GetEntries()
  {
    return _entries;
  }
  
  public void NewEntry()
  {
    Entry _entry = new Entry();
    _entry.NewEntry();
    _entries.Add(_entry);
    Console.WriteLine("\nEntry added");
  }
  public void ShowAllEntries()
  { 
    // Console.Clear();
    foreach (Entry _entry in _entries)
    {
      _entry.Display();
    }
  }
}