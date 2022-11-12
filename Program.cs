// Console.Write("Ведите количество строк массива: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Ведите количество столбцов массива: ");
// int columns = int.Parse(Console.ReadLine()!);

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

// if (rows == columns) Console.Write("Массив не является прямоугольным");
// else
// {
//     int[,] array = GetArray(rows, columns, 0, 10);
//     Console.WriteLine($"Исходный массив: ");
//     PrintArray(array);
//     int[] sumString = SumStringElements(array);
//     Console.WriteLine($"Сумма элементов по строкам: [{String.Join("|", sumString)}]");
//     Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {MaxStringElements(sumString)}");
// }

// Задача 58: 
// Задайте две квадратные матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Write("Ведите количество строк матрицы A: ");
// int rowsA = int.Parse(Console.ReadLine()!);
// Console.Write("Ведите количество столбцов матрицы A: ");
// int columnsA = int.Parse(Console.ReadLine()!);
// Console.Write("Ведите количество строк матрицы B: ");
// int rowsB = int.Parse(Console.ReadLine()!);
// Console.Write("Ведите количество столбцов матрицы B: ");
// int columnsB = int.Parse(Console.ReadLine()!);

// if (columnsA != rowsB)
// {
//     Console.Write("Такие матрицы не соответствуют условию умножения матриц");
//     return;
// }
// else
// {
//     int[,] matrixA = GetArray(rowsA, columnsA, 0, 10);
//     Console.WriteLine("Матрица A: ");
//     PrintArray(matrixA);
//     Console.WriteLine();

//     int[,] matrixB = GetArray(rowsA, columnsA, 0, 10);
//     Console.WriteLine("Матрица B: ");
//     PrintArray(matrixB);
//     Console.WriteLine();

//     Console.WriteLine("Произведение матриц A и B: ");
//     PrintArray(MultMatrix(matrixA, matrixB));
// }

// Задача 60. 
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Write("Ведите длину массива: ");
int x = int.Parse(Console.ReadLine()!);
Console.Write("Ведите высоту массива: ");
int y = int.Parse(Console.ReadLine()!);
Console.Write("Ведите ширину массива: ");
int z = int.Parse(Console.ReadLine()!);

int[, ,] array = GetArray3(x, y, z, 10, 99);
PrintArray3(array);







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

// Метод перемножения 2-х матриц:

int[,] MultMatrix(int[,] ArrayA, int[,] ArrayB)
{
    int[,] ArrayC = new int[ArrayA.GetLength(0), ArrayB.GetLength(1)];
    for (int i = 0; i < ArrayA.GetLength(0); i++)
    {
        for (int j = 0; j < ArrayB.GetLength(1); j++)
        {
            for (int k = 0; k < ArrayA.GetLength(1); k++)
            {
                ArrayC[i, j] += ArrayA[i, k] * ArrayB[k, j];
            }
        }
    }
    return ArrayC;
}

 // Заполнение трехмерного массива случайными целыми числами:
    int[,,] GetArray3(int m, int n, int o, int minValue, int maxValue)
    {
        int[,,] result = new int[m, n, o];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < o; k++)
                {
                    result[i, j, k] = new Random().Next(minValue, maxValue + 1);
                }
            }
        }
        return result;
    }

    // Вывод трехмерного массива:
    void PrintArray3(int[,,] Array)
    {
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            for (int j = 0; j < Array.GetLength(1); j++)
            {
                for (int k = 0; k < Array.GetLength(2); k++)
                {
                    Console.Write($"{Array[i, j, k]} ({i}, {j}, {k}) ");
                }
                Console.WriteLine();
            }
        }
    }