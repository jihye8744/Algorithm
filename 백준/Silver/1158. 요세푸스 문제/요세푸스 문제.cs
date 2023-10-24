using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        List<int> result = JosephusPermutation(N, K);

        Console.WriteLine("<" + string.Join(", ", result) + ">");
    }

    static List<int> JosephusPermutation(int N, int K)
    {
        List<int> result = new List<int>();
        List<int> people = new List<int>();

        for (int i = 1; i <= N; i++)
        {
            people.Add(i);
        }

        int index = 0;

        while (people.Count > 0)
        {
            index = (index + K - 1) % people.Count;
            result.Add(people[index]);
            people.RemoveAt(index);
        }

        return result;
    }
}
