// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36


Console.Write("Hello, give me a number \t");
int number = int.Parse(Console.ReadLine());

Console.Write(SumOfDigits(number));


/* int FillInNumber()
{
    Console.Write("Hello, give me a number \t");
    int number = int.Parse(Console.ReadLine());
    return number;
} */

int SumOfDigits(int number)
{
    int result = 0;
    for (int i = 1; i <= number; i++)
    {
        result += i;
    }
    return result;
}