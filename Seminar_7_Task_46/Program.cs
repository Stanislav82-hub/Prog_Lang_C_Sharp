// Задача 46. Задайте двумерный массив размером m x n, заполненный случайными целыми числами.

int[,] CreateTwoDimensionArray(int firstLength, int secondLength)
{
    int[,] array = new int[firstLength, secondLength];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

PrintArray(CreateTwoDimensionArray(6, 5));