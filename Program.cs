// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Ведите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Ведите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
Console.WriteLine($"Исходный массив: ");
PrintArray(array);
SiparateStringArray(array);
Console.WriteLine();
Console.WriteLine($"Массив с отсортированными строками: ");
PrintArray(array);

// Заполнение двумерного массива случайными целыми числами:
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

// Вывод двумерного массива:
void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            if (Array[i, j] < 10)
            {
                Console.Write($"0{Array[i, j]} ");
            }
            else
            {
                Console.Write($"{Array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

// Сортировка метода по строкам:
void SiparateStringArray(int[,] arr)
{
    int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j+1; k < arr.GetLength(1); k++)
            {
                if (arr[i, j] < arr[i, k])
                {
                    int temp = arr[i, j];
                    arr[i, j] = arr[i, k];
                    arr[i, k] = temp;
                }

            }
        }
    }
}