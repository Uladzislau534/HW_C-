using System;


class Program
{
    static void Main(string[] args)
    {
        int M = 5;
        int N = 10;
        PrintNumbers(M, N);
    }

    static void PrintNumbers(int M, int N)
    {
        if (M > N)
        {
            return;
        }
    
        Console.WriteLine(M);
     
        PrintNumbers(M + 1, N);
    }
}
