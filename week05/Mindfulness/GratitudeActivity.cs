using System;

public class GratitudeActivity : Activity
{
    public GratitudeActivity() : base("GratitudeActivity", "Focus on things you are grateful for.")
    {
    }

    public void Run()
    {
        Start();

        Console.WriteLine("\nList things you are grateful for:");
        ShowCountdown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} grateful items!");
        End();
    }

}