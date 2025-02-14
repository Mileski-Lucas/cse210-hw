using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        ActivityLogger logger = new ActivityLogger();
        
        while (option != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("What would you like to do? ");
            
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input, please enter a number.");
                continue;
            }

            if (option == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
                logger.LogActivity("Breathing");
            }
            else if (option == 2)
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
                logger.LogActivity("Reflecting");
            }
            else if (option == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
                logger.LogActivity("Listing");
            }
        }
    }
}

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.Write("Enter the duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nGreat job! You completed the activity.");
        ShowSpinner(3);
        Console.WriteLine($"\nYou completed: {_name} for {_duration} seconds.");
        Thread.Sleep(500);
    }

    protected void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string> { "|", "/", "-", "\\" };
        for (int i = 0; i <= seconds; i++)
        {
            Console.Write(animation[i % 4]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
            Console.Write("\b\b  ");
        }
        Console.WriteLine();
    }
}

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Run()
    {
        DisplayStartingMessage();
        for (int i = 0; i < _duration; i += 6)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }
        DisplayEndingMessage();
    }
}

class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you overcame a fear.",
        "Think of a time when you made a sacrifice for someone else.",
        "Think of a time when you learned an important life lesson.",
        "Think of a time when you showed kindness to a stranger.",
        "Think of a time when you stayed committed to a goal despite challenges.",
        "Think of a time when you forgave someone who wronged you."
    };
    
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?",
        "Why did you choose to take action in this situation?",
        "How did this experience change your perspective?",
        "What challenges did you face, and how did you overcome them?",
        "Would you handle the situation differently if it happened again? Why or why not?",
        "How did this experience affect the people around you?",
        "What emotions did you experience throughout the process?",
        "How has this experience shaped your values or beliefs?",
        "What skills or strengths did you develop through this experience?",
        "Did this experience inspire you to take similar actions in the future?",
        "How would you describe this experience to someone else?",
        "What advice would you give to someone facing a similar situation?"
    };
    
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
    
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        ShowSpinner(5);
        GetRandomQuestion();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);
    }

    public void GetRandomQuestion()
    {
        Random rand = new Random();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            for (int i = 0; i <= _duration; i += 5)
            {
                Console.WriteLine(_questions[rand.Next(_questions.Count)]);
                ShowSpinner(5);
            }
        }
        
    }

}

class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?",
        "What is something you accomplished recently that you’re proud of?",
        "What is a challenge you have overcome?",
        "What is something that made you smile today?",
        "What is a lesson you have learned from a difficult experience?",
        "What is something you are looking forward to?",
        "What is a kind act someone has done for you recently?"
    };

    int _count = 0;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by havingyou list as many things as you can in a certain area.";
    }
    
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        ShowSpinner(5);
        GetListFromUser();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        Console.WriteLine(_prompts[rand.Next(_prompts.Count)]);

    }

    public void GetListFromUser()
    {
        Console.WriteLine("Start listing items:");        
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"Item {_count + 1}: ");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
    }
}

class ActivityLogger
{
    private Dictionary<string, int> _log = new Dictionary<string, int>();
    
    public void LogActivity(string activityName)
    {
        if (!_log.ContainsKey(activityName))
        {
            _log[activityName] = 0;
        }
        _log[activityName]++;
        DisplayLog();
    }
    
    public void DisplayLog()
    {
        Console.WriteLine("Activity Log:");
        foreach (var entry in _log)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value} times");
        }
        Thread.Sleep(2000);
    }
}
