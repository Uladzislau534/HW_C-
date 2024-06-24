using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Массив о обратном порядке:");
        PrintArrayInReverse(array, array.Length - 1);
    }

    static void PrintArrayInReverse(int[] array, int index)
    {
        if (index < 0)
        {
            return;
        }

        Console.WriteLine(array[index]);
        PrintArrayInReverse(array, index - 1);
    }
}
