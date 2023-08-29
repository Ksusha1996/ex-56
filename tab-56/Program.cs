// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        int minSumRow = FindRowWithMinSum(array);

        Console.WriteLine("Строка с наименьшей суммой элементов: " + (minSumRow + 1));

        Console.ReadLine();
    }

    static int FindRowWithMinSum(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        int minSum = int.MaxValue;
        int minSumRow = -1;

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < columns; j++)
            {
                sum += array[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minSumRow = i;
            }
        }

        return minSumRow;
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
