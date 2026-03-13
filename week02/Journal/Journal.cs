using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {   
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter output = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                output.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}|{entry._mood}");
            }
        }

        Console.WriteLine("Journal saved to" + filename);
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        _entries.Clear();

        foreach (string Line in lines)
        {
            string[] parts = Line.Split('|');

            Entry entry = new Entry();
            entry._date = parts[0];
            entry._promptText = parts[1];
            entry._entryText = parts[2];
            entry._mood = parts[3];

            _entries.Add(entry);
        }
        Console.WriteLine("Journal loaded from" + filename);
    }
}