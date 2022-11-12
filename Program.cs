Console.Write("Ведите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Ведите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine()!);

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

// int[,] array = GetArray(rows, columns, 0, 10);
// Console.WriteLine($"Исходный массив: ");
// PrintArray(array);
// SiparateStringArray(array);
// Console.WriteLine();
// Console.WriteLine($"Массив с отсортированными строками: ");
// PrintArray(array);

// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

if (rows == columns) Console.Write("Массив не является прямоугольным");
else
{
    int[,] array = GetArray(rows, columns, 0, 10);
    Console.WriteLine($"Исходный массив: ");
    PrintArray(array);
    int[] sumString = SumStringElements(array);
    Console.WriteLine($"Сумма элементов по строкам: [{String.Join("|", sumString)}]");
    Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {MaxStringElements(sumString)}");
}
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
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j + 1; k < arr.GetLength(1); k++)
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

// Метод нахождения суммы элементов в строке:

int[] SumStringElements(int[,] Array)
{
    int[] sumString = new int[Array.GetLength(0)];
    for (int k = 0; k < Array.GetLength(0);)
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                sumString[k] += Array[i, j];
            }
            k++;
        }
    }
    return sumString;
}

// Нахождение индекса, максимального элемента одномерного массива:
int MaxStringElements(int[] arr)
{
    int i = 0;
    int minPosition = i;
    for (; i < arr.Length; i++)
    {
        if (arr[i] < arr[minPosition]) minPosition = i;
    }
    return minPosition;
}