// Задача 28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.Write("Hello, give me a number \t");
int number = int.Parse(Console.ReadLine());

Console.Write(MultOfDigits(number));


int MultOfDigits(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    return result;
}
