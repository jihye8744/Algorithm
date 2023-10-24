using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string result = ReverseWordsInString(input);
        Console.WriteLine(result);
    }

    static string ReverseWordsInString(string input)
    {
        StringBuilder reversedString = new StringBuilder();
        StringBuilder wordBuffer = new StringBuilder();
        bool insideTag = false;
        bool isReversed = false;

        foreach (char c in input)
        {
            if (c == '<')
            {
                if (!insideTag)
                {
                    reversedString.Append(ReverseWord(wordBuffer.ToString()));
                    wordBuffer.Clear();
                }
                insideTag = true;
                reversedString.Append(c);
            }
            else if (c == '>')
            {
                insideTag = false;
                reversedString.Append(c);
            }
            else if (insideTag)
            {
                reversedString.Append(c);
            }
            else if (c == ' ')
            {
                reversedString.Append(ReverseWord(wordBuffer.ToString()));
                wordBuffer.Clear();
                reversedString.Append(c);
            }
            else
            {
                wordBuffer.Append(c);
            }
        }

        if (!insideTag)
        {
            reversedString.Append(ReverseWord(wordBuffer.ToString()));
        }

        return reversedString.ToString();
    }

    static string ReverseWord(string word)
    {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
