namespace Program
{
    internal class Program
    {
        // Статическая переменная для хранения здоровья персонажа
        static int health = 100;

        static void Main(string[] args)
        {
            // Вывод начального здоровья персонажа
            Console.WriteLine($"Здоровье персонажа: {health}");

            // Вызов метода для нанесения урона персонажу
            TakeDamage(30);
        }

        // Метод для нанесения урона персонажу
        static void TakeDamage(int damage)
        {
            // Уменьшение здоровья на величину урона
            health -= damage;

            // Вывод информации о полученном уроне и текущем здоровье
            Console.WriteLine($"Персонаж получил {damage} урона. Текущее здоровье: {health}.");
        }
    }
}