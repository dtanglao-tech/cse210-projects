using System;

class Program
{
    static void Main(string[] args)
    {
        // Fr my creativity
        // I added this program allows the user to record their mood for each journal entry.
        // The mood is saved along with the date, prompt, and journal entry.
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        int choice = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");


            string input = Console.ReadLine();

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Invalid Input. Please enter from 1 to 5.\n");
                continue;
            }

            else if (choice == 1)
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine(prompt);
                Console.Write("> ");
                string entryText = Console.ReadLine();

                Console.Write("How was your mood today?");
                string mood = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = prompt;
                entry._entryText = entryText;
                entry._mood = mood;

                journal.AddEntry(entry);
            }

            else if (choice == 2)
            {
                journal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.Write("What is the filename? ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }

            else if (choice == 4)
            {
                Console.Write("What is the file name? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
        }
    }
}