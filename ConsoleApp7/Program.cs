using System;

class Program
{
    static void Main()
    {
        Console.Write("Выберите уровень сложности (1-3): ");
        int level = int.Parse(Console.ReadLine());

        switch (level)
        {
            case 1:
                Console.WriteLine("Легкий");
                break;
            case 2:
                Console.WriteLine("Средний");
                break;
            case 3:
                Console.WriteLine("Сложный");
                break;
            default:
                Console.WriteLine("Ошибка");
                break;
        }
    }
}