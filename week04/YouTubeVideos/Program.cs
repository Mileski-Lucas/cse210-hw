using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Cooking every recipe I see online for a week", "Drew Gooden", 1572);
        Video video2 = new Video("The Weeknd - Open Hearts (Live on Jimmy Kimmel Live!)", "The Weeknd", 348);
        Video video3 = new Video("I Tested 24 Restaurants In 24 Hours...", "Calfreezy", 3342);

        video1.AddComment(new Comment("FC-00", "Love Amanda's bread corner!"));
        video1.AddComment(new Comment("Sofija", "Just for educational purposes: the mozzarella didn't work because it didn't reach a high enough temperature. The thermometer was touching the bottom of the pan, which reaches a higher heat quicker than the rest of the cheese."));
        video1.AddComment(new Comment("SophieHyde", "amanda breaking out the flute is crazy"));

        video2.AddComment(new Comment("Kujo", "Rest well The weeknd, Good morning Abel."));
        video2.AddComment(new Comment("CarolTrejo", "I just finished listening to the whole album and it was just a euphoric feeling. This made me love music again."));
        video2.AddComment(new Comment("Jevvv", " YOU ARE DEFINITELY ONE OF THE ONLY ONES BRAVE ENOUGH TO WALK THROUGH THAT DOOR"));

        video3.AddComment(new Comment("justgreg", "freezy's  channel has become a food channel at this point"));
        video3.AddComment(new Comment("Xtatic", "Love the guests! Clarkey has become one of my favorite features on all of the main UK YouTube channels"));
        video3.AddComment(new Comment("kyky", "At this stage George should just be in every Youtube video, he makes them so joyous."));

        List<Video> videos = new List<Video> { video1, video2, video3 };    
        
        foreach (var video in videos)
        {
            video.Display();
        }
        

    }
}