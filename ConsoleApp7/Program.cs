using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Вы стоите перед первой дверью. Перед вами два пути:");
        Console.WriteLine("A - Войти в комнату с огромным драконом");
        Console.WriteLine("B - Пойти по темному коридору");
        Console.Write("Выберите путь (A/B): ");
        string choice = Console.ReadLine().ToUpper();

        if (choice == "A")
        {
            Console.WriteLine("Дракон говорит: \"Кто не дышит, но живет; хоть не нужно — много пьет; и в жизни, и в смерти тело как лед.\"");
            Console.Write("Ваш ответ: ");
            string answer = Console.ReadLine().ToLower();

            if (answer == "рыба")
            {
                Console.WriteLine("Правильно! Дракон открывает дверь в следующую комнату.");
            }
            else
            {
                Console.WriteLine("Неправильно! Дракон съедает вас!");
            }
        }
        else if (choice == "B")
        {
            Console.WriteLine("Вы в темной комнате с двумя дверями:");
            Console.WriteLine("1 - Дверь с сокровищами Dungeon Master’а");
            Console.WriteLine("2 - Дверь с ловушкой с ядовитыми шипами");
            Console.Write("Выберите дверь (1/2): ");
            string door = Console.ReadLine();

            if (door == "1")
            {
                Console.WriteLine("Поздравляем! Вы нашли сокровища Dungeon Master’а!");
            }
            else if (door == "2")
            {
                Console.WriteLine("Вы попали в ловушку с ядовитыми шипами!");
            }
            else
            {
                Console.WriteLine("Неверный выбор!");
            }
        }
        else
        {
            Console.WriteLine("Неверный выбор!");
        }
    }
}