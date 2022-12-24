// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// [1,7] -> такого числа в массиве нет ([1,7] это позиция по индексам, 1- строка и 7 -столбец)

int[,] GetArray()
{
    int[,] result = new int[3, 4];
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PositionArray(int a, int b, int[,] Array)
{
    if (a > 3 || b > 4 || a < 0 || b < 0)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"Число в массиве есть, его номер {Array[a - 1, b - 1]}");
    }
}

Console.Write("Введите позицию элемента массива (номер строки): ");
int i = int.Parse(Console.ReadLine()!);

Console.Write("Введите позицию элемента массива (номер столбца): ");
int j = int.Parse(Console.ReadLine()!);

int[,] array = GetArray();
PrintArray(array);
PositionArray(i, j, array);