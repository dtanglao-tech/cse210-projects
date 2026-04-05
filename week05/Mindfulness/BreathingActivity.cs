using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("BreathingActivity", "Relax by slowly breathing in and out.")
    {
    }

    public void Run()
    {
        Start();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            BreatheIn();
            BreatheOut();
        }

        End();
    }

    private void BreatheIn()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("\rBreathe in: " + new string('*', i));
            System.Threading.Thread.Sleep(200);
        }
    }

    private void BreatheOut()
    {
        for (int i = 10; i >= 1; i--)
        {
            Console.Write("\rBreathe out: " + new string('*', i));
            System.Threading.Thread.Sleep(200);
        }
        Console.WriteLine();
    }
}