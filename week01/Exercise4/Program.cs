using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Lets GO with the numbers:)");

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string answer = Console.ReadLine();
            userNumber = int.Parse(answer);
            

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("No numbers were entered.");
            return;
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average:F2}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        //smallest positive number
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }
        if (smallestPositive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("No positive numbers found.");
        }

        //Sorted numbers and sorted list
        numbers.Sort();
        Console.Write("The sorted list is: ");
        for (int i = 0; i < numbers.Count; i++)
        {
            Console.Write(numbers[i]);
            if (i < numbers.Count - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();

    }
}