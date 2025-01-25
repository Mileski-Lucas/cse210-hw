using System;

class Program
{
    static void Main(string[] args)
    {
        int opt = 0;
        string proceed = "";
               
        Console.WriteLine("Select the option for the scripture you want to memorize ");
        
        Console.Write("1 - ");
        Reference ref_01 = new Reference( "John", 3, 16);
        string scrip_01 = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        
        string[] words_01 = scrip_01.Split(' ');
        Scripture scripture_01 = new Scripture(ref_01.GetDisplayText());
        foreach (string word in words_01)
        {
            scripture_01._words.Add(new Word(word));
        }
        Console.WriteLine(ref_01.GetDisplayText());
        Console.Write("2 - ");
        Reference ref_02 = new Reference("Proverbs", 3, 5, 6);
        string scrip_02 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.In all thy ways acknowledge him, and he shall direct thy paths.";
        
        string[] words_02 = scrip_02.Split(' ');
        Scripture scripture_02 = new Scripture(ref_02.GetDisplayText());
        foreach (string word in words_02)
        {
            scripture_02._words.Add(new Word(word));
        }
        Console.WriteLine(ref_02.GetDisplayText());
        opt = int.Parse(Console.ReadLine());
        if(opt == 1)
        {
            while(proceed != "quit" && !scripture_01.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture_01.GetDisplayText());
                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
                proceed = Console.ReadLine();
                if(proceed != "quit")
                {
                    scripture_01.HideRandomWords(3); // Hide 3 random words each time
                }
                Console.Clear();
                Console.WriteLine(scripture_01.GetDisplayText());
                Console.WriteLine("All words are hidden! Program finished.");
            }
            
        }
        else if(opt == 2)
        {
            while(proceed != "quit" && !scripture_02.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture_02.GetDisplayText());
                Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
                proceed = Console.ReadLine();
                if(proceed != "quit")
                {
                    scripture_02.HideRandomWords(3); // Hide 3 random words each time
                }
                Console.Clear();
                Console.WriteLine(scripture_02.GetDisplayText());
                Console.WriteLine("All words are hidden! Program finished.");
            }

        }
            
    }
}
