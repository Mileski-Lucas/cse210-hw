using System;

public class Ideas
{
    private List<string> _ideas = new List<string>()
    {
        "Visit a park - Take some pictures of nature and create captions for those pictures.",
        "Try a new recipe - Cook a dish you've never made before and write about the process and the taste.",
        "Write a letter to your future self - Seal it and set a date to open it in the future.",
        "Go on a short digital detox - Spend a few hours or a full day without screens and reflect on how it feels.",
        "Explore a new place in your city - Visit a museum, coffee shop, or historical landmark and document your impressions.",
        "Watch the sunrise or sunset - Write about how it makes you feel and what thoughts come to mind.",
        "Have a conversation with a stranger - Talk to someone new and journal about what you learned.",
        "Do a random act of kindness - Help someone in need, then reflect on the experience and how it made you feel.",
        "Listen to a song in a foreign language - Try to interpret its meaning and write about how it makes you feel.",
        "Go for a walk without a destination - Observe your surroundings, focus on small details, and describe them in your journal."
    };

    public string GetRandomIdea()
    {
        Random random = new Random();
        int randomIndex = random.Next(_ideas.Count);
        return _ideas[randomIndex];
    }

}