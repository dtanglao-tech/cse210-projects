using System;
using System.IO;

public static class ActivityLog
{
    private static string _file = "log.txt";

    public static void Save(string name, int duration)
    {
        string entry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {name} ({duration}s)";
        File.AppendAllText(_file, entry + Environment.NewLine);
    }

    public static void Display()
    {
        if (File.Exists(_file))
        {
            Console.WriteLine("\n=== Activity Log ===\n");

            string[] lines = File.ReadAllLines(_file);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("\nNo log found.");
        }
    }
}