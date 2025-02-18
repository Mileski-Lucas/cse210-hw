using System;

public class ExtraChallenge
{
    private List<string> _extra = new List<string>
    {
        " ",
        "What about an extra challenge: Complete at least 2 goals today",
        " ",
        "Have you added a new goal today? Add at least 1 new goal",
        " ",
        "How much time are you working in your goals? Consider setting a goal to stay on track!",
        " ",
        "Have you done any physical exercise today? Set a goal to stay active!",
        " ",
        "Think about last week. Is there room for improvement? Set a goal to grow!"
    };

    public void GetRandomPrompt()
    {
        Random rand = new Random();
        Console.WriteLine(_extra[rand.Next(_extra.Count)]);
    }
}