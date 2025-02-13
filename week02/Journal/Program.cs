using System;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main(string[] args)
    {
        
        Journal myJournal = new Journal();
        int option = 0;
        

        while (option != 6)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Without Ideas?");
            Console.WriteLine("6. Quit");
            Console.Write("What would you like to do? ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                // Write
                myJournal.AddEntry();
            }
            else if (option == 2)
            {
                // Display all
                myJournal.DisplayAll();
            }
            else if (option == 3)
            {
                // Load
                Console.Write("Enter the file name to load: ");
                string fileName = Console.ReadLine();
                myJournal.LoadFromFile(fileName);
            }
            else if (option == 4)
            {
                // Save
                Console.Write("Enter the file name to save: ");
                string fileName = Console.ReadLine();
                myJournal.SaveToFile(fileName);
            }
            else if (option == 5)
            {
                //run a random list of tasks to help user have new entries.
                Console.WriteLine("What about trying something new today? You can come back later and share what you did.");
                Ideas _newIdeas = new Ideas();
                Console.WriteLine($"{_newIdeas.GetRandomIdea()}");

            }
        }
    }
}