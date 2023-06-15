public class Menu 
{
    string _userChoice;

    public void DisplayMenu()
    {
        Console.Write(_userChoice);
        string[] options = {"1", "2", "3", "4"};
        while(_userChoice != "4")
    {   
        while(options.Contains(_userChoice) == false)
        {
            Console.Write("Menu Options:\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit\n Select a choice from the Menu: ");
            _userChoice = Console.ReadLine() ?? String.Empty;
            switch (_userChoice)
            {
                case "1":
                    Console.WriteLine("1");
                    break;
                case "2":
                    Console.WriteLine("2");
                    break;
                case "3":
                    Console.WriteLine("3");
                    break;
                case "4":
                    Console.WriteLine("4");
                    break;
                case "5":
                    Console.WriteLine("5");
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
            }
            _userChoice = " ";
        }
        
    }
    }
}