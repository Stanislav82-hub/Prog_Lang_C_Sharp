// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие
//отрицательные и наоборот.
void NewRamdomArray()
{
    int index = 12;
    int[] array = new int[index];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }
    PrintArray(array);
    ConvertToOposite(array);
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");

    }
    Console.WriteLine("");
}

void ConvertToOposite(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
     
    }
    PrintArray(array);
}

NewRamdomArray();
