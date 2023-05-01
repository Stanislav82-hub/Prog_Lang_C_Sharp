

void FillRandomNumber(int[] array, int minValue = -9, int maxValue = 10)
{
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
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

void ReverseArray(int[] array)
{
    int halfArray = array.Length / 2;
    int lastIndex = array.Length - 1;
    for (int i = 0; i < halfArray; i++)
    {
        int temp = array[i];
        array[i] = array[lastIndex - i];
        array[lastIndex - i] = temp;
    }
}

string Input(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}

bool SideCheck(int sideA, int sideB, int sideC)
{
    return sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB;
}

// Задача 39:Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на первом месте, а первый -на последнем и т.д.)

void Seminar_6_Task_39()
{
    int index = 4;
    int[] array = new int[index];

    FillRandomNumber(array);
    PrintArray(array);
    ReverseArray(array);
    PrintArray(array);

}

//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.

void Seminar_6_Task_40()
{
    int sideA = int.Parse(Input("Fill in side A:"));
    int sideB = int.Parse(Input("Fill in side B:"));
    int sideC = int.Parse(Input("Fill in side C:"));

    if (SideCheck(sideA, sideB, sideC))
    {
        Console.WriteLine("Triangle exists");
    }
    else
    {
        Console.WriteLine("Triangle does not exist");
    }

}

//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

void Seminar_6_Task_42()
{

    int number = int.Parse(Input("Fill in number:"));
    int value = number;
    //string resultStrng = "";
    int shift = 1;
    int resultInt = 0;

    while (value > 0)
    {
        resultInt = value % 2 * shift;
        shift *= 10;
        //resultStrng = value % 2 + resultStrng;
        value /= 2;
    }
    //Console.WriteLine($"число в двоичном представлении {resultStrng}");
    Console.WriteLine($"число в двоичном представлении {resultInt}");
}

//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

void Seminar_6_Task_44()
{
    int a = 0;
    int b = 1;
    int number = int.Parse(Input("Колличестыо элементов последовательности:"));

    for (int i = 0; i < number; i++)
    {
        Console.Write($"{a} ");
        (a, b) = (b, a + b);
        // int temp = a;
        //a=b;
        // b= temp + b;
    }
}

// Задача 45:Напишите программу, которая будет создавать копию заданного массива с помощью
// поэлементного копирования.

void Seminar_6_Task_45()
{

    int index = 4;
    int[] array = new int[index];
    FillRandomNumber(array);
    Console.Write("Первый массив");
    PrintArray(array);

    int[] array_copy = new int[index];

    for (int i = 0; i < array.Length; i++)
    {
        array_copy[i] = array[i];
    }

    Console.Write("Копия массива массива");
    PrintArray(array_copy);
}

//Seminar_6_Task_39();
//Seminar_6_Task_40();
//Seminar_6_Task_42();
//Seminar_6_Task_44();
Seminar_6_Task_45();