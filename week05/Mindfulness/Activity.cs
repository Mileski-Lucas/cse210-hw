using System;

public class Activity
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
        if (seconds >= 10 && seconds < 100)
        {
            for(int i = seconds; i > 0 ; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b\b  \b\b");
                }
        }

        else if(seconds >= 100 && seconds < 1000)
        {
            for(int i = seconds; i > 0 ; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b\b\b   \b\b\b");
                }
        }
               
        else if (seconds < 10 && seconds > 0)
        {
            for(int i = seconds; i > 0 ; i--)
                {
                    Console.Write(i);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
        }

        else
        {
            Console.WriteLine("unable to show countdown");
        }
    }
}
    