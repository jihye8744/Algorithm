using System;

class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int t = 0; t < T; t++)
        {
            string input = Console.ReadLine();
            string result = VPS(input) ? "YES" : "NO";
            Console.WriteLine(result);
        }
    }

    static bool VPS(string input)
    {
        int count = 0;

        foreach (char bracket in input)
        {
            if (bracket == '(')
            {
                count++;
            }
            else if (bracket == ')')
            {
                count--;
            }

            if (count < 0)
            {
                return false;
            }
        }

        return count == 0; 
    }
}
