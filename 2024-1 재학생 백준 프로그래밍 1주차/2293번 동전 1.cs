using System;
using System.Collections;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        #region I/O
        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());
        #endregion
        
        string input = read.ReadLine(); // 입력
        int[] inputNum = Array.ConvertAll(input.Split(), int.Parse);
        int count = inputNum[0];    // 인덱스 0은 숫자 갯수
        int total = inputNum[1];    // 인덱스 1은 숫자합

        int[] num = new int[count];
        for (int i = 0; i < count; i++) 
        {
            num[i] = Convert.ToInt32(read.ReadLine());
        }

        Array.Sort(num);
        int[] dp = new int[total];
        for (int i = 0; i < total; i++)
        {
            if ((i + 1) % num[0] == 0)
                dp[i]++;
        }
        
        for (int i = 1; i < count; i++)
        {
            bool find = false;
            for (int j = 0; j < total; j++)
            {
                if (find == false && (j + 1) == num[i])
                {
                    find = true;
                    dp[j]++;
                    continue;
                }

                if (find == false)
                    continue;

                dp[j] = dp[j] + dp[j - num[i]];
            }
        }

        print.Write(dp[total - 1]);
    }
}
