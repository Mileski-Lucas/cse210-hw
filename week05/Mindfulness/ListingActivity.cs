using System;

public class ListingActivity : Activity
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