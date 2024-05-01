// 코드 리뷰
// https://mmmin14.tistory.com/23

using System;

class Program
{
    static void Main(string[] args)
    {
        #region I/O
        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());
        #endregion

        int n = Convert.ToInt32(read.ReadLine());
        int[] rope = new int[n];
        for (int i = 0; i < n; i++)
            rope[i] = Convert.ToInt32(read.ReadLine());

        Array.Sort(rope);
        Array.Reverse(rope);
        
        int maxWeight = 0;
        for (int i = 0; i < rope.Length; i++)
        {
            if (maxWeight < rope[i] * (i + 1))
                maxWeight = rope[i] * (i + 1);
        }

        print.Write(maxWeight);
    }
}
