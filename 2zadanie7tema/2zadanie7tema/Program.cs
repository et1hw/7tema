using System;

class Program
{
    // Метод для расчета абсолютной разности с учетом правила
    static int CalculateDifference(int n)
    {
        int referenceValue = 123; // Базовое число
        int difference = Math.Abs(n - referenceValue);

        // Условие: если число больше 123, вернем тройную разность
        return n > referenceValue ? difference * 3 : difference;
    }

    // Метод для запроса числа у пользователя с проверкой ввода
    static int GetValidatedInput()
    {
        int input;
        while (true)
        {
            Console.Write("Введите целое число: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out input))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное целое число.");
            }
        }
        return input;
    }

    static void Main()
    {
        Console.WriteLine("Программа для расчета абсолютной разности с числом 123.");
        int n = GetValidatedInput(); // Получаем число от пользователя

        int result = CalculateDifference(n); // Вычисляем разность
        Console.WriteLine($"Результат: {result}");

        // Дополнительно выводим пояснение результата
        if (n > 123)
        {
            Console.WriteLine($"Число {n} больше 123, поэтому абсолютная разность умножена на 3.");
        }
        else
        {
            Console.WriteLine($"Число {n} меньше или равно 123, поэтому возвращена обычная разность.");
        }
    }
}
