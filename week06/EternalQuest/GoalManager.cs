using System;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("1 - Create New Goal");
            Console.WriteLine("2 - List Goals");
            Console.WriteLine("3 - Save Goals to File");
            Console.WriteLine("4 - Load Goals From File");
            Console.WriteLine("5 - Record Event");
            Console.WriteLine("6 - Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": SaveGoals(); break;
                case "4": LoadGoals(); break;
                case "5": RecordEvent(); break;
                case "6": return;
                default: Console.WriteLine("Invalid choice. Try again."); break;
            }
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Total score - {_score}\n");
    }

    private void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    private void CreateGoal()
    {
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        Console.WriteLine("Select goal type:");
        Console.WriteLine("1 - Simple Goal");
        Console.WriteLine("2 - Eternal Goal");
        Console.WriteLine("3 - Checklist Goal");
        string type = Console.ReadLine();

        switch (type)
        {
            case "1": _goals.Add(new SimpleGoal(name, description, points)); break;
            case "2": _goals.Add(new EternalGoal(name, description, points)); break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default: Console.WriteLine("Invalid choice."); break;
        }
    }

    private void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Enter goal number: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        if (index < 0 || index >= _goals.Count)
        {
            Console.WriteLine("Invalid goal number.");
            return;
        }

        Goal goal = _goals[index];
        goal.RecordEvent();

        
        if (goal is ChecklistGoal checklistGoal && checklistGoal.IsComplete())
        {
            _score += checklistGoal.GetPoints() + checklistGoal.GetBonus();
        }
        else
        {
            _score += goal.GetPoints();
        }
    }

    private void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
        Console.ReadKey();
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No saved goals found.");
            return;
        }

        string[] lines = File.ReadAllLines("goals.txt");
        _goals.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (type == "Simple")
            {
                var goal = new SimpleGoal(name, description, points);
                goal.SetCompletion(bool.Parse(parts[4]));
                _goals.Add(goal);
            }
            else if (type == "Eternal")
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            else if (type == "Checklist")
            {
                int amountCompleted = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);
                var goal = new ChecklistGoal(name, description, points, target, bonus);
                goal.SetAmountCompleted(amountCompleted);
                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully!");
        Console.ReadKey();
    }   
}