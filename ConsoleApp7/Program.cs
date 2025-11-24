using System;

class Program
{
    static void Main()
    {
        int sum = 0;

        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        if (num1 > 0) sum += num1;

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());
        if (num2 > 0) sum += num2;

        Console.Write("Введите третье число: ");
        int num3 = int.Parse(Console.ReadLine());
        if (num3 > 0) sum += num3;

        Console.WriteLine($"Сумма положительных чисел: {sum}");
    }
}