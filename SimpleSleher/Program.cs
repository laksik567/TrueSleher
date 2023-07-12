using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в GACHI Слешер!");
        Console.WriteLine("Сейчас вам сделаю настоящий fisting!!");

        // Инициализация игрока и противника
        int playerHealth = 69;
        int enemyHealth = 1500;

        // Игровой цикл
        while (playerHealth > 0 && enemyHealth > 0)
        {
            // Атака игрока
            Console.WriteLine("Вы атакуете slave!");
            Random rnd = new Random();
            int playerDamage = rnd.Next(1, 1499); // Случайное число от 5 до 10
            enemyHealth -= playerDamage;
            Console.WriteLine("Вы нанесли cum на {0} урона противнику.", playerDamage);

            // Проверка состояния противника
            if (enemyHealth <= 0)
            {
                Console.WriteLine("Вы сделали fisting противнику!");
                break;
            }

            // Атака противника
            Console.WriteLine("Slave атакует вас!");
            int enemyDamage = rnd.Next(1, 69); // Случайное число от 3 до 7
            playerHealth -= enemyDamage;
            Console.WriteLine("Противник нанес вам {0} урона.", enemyDamage);

            // Проверка состояния игрока
            if (playerHealth <= 0)
            {
                Console.WriteLine("Вы были выебаны нахуй - 1 миска рис и хуй!!");
                break;
            }

            Console.WriteLine("Ваше здоровье: {0}", playerHealth);
            Console.WriteLine("Здоровье противника: {0}", enemyHealth);
        }

        Console.WriteLine("ВЫ ПОЛУЧИЛИ ОБНОВЛЕНИЕ НА ИГРУ SEX.");
        Console.ReadLine();
    }
}
