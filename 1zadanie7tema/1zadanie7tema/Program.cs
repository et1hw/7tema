using System;

class Program
{
    // Метод для сортировки массива по возрастанию
    static int[] SortAscending(int[] array)
    {
        Array.Sort(array);
        return array;
    }

    // Метод для сортировки массива по убыванию
    static int[] SortDescending(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
        return array;
    }

    // Метод для объединения двух массивов в один
    static int[] MergeArrays(int[] array1, int[] array2)
    {
        int[] mergedArray = new int[array1.Length + array2.Length];
        array1.CopyTo(mergedArray, 0);
        array2.CopyTo(mergedArray, array1.Length);
        return mergedArray;
    }

    static void Main()
    {
        // Пример использования
        int[] array1 = { 5, 2, 8, 1, 3 };
        int[] array2 = { 7, 6, 4, 9 };

        Console.WriteLine("Массив 1:");
        Console.WriteLine(string.Join(", ", array1));

        Console.WriteLine("Массив 2:");
        Console.WriteLine(string.Join(", ", array2));

        // Сортировка по возрастанию
        int[] sortedAsc = SortAscending((int[])array1.Clone());
        Console.WriteLine("\nМассив 1 (по возрастанию):");
        Console.WriteLine(string.Join(", ", sortedAsc));

        // Сортировка по убыванию
        int[] sortedDesc = SortDescending((int[])array1.Clone());
        Console.WriteLine("\nМассив 1 (по убыванию):");
        Console.WriteLine(string.Join(", ", sortedDesc));

        // Объединение массивов
        int[] mergedArray = MergeArrays(array1, array2);
        Console.WriteLine("\nОбъединённый массив:");
        Console.WriteLine(string.Join(", ", mergedArray));
    }
}
