// 코드 리뷰
// https://mmmin14.tistory.com/22

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

        string[] input = read.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        print.Write(input.Length);
    }
}
