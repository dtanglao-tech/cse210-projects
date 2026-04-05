using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are your strengths?",
        "Who have you helped this week?",
        "Who are your heroes?"
    };

    public ListingActivity()
        : base("Listing Activity", "List as many positive things as you can.")
    {
    }

    public void Run()
    {
        Start();
        Random rand = new Random();

        // Display random prompt
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);
        Console.WriteLine("\nStarting in:");
        ShowCountdown(5);

        int count = 0;

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");
        End();
    }
}