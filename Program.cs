using System;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int n = 0;
            bool isValid;
            do
            {
                Console.Write("Введіть натуральне число n: ");
                isValid = int.TryParse(Console.ReadLine(), out n) && n >= 1;

                if (!isValid)
                {
                    Console.WriteLine("Помилка: потрібне ціле число, не менше 1.");
                }
            }
            while (!isValid);

            if (n == 1)
            {
                Console.WriteLine("Число 1 — не просте.");
            }
            else
            {
                int checkedCount = 0;   // лічильник перевірених дільників
                int firstDivisor = 0;   // 0 — дільника не знайдено

                
                for (int d = 2; (long)d * d <= n; d++)
                {
                    checkedCount++;

                    if (n % d == 0)
                    {
                        firstDivisor = d;
                        break;          
                    }
                }

                if (firstDivisor == 0)
                {
                    Console.WriteLine($"Число {n} — просте.");
                }
                else
                {
                    Console.WriteLine($"Число {n} — складене, перший дільник: {firstDivisor}.");
                }
                Console.WriteLine($"Перевірено дільників: {checkedCount}");
            }

            
            int size = 0;
            do
            {
                Console.Write("Введіть сторону квадрата (від 3 до 20): ");
                isValid = int.TryParse(Console.ReadLine(), out size) && size >= 3 && size <= 20;

                if (!isValid)
                {
                    Console.WriteLine("Помилка: потрібне ціле число від 3 до 20.");
                }
            }
            while (!isValid);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    char symbol;
                    if (i == j || i + j == size - 1)
                    {
                        symbol = '#';
                    }
                    else if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        symbol = '*';
                    }
                    else
                    {
                        symbol = ' ';
                    }
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
