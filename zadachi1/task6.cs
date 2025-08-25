using System;
public class task6
{
    public static void Run()
    {
        PrintCombN(3);
    }
    public static void PrintCombN(int n)
    {
        if (n < 1 || n > 9)
            return;
        int[] combo = new int[n];
        GenerateCombo(combo, 0, 0, n);
    }
    static void GenerateCombo(int[] combo, int index, int startDigit, int n)
    {
        if (index == n)
        {
            for (int i = 0; i < n; i++)
                Console.Write((char)(combo[i] + '0'));
            if (!(combo[0] == 10 - n))
                Console.Write(", ");
            return;
        }
        for (int digit = startDigit; digit <= 9; digit++)
        {
            if (10 - digit < n - index)
                break;
            combo[index] = digit;
            GenerateCombo(combo, index + 1, digit + 1, n);
        }
    }
}