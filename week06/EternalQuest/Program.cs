using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        ExtraChallenge _randChallenge = new ExtraChallenge();
        _randChallenge.GetRandomPrompt();
        Console.WriteLine("Press any key to start the program...");
        Console.ReadKey();

        GoalManager manager = new GoalManager();
        manager.Start();
    }

}