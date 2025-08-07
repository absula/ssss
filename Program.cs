// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите номе задания (1-6)");
        string? input = Console.ReadLine();
        switch (input)
        {
            case "1":
                task1.Run();
                break;
            case "2":
                task2.Run();
                break;
            case "3":
                task3.Run();
                break;
            case "4":
                task4.Run();
                break;
            case "5":
                task5.Run();
                break;
            case "6":
                task6.Run();
                break;
            default:
                Console.WriteLine("Неверный номер задания");
                break;

        }

    }
}
