// Задача 51: Задайте двумерный массив. Найдите сумму элементов находящихся на главной диагонали
// с индексами (0,0); (1;1) и т.д.
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (i == j)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] NewArray = CreateTwoDimensionArray(10, 10);

void SumIndexes(int[,] array)
{
    int sum = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (i == j)
            {
                sum = sum + array[i, j];
            }
    }
    Console.WriteLine($"Result is {sum}");

}

PrintArray(CreateTwoDimensionArray(10, 10));
Console.WriteLine();
SumIndexes(NewArray);

