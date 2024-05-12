// 코드 리뷰
// https://mmmin14.tistory.com/25

using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        #region I/O
        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());
        #endregion

        int n = Convert.ToInt32(read.ReadLine());
        string[] input = read.ReadLine().Split();
        Dictionary<int, int> card = new Dictionary<int, int>();
        for (int i = 0; i < n; i++)
        {
            int key = Convert.ToInt32(input[i]);
            if (card.TryGetValue(key, out int count))
                card[key] = count + 1;
            else
                card[key] = 1;
        }

        int m = Convert.ToInt32(read.ReadLine());
        input = read.ReadLine().Split();
        for (int i = 0; i < m; i++)
        {
            int key = Convert.ToInt32(input[i]);
            if (card.TryGetValue(key, out int count))
                print.Write($"{count} ");
            else
                print.Write("0 ");
        }
    }
}
