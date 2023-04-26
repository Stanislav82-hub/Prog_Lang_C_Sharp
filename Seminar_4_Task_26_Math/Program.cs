//  Задача 26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Console.Write("Hello, give me a number \t");
int number = int.Parse(Console.ReadLine());

Console.WriteLine($"This number contains {DigitQty(number)} digits");

int DigitQty(int number)
{
    int count = 1;
    while (number > 9)
    {
        number /= 10;
        count++;
    }
    return count;
}




