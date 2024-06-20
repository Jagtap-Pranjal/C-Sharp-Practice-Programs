using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = ConvertToOppositeCase(input);

        Console.WriteLine("Converted string: " + result);
    }

    static string ConvertToOppositeCase(string str)
    {
        char[] charArray = str.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsUpper(charArray[i]))
            {
                charArray[i] = char.ToLower(charArray[i]);
            }
            else if (char.IsLower(charArray[i]))
            {
                charArray[i] = char.ToUpper(charArray[i]);
            }
        }
        return new string(charArray);
    }
}
