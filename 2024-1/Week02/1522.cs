// 코드 리뷰
// https://mmmin14.tistory.com/17

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        #region I/O
        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());
        #endregion
        
        string input = read.ReadLine();
        string[] str = new string[input.Length];
        int count = 0;
        for (int i = 0; i < input.Length; i++) 
        {
            str[i] = input[i].ToString();
            if (str[i] == "a")
                count++;
        }

        int count2 = 0;
        for (int i = 0; i < input.Length; i++) 
        {
            int count3 = 0;
            for (int j = 0; j < count; j++) 
            {
                if (str[(i + j + input.Length) % input.Length] == "a")
                    count3++;
            }
                
            if (count2 < count3)
                count2 = count3;
        }

        print.WriteLine(count - count2);
    }
}
