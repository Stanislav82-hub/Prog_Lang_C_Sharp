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
            Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
}

void ChangeRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }


}

void ChangeRowsAndColumns(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j > i)
            {
                temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }

        }
    }

}

(int x, int y) MinIndex(int[,] array)
{
    int min_i = 0;
    int min_j = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[min_i, min_j])
            {
                min_i = i; min_j = j;
            }

        }

    }
    return (min_i, min_j);
}

int[,] DelRowAndColumn(int[,] array, (int x, int y) min)
{
    int shift_x = 0;
    int shift_y = 0;
    int[,] array_one = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array_one.GetLength(0); i++)
    {
        if (i == min.x) shift_x = 1;
        for (int j = 0; j < array_one.GetLength(1); j++)
        {
            if (j == min.y) shift_y = 1;
            array_one[i, j] = array[i + shift_x, j + shift_y];
        }
    }
    return array_one;
}



//Задача 53. Задайте двумерный массив.Напишите программу, которая поменяет местами первую
// и последнюю строку массива.

void Seminar_8_Task_53()
{
    int[,] arr = CreateTwoDimensionArray(4, 4);
    PrintArray(arr);
    ChangeRows(arr);
    Console.WriteLine();
    PrintArray(arr);
}

//Задача 55. Задайте двумерный массив.Напишите программу, которая заменяет строки на столбцы.В случае если это не 
// возможно, программа должна вывести сообщение для пользователя.

void Seminar_8_Task_55()
{
    int[,] arr = CreateTwoDimensionArray(4, 4);
    PrintArray(arr);
    ChangeRowsAndColumns(arr);
    Console.WriteLine();
    PrintArray(arr);

}

// Задача 59. Задайте двумерный массив из целых чисел. Напишите программу которая удалит строку и столбец, на пересечении
//которых расположен наименьший элемент массива.

void Seminar_8_Task_59()
{
    int[,] arr = CreateTwoDimensionArray(4, 4);
    PrintArray(arr);
    int[,] NewArray = DelRowAndColumn(arr, MinIndex(arr));
    System.Console.WriteLine();
    PrintArray(NewArray);
}

//Seminar_8_Task_53();
//Seminar_8_Task_55();
Seminar_8_Task_59();
