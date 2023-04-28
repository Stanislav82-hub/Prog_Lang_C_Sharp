//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива. Н

void NewRamdomArray()
{
    int index = 12;
    int[] array = new int[index];

    FillInArray(array);
    PrintArray(array);
    Console.WriteLine($"Sum of positive numbers is {PositiveDigitsSum(array)}");
    Console.WriteLine($"Sum of positive numbers is {NegativeDigitsSum(array)}");
}

void FillInArray(int[] array)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9, 10);
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

int PositiveDigitsSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];
    }
    return sum;
}

int NegativeDigitsSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }
    return sum;
}

NewRamdomArray();
