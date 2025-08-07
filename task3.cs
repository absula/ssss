using System;
public class task3
{
    public static void Run()
    {
        for (char i = '0'; i <= '7'; i++)
        {
            for (char j = (char)(i + 1); j <= '8'; j++)
            {
                for (char k = (char)(j + 1); k <= '9'; k++)
                {
                    Console.Write(i);
                    Console.Write(j);
                    Console.Write(k);
                    if (!(i == '7' && j == '8' && k == '9'))
                    {
                        Console.Write(',');
                        Console.Write(' ');
                    }
                }
            }
        }
    }
}