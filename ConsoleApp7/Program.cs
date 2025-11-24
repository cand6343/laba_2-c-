using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        if (num1 < num2)
        {
            Console.WriteLine(num1);
        }
        else
        {
            Console.WriteLine(num2);
        }
    }
}