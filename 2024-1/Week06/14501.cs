// 코드 리뷰
// https://mmmin14.tistory.com/27

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
        int[] t = new int[n];
        int[] p = new int[n];
        for (int i = 0; i < n; i++)
        {
            string[] input = read.ReadLine().Split();
            t[i] = Convert.ToInt32(input[0]);
            p[i] = Convert.ToInt32(input[1]);
        }

        int[] dp = new int[n + 1];
        for (int i = n - 1; i >= 0; i--)
        {
            int nextDay = i + t[i];
            if (nextDay <= n)
                dp[i] = Math.Max(p[i] + dp[nextDay], dp[i + 1]);
            else
                dp[i] = dp[i + 1];
        }

        print.Write(dp[0]);
    }
}
