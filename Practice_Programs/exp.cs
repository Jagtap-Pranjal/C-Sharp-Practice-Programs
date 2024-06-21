using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Define regular expression patterns
        string namePattern = @"[a-zA-Z]+"; // This pattern matches one or more alphabetic characters
        string numberPattern = @"\d+";    // This pattern matches one or more digits

        // Find matches for names
        MatchCollection nameMatches = Regex.Matches(input, namePattern);
        Console.WriteLine("Found name matches:");
        foreach (Match match in nameMatches)
        {
            Console.WriteLine(match.Value);
        }

        // Find matches for numbers
        MatchCollection numberMatches = Regex.Matches(input, numberPattern);
        Console.WriteLine("Found number matches:");
        foreach (Match match in numberMatches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
