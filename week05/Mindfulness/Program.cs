using System;


class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        ActivityLogger logger = new ActivityLogger();
        
        while (option != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("What would you like to do? ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                //Starts breathing activity
                BreathingActivity activity = new BreathingActivity();
                
                activity.Run();
                logger.LogActivity("Breathing");
                
            }
            else if (option == 2)
            {
                //Starts reflecting activity
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
                logger.LogActivity("Reflecting");
            }
            else if (option == 3)
            {
                //starts listing activity
                ListingActivity activity = new ListingActivity();
                activity.Run();
                logger.LogActivity("Listing");
            }

            
        }
    }
}