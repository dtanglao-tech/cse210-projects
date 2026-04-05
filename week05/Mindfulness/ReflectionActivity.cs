using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone.",
        "Think of a time when you were selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "How can you apply this again?"
    };

    private List<string> _unusedQuestions;

    public Random _rand = new Random();

    public ReflectionActivity() : base("ReflectionActivity", "Reflection on times you showed strength.")
    {
        _unusedQuestions = new List<string>(_questions);
    }

    public void Run()
    {
        Start();

        Console.WriteLine("\n" + _prompts[_rand.Next(_prompts.Count)]);
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine($"\n> {question}");
            ShowSpinner(4);
        }

        End();
    }

    private string GetRandomQuestion()
    {
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }

        int index = _rand.Next(_unusedQuestions.Count);
        string q = _unusedQuestions[index];
        _unusedQuestions.RemoveAt(index);

        return q;
    }
}