using System;

public class ReflectingActivity : Activity
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