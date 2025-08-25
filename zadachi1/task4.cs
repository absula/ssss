using System;
public class task4
{
    public static void Run()
    {
        for (int i = 0; i <= 98; i++)
        {
            for (int j = i + 1; j <= 99; j++)
            {
                Console.Write((char)((i / 10) + '0'));
                Console.Write((char)((i % 10) + '0'));
                Console.Write(' ');
                Console.Write((char)((j % 10) + '0'));
                Console.Write((char)((j % 10) + '0'));
                if (!(i == 98 && j == 99))
                {
                    Console.Write(',');
                    Console.Write(' ');
                }
            }
        }
        Console.WriteLine();
    }
}