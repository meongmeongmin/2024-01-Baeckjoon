// 코드 리뷰
// https://mmmin14.tistory.com/16

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

        Stack leftStack = new Stack();
        Stack rightStack = new Stack();

        string inputStr = read.ReadLine();
        foreach (char c in inputStr)
        {
            leftStack.Push(c);
        }

        // 명령어 입력
        int count = Convert.ToInt32(read.ReadLine());   // 명령어 입력 횟수
        for (int i = 0; i < count; i++)
        {
            string[] command = read.ReadLine().Split();
            switch (command[0])
            {
                case "L":
                    if (leftStack.Count > 0)
                        rightStack.Push(leftStack.Pop());
                    break;
                case "D":
                    if (rightStack.Count > 0)
                        leftStack.Push(rightStack.Pop());
                    break;
                case "B":
                    if (leftStack.Count > 0)
                        leftStack.Pop();
                    break;
                case "P":
                    if (!string.IsNullOrEmpty(command[1]))
                        leftStack.Push(command[1]);
                    break;

            }
        }

        print.Write($"{string.Join("", leftStack.ToArray().Reverse())}{string.Join("", rightStack.ToArray())}");
    }
}
