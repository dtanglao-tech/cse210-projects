using System;

// for my creativity I added Activity log system(to save files),
// Prevent repeating reflection and questions until all are used.
//I also added Gratitude activity.
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Activities");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Gratitude Activity");
            Console.WriteLine("5. View Log");
            Console.WriteLine("6. Quit");
            Console.Write("\nChoose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
                new BreathingActivity().Run();
                
            else if (choice == "2")
                new ReflectionActivity().Run();

            else if (choice == "3")
                new ListingActivity().Run();

            else if (choice == "4")
                new GratitudeActivity().Run();

            else if (choice == "5")
                ActivityLog.Display();

            else if (choice == "6")
                break;

            else
                Console.WriteLine("\nInvalid choice. Try again.");

            Console.WriteLine("\nPress Enter to return to continue...");
            Console.ReadLine();
        }
    }
}