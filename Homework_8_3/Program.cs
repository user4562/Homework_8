namespace Homework_8_3
{
    internal class Program
    {
        private static HashSet<double> setNumbers = new HashSet<double>();

        static void Main(string[] args)
        {
            double number;
            string input;

            while (true)
            {
                Console.Write("Введите чило:");
                input = Console.ReadLine();

                if(string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Данные успешно сохранены.");
                    Console.ReadKey();
                    break;
                }

                if (double.TryParse(input, out number))
                {
                    if(!setNumbers.Add(number))
                    {
                        Console.WriteLine("Число уже вводилось ранее.");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не число.");
                }
            }
        }
    }

}