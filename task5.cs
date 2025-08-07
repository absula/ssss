using System;
public class task5
{
    public static void Run()
    {
        PrintNbr(-123);
        PrintNbr(0);
        PrintNbr(123);
        Console.WriteLine();
    }
    public static void PrintNbr(int n)
    {
        if (n < 0)
        {
            Console.Write('-');
            n = -n;
        }
        if (n > 9)
        {
            PrintNbr(n / 10);
        }
        char digit = (char)((n % 10) + '0');
        Console.Write(digit);
    }
}