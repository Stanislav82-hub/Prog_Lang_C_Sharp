// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

void IfNumberInArray()
{
    int index = 12;
    int[] array = new int[index];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(-9, 10);
    }
    PrintArray(array);
    CheckNumber(array);

}


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");

    }
    Console.WriteLine("");
}

void CheckNumber(int[] array)
{
    Console.Write("Hello, give me a number to check \t");
    int number = int.Parse(Console.ReadLine());

    bool flag = false;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            flag = true;
            index = i;
        }
    }
    if (flag) Console.WriteLine($"Our array contains this number, this is {index+1} symbol");
    else Console.WriteLine("Our array does not contain this number");
}

IfNumberInArray();





