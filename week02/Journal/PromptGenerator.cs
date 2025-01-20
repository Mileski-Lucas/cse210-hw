using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>()
    {
        "What are three things I'm grateful for today, and why?",
        "How did I overcome a challenge today, and what did I learn from it?",
        "Describe a moment from today that made me smile or laugh.",
        "What is one goal I want to achieve this week, and what steps can I take toward it?",
        "Reflect on a conversation I had today: What did I learn about the other person or myself?",
        "How am I feeling right now, and what might be the reasons behind these emotions?",
        "What is one habit I want to improve or develop, and why is it important to me?",
        "Describe a place I visited today and how it made me feel.",
        "What is one piece of advice I received today, and how can I apply it to my life?",
        "What are three things I did today that made me feel proud or accomplished?",
        "What is one thing I learned today that I didn’t know before, and how can I use this new knowledge?",
        "Who is someone I appreciate in my life, and what actions can I take to show them gratitude?",
        "Reflect on a mistake I made today: What did it teach me, and how can I avoid it in the future?",
        "What is one thing I did today to help someone else, and how did it make me feel?",
        "Describe a moment today when I felt at peace or calm, and what contributed to that feeling.",
        "What is a challenge or obstacle I am currently facing, and what are some potential solutions?",
        "How did I spend my free time today, and did it contribute to my overall well-being or growth?",
        "What is a compliment or positive feedback I received today, and how did it impact my confidence?",
        "Reflect on a time today when I felt outside of my comfort zone: What did I learn from that experience?",
        "What is one way I can improve my communication skills based on an interaction I had today?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}