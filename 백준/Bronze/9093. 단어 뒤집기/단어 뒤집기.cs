using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int t = 0; t < T; t++)
        {
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            StringBuilder reversedSentence = new StringBuilder();

            foreach (string word in words)
            {
               
                string reversedWord = ReverseWord(word);
                reversedSentence.Append(reversedWord + " ");
            }

            Console.WriteLine(reversedSentence.ToString().Trim());
        }
    }

    static string ReverseWord(string word)
    {
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
