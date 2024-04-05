// 코드 리뷰
// https://mmmin14.tistory.com/18

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
        
        string input = read.ReadLine();
        int idx = 0;
        List<string> list = new List<string>();
        for (int i = 0; i < input.Length; i++)
        {
            if (input[idx] != input[i])
            {
                list.Add(input.Substring(idx, i - idx));
                idx = i;
            }
        }
        list.Add(input.Substring(idx, input.Length - idx)); // 마지막 문자열 추출

        int count0 = 0; // 0이 연속된 갯수
        int count1 = 0; // 1이 연속된 갯수
        foreach (string s in list) 
        {
            if (s.Contains("0"))
                count0++;
            else
                count1++;
        }

        print.Write(count0 < count1 ? count0 : count1);
    }
}
