// 코드 리뷰
// https://mmmin14.tistory.com/21

using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        #region I/O
        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());
        #endregion

        string[] input = read.ReadLine().Split();
        int n = Convert.ToInt32(input[0]);
        int m = Convert.ToInt32(input[1]);

        string[] inputCardNum = read.ReadLine().Split();
        int[] cardNum = new int[n];
        for (int i = 0; i < n; i++)
            cardNum[i] = Convert.ToInt32(inputCardNum[i]);

        int result = 0;
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    int sum = cardNum[i] + cardNum[j] + cardNum[k];
                    if (sum == m)
                    {
                        print.Write(sum);
                        return;
                    }

                    if (sum <= m && sum > result)
                        result = sum;
                }
            }
        }

        print.Write(result);
    }
}
