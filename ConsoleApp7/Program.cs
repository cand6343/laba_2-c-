using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите пароль: ");
        string password = Console.ReadLine();

        Console.Write("Подтвердите пароль: ");
        string confirmPassword = Console.ReadLine();

        if (password == confirmPassword)
        {
            Console.WriteLine("Пароль принят");
        }
        else
        {
            Console.WriteLine("Пароль не принят");
        }
    }
}