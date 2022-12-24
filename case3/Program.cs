// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
// в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int a, int b)
{
    int[,] result = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            result[i, j] = new Random().Next(0, 10);
            Console.Write($"{result[i, j]} ");
        }
        Console.WriteLine();
    }
    return result;
}

void Average(int[,] array)
{
    Console.WriteLine("\nСреднее арифметическое каждого столбца: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double SumElem = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            SumElem += array[i, j];
        }
        double AverageElem = Math.Round(SumElem / array.GetLength(0), 1);
        Console.Write($"{AverageElem}   ");
    }
}
Console.WriteLine("Введите размер массива (количество строк): ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите размер массива (количество столбцов): ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Average(CreateArray(a, b));
Console.WriteLine();