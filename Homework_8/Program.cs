namespace Homework_8_1
{
    internal class Program
    {
        private static readonly int countPerLine = 250;     // Количество чисел для отображения в одном ряду
        private static readonly int countNumbers = 100;     // Количество символов будет сгенерированно
        private static readonly int maxValue = 100;         // Максимальное значение чисел

        private static List<int> numbers = new List<int>();

        private static void Main(string[] args)
        {
            Random random = new();

            for(int i = 0; i < countNumbers; i++)  
            {
                numbers.Add(random.Next(maxValue));
            }

            ShowList("100 сгенерированных чисел:");    

            numbers.RemoveAll(n => n > 25 && n < 50); 

            ShowList($"{numbers.Count} чисел меньших 25 и больших 50:");   

            Console.ReadKey(true);
        }

        /// <summary>
        /// Выводит на экран сиписок чисел от 0 до 100
        /// </summary>
        /// <param name="lable">Коментарий к масииву</param>
        private static void ShowList(string lable)
        {
            PrintLine();
            if (lable != null) 
            {
                Console.WriteLine(lable);
            }

            PrintLine();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i != 0 && i % countPerLine == 0)
                {
                    Console.WriteLine();
                }

                Console.Write("{0:" + ZiroCount() + "} ",numbers[i]);
            }

            Console.WriteLine();

            PrintLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Печатает линию, но не больше чем ширина буффера консоли
        /// </summary>
        private static void PrintLine()
        {
            int count = countPerLine * ((maxValue - 1).ToString().Length + 1) - 1;

            if (Console.BufferWidth < count)
            {
                count = Console.BufferWidth - 1;
            }

            for (int x = 0; x < count; x++) 
            {
                Console.Write("-");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Указывает WriteLine максимальную длину для отображения числа
        /// </summary>
        /// <returns>Длина для отображения</returns>
        private static string ZiroCount()
        {
            string result = "";

            for (int i = 0; i < (maxValue - 1).ToString().Length; i++) 
            {
                result += '0';
            }
            return result;
        }
    }
}