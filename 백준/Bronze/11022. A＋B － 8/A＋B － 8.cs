using System;
class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());
        int[] A = new int[T];
        int[] B = new int[T];
        int[] C = new int[T];
        int i;

        for (i = 0; i < T; i ++)
        {
          
            string[] input = Console.ReadLine().Split();
            A[i] = int.Parse(input[0]);
            B[i] = int.Parse(input[1]);
            C[i] = A[i] + B[i];

        }
        Console.Clear();
        for (i = 0; i < T; i++)
        {
            Console.WriteLine($"Case #{i + 1}: {A[i]} + {B[i]} = {C[i]}");
        }

    }
}