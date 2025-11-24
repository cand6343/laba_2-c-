using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите класс персонажа: ");
        string characterClass = Console.ReadLine();

        if (characterClass == "воин" || characterClass == "паладин" || characterClass == "варвар" || characterClass == "разбойник")
        {
            Console.WriteLine("Ближний боец");
        }
        else if (characterClass == "маг" || characterClass == "охотник" || characterClass == "жрец" || characterClass == "друид")
        {
            Console.WriteLine("Дальнобойщик");
        }
        else
        {
            Console.WriteLine("Неизвестный класс");
        }
    }
}