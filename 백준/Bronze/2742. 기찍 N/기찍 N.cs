using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
        
        for (int i = N; i >= 1; i--)
        {
            sw.WriteLine(i);
        }
        sw.Flush();
    }
}
