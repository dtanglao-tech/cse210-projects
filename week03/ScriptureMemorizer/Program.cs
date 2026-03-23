using System;
using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        // I added to Loads scriptures form a file and to Randomly slects a scripture.
        List<Scripture> scriptures = LoadScriptures("scriptures.txt");
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures found.");
            return;
        }

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine($"\nProgress: {scripture.GetProgress():0}% hidden");
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit");

            string input = Console.ReadLine();
            if (input != null)
                input = input.Trim().ToLower();

            else 
                input = "";

            if (scripture.IsCompletelyHidden())
                break;  

            scripture.HideRandomWords();
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Program ended.");
    }
    static List<Scripture> LoadScriptures(string filename)
    {
        var list = new List<Scripture>();

        if (!File.Exists(filename))
            return list;

        foreach (string line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split('|');

            try
            {
                if (parts.Length == 4)
                {
                    list.Add(new Scripture(
                        new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2])),
                        parts[3]));
                }

                else if (parts.Length == 5)
                {
                    list.Add(new Scripture(
                        new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3])),
                        parts[4]));
                }
            }
            catch {}
        }
        return list;
    }
}