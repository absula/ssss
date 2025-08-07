using System;
public class task2
{
    public static void Run()
    {
        Console.WriteLine("Введите число");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            CheckNumber(number);
        }
        else
        {
            Console.WriteLine("Некорректный ввод");
        }
    }
    public static void CheckNumber(int num)
    {
        if (num < 0)
            Console.WriteLine("T");
        else
            Console.WriteLine("F"); 
    }
}
