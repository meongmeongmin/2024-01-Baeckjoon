// 코드 리뷰
// https://mmmin14.tistory.com/14

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
        
        int input = Convert.ToInt32(read.ReadLine());   // 입력
        int[][] num = new int[input][];

	    string inputNum;
        for (int i = 0; i < input; i++) 
        {
            inputNum = read.ReadLine();
            num[i] = Array.ConvertAll(inputNum.Split(), int.Parse);
            Array.Sort(num[i]);
        }

        for (int i = 0; i < input; i++) 
        {
            print.WriteLine(num[i][7]);
        }
    }
}
