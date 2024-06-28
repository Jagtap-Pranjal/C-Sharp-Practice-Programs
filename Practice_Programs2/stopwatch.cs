using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Create a new stopwatch
        Stopwatch timer = new Stopwatch();

        Console.WriteLine("Press Enter to start the timer.");
        Console.ReadLine();

        // Start the timer
        timer.Start();

        Console.WriteLine("Timer is running. Press Enter again to stop.");
        Console.ReadLine();

        // Stop the timer
        timer.Stop();

        // Get the elapsed time
        TimeSpan time = timer.Elapsed;

        // Display the elapsed time
        Console.WriteLine("Elapsed time: {0:00}:{1:00}:{2:00}.{3:00}", time.Hours, time.Minutes, time.Seconds, time.Milliseconds / 10);

        Console.WriteLine("Press Enter to exit.");
        Console.ReadLine();
    }
}