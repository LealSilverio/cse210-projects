public class Menu
{

  public Journal _journal;
  public Entry _entry;

  public void Display()
  {
    string response = "";
    string[] options = {"N","D","S","L","Q"};
    while(response!="Q")
    {
      while(options.Contains(response)==false)
      {
        Console.Write("[N]ew Entry\n[D]isplay Journal\n[S]ave Journal\n[L]oad File\n[Q]uit\n\nWhat do you want to do? ");
        response = Console.ReadLine() ?? String.Empty;
        response = response.ToUpper();
      }
      switch (response)
      {
        case "Q":
          Environment.Exit(0);
          break;
        case "N":
          // New Entry
          Console.WriteLine("Enter Date: ");
          _journal.NewEntry();
          break;
        case "D":
          //Display Jornal
          _journal.ShowAllEntries();
          break;
        case "S":
          //Save journal
          _journal.SaveFile();
          break;
        case "L":
          //Load Journal
          Console.Write("Enter file name: ");
          _journal.LoadFile();
          break;
      }
      response= "";
    }
  }
}