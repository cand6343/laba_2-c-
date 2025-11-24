using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите ваш возраст: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18)
        {
            Console.WriteLine("Доступ разрешен");
        }
        else
        {
            Console.WriteLine("Доступ запрещен");
        }
    }
}