// 코드 리뷰
// https://mmmin14.tistory.com/24

using System;

class Program
{
    static void Main(string[] args)
    {
        #region I/O
        using var read = new System.IO.StreamReader(Console.OpenStandardInput());
        using var print = new System.IO.StreamWriter(Console.OpenStandardOutput());
        #endregion

        int input = Convert.ToInt32(read.ReadLine());
        int[] tree = new int[input];
        for (int i = 0; i < tree.Length; i++)
            tree[i] = Convert.ToInt32(read.ReadLine());

        int gcd = Gcd(tree[1] - tree[0], tree[2] - tree[1]);
        for (int i = 2; i < tree.Length; i++)
            gcd = Gcd(gcd, tree[i] - tree[i - 1]);

        print.Write((tree[tree.Length - 1] - tree[0]) / gcd - tree.Length + 1);
    }

    static int Gcd(int n, int m)
    {
        if (m == 0)
            return n;
        return Gcd(m, n % m);
    }
}
