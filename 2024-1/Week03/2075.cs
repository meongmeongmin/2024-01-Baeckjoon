// 코드 리뷰
// https://mmmin14.tistory.com/20

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

        int n = Convert.ToInt32(read.ReadLine());
        PriorityQueue<int, int> priorityQueue = new PriorityQueue<int, int>();

        for (int i = 0; i < n; i++)
        {
            int[] tmp = read.ReadLine().Split().Select(int.Parse).ToArray();
            foreach (var num in tmp)
            {
                priorityQueue.Enqueue(num, num);

                // 우선 순위 큐의 크기를 N으로 유지
                if (priorityQueue.Count > n)
                    priorityQueue.Dequeue(); // 가장 작은(우선 순위가 가장 낮은) 요소 제거
            }
        }

        print.Write(priorityQueue.Dequeue());
    }
}
