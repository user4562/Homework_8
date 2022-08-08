// Программа - телефонная кника

namespace Homework_8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number;
            string user;

            Dictionary<string, string> phoneBook = new();

            Console.WriteLine("Телефонная книга.\n");
            Console.WriteLine("Вводите номера телефонов, и имена их владельцев.");
            Console.WriteLine("Для выхода из режима добавления в телфонную книгу");
            Console.WriteLine("введите пустую строку.\n");
            
            while(true)                  // Добавление записей в телефонную книгу
            {
                if (!GetInput(out number, "Введите номер.")) break;

                if (phoneBook.ContainsKey(number))
                {
                    Console.WriteLine("Такой номер уже есть в телефонной книге.");
                    continue;
                }

                if (!GetInput(out user, "Введите имя владельца номера.")) break;

                phoneBook.Add(number, user);
            }

            if (phoneBook.Count == 0)    // Если не было ввода
            {
                Console.WriteLine("Вы не ввели ни одного номера.");
                Console.WriteLine("Программа будет закрыта");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Поиск владельца по номеру телефона.\n");

            while(true)                 // Поиск имен по номерам
            {
                if (!GetInput(out number, "Введите номер.")) break;

                if (phoneBook.TryGetValue(number, out user))
                {
                    Console.WriteLine(user);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("В телефонной книге нет такого номера.");
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Получает ввод от пользователя
        /// </summary>
        /// <param name="value">Переменная для получения ввода</param>
        /// <param name="lable">Текст для вывода на экран перед вводом</param>
        /// <returns>Пустая строка или нет</returns>
        private static bool GetInput(out string value, string lable)
        {
            Console.Write($"{lable}\n>");
            value = Console.ReadLine();
            Console.WriteLine();
            return !string.IsNullOrEmpty(value);
        }

    }
}