using System.Linq;

public class Menu
{
    string _userChoice;
    string _goalType;
    int _totalPoints;
    int _score;
    int i = 1;
    FileHandler f = new FileHandler();
    List<Goal> goals = new List<Goal>();
    Simple s = new Simple();
    Eternal e = new Eternal();
    Challenge c = new Challenge();
    public void DisplayMenu()
    {
        Console.Write(_userChoice);
        string[] options = {"1", "2", "3", "4"};
        while(_userChoice != "4")
    {   
        while(options.Contains(_userChoice) == false)
        {
            Console.WriteLine($"\nYou have {_totalPoints} points.\n");
            Console.Write("Menu Options:\n\t1. Create New Goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit\nSelect a choice from the Menu: ");
            _userChoice = Console.ReadLine() ?? String.Empty;
            switch (_userChoice)
            {
                case "1":
                    Console.Write("\nThe types of Goals are:\n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checklist Goals\nWhich type of goal would you like to create? ");
                    _goalType = Console.ReadLine() ?? String.Empty;
                    switch (_goalType)
                    {
                        case "1":
                            s.AddGoal();
                            s.Stringify();
                            goals.Add(s);
                            break;
                        case "2":
                            e.AddGoal();
                            e.Stringify();
                            goals.Add(e);
                            break;
                        case "3":
                            c.AddGoal();
                            c.Stringify();
                            goals.Add(c);
                            break;
                    }
                    _goalType = " ";
                    break;
                case "2":
                    i = 1;
                    foreach (Goal g in goals)
                    {
                        Console.Write($"{i}. ");
                        g.Display();
                        ++i;
                        Console.WriteLine(string.Empty);
                    }
                    break;
                case "3":
                    f.Save(goals);
                    break;
                case "4":
                    f.Load(goals);
                    break;
                case "5":
                    Console.WriteLine("\nYour goals are: ");
                    i = 1;
                    List <string> list = new List<string>();
                    foreach (Goal g in goals)
                        {
                            list.Add(i.ToString());
                            Console.Write($"{i}. ");
                            Console.WriteLine(g.ListItems());
                            ++i;
                        }
                    Console.Write("\nWhich goal did you accomplish? ");
                    string userInput = Console.ReadLine();
                    int goalNumber = int.Parse(userInput);
                    int index = 0 + goalNumber - 1;
                    if (list[index] == userInput)
                    {
                        if ( goals[index].GetGoalType() == "Simple")
                        {
                            s.CompleteGoal();
                            Console.WriteLine(goals[index].GetGoalType());  
                        } 
                        else if ( goals[index].GetGoalType() == "Eternal")
                        {
                            e.CompleteGoal();
                            Console.WriteLine(goals[index].GetGoalType());   
                        } 
                        else if ( goals[index].GetGoalType() == "Challenge")
                        {
                            c.CompleteGoal();
                            Console.WriteLine(goals[index].GetGoalType());  
                        }                 
                    }
                    break;
                case "6":
                    Environment.Exit(0);
                    break;
            }
            _userChoice = " ";
        }
    }}
}