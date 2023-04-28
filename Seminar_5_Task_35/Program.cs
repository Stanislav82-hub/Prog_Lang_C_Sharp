//Задайте одномерный массив, состоящий из случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].

void NewRamdomArray()
{
    int index = 12;
    int[] array = new int[index];
    FillRandomNumber(array);
    PrintArray(array);
    FillRandomNumber(array);
    Console.WriteLine($"Numbers quantity is {CountElement(array)}");
}

void FillRandomNumber(int[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-20, 150);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");

    }
    Console.WriteLine("");
}

int CountElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

NewRamdomArray();
