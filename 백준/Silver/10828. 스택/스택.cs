using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < N; i++)
        {
            string input = Console.ReadLine();
            string output = ProcessCommand(input, stack);

            if (output != null)
            {
                result.AppendLine(output);
            }
        }

        Console.Write(result);
    }

    static string ProcessCommand(string input, Stack<int> stack)
    {
        string[] parts = input.Split();
        string command = parts[0];

        if (command == "push")
        {
            int X = int.Parse(parts[1]);
            stack.Push(X);
            return null;
        }
        else if (command == "pop")
        {
            if (stack.Count > 0)
            {
                return stack.Pop().ToString();
            }
            else
            {
                return "-1";
            }
        }
        else if (command == "size")
        {
            return stack.Count.ToString();
        }
        else if (command == "empty")
        {
            return (stack.Count == 0) ? "1" : "0";
        }
        else if (command == "top")
        {
            if (stack.Count > 0)
            {
                return stack.Peek().ToString();
            }
            else
            {
                return "-1";
            }
        }

        return null;
    }
}
