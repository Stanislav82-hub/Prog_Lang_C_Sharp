// Задача 26. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.


int number = FillInNumber();

Console.WriteLine(DigitsQty(number));

int DigitsQty(int number)
{
    string text = number.ToString();
    int result = text.Length;
    return result;
}

int FillInNumber()
{
     Console.Write("Hello, give me a number \t");
     return int.Parse(Console.ReadLine());
}