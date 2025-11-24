using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите четырёхзначное число: ");
        int number = int.Parse(Console.ReadLine());

        int num1 = number / 1000;
        int num2 = (number / 100) % 10;
        int num3 = (number / 10) % 10;
        int num4 = number % 10;

        if (num1 + num4 == num2 - num3)
        {
            Console.WriteLine("ДА");
        }
        else
        {
            Console.WriteLine("НЕТ");
        }
    }
}