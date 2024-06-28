using System;

public class Gray
{
    // This method takes a ulong (64-bit unsigned integer) as input and returns its Gray code encoding
    public static ulong grayEncode(ulong n)
    {
        // The Gray code encoding is done using a simple XOR operation with the input shifted right by 1 bit
        return n ^ (n >> 1);
    }

    // This method takes a ulong (64-bit unsigned integer) as input and returns its original value decoded from Gray code
    public static ulong grayDecode(ulong n)
    {
        // Initialize a variable `i` to a mask with the highest bit set (i.e. 2^63 - 2)
        ulong i = 1 << 8 * 64 - 2; // long is 64-bit

        // Initialize variables `p` and `b` to the result of `n` AND `i`
        ulong p, b = p = n & i;

        // Loop until `i` becomes 0
        while ((i >>= 1) > 0)
        {
            // In each iteration, update `b` by ORing it with the result of `n` AND `i` XOR `p` shifted right by 1 bit
            b |= p = n & i ^ p >> 1;
        }

        // Return the decoded value
        return b;
    }

    // This is the main entry point of the program
    public static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine("Number\tGray");

        // Loop from 0 to 9
        for (ulong i = 0; i < 10; i++)
        {
            // Encode the current number using the grayEncode method
            ulong encoded = grayEncode(i);

            // Convert the encoded value to a binary string and print it along with the original number
            Console.WriteLine(string.Format("{0}\t{1}", i, Convert.ToString((long)encoded, 2)));
        }

        // Wait for the user to press a key
        Console.Read();
    }
}