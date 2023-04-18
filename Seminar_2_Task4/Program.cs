// Напишите программу, которая будет принимать на вход число и выводить, является ли  число кратным 7 и 23

Console.WriteLine("Введите первое число");
int num1 = Convert. ToInt32 (Console. ReadLine ());

if (num1 % 7 == 0 && num1 % 23 == 0)
{
    Console.WriteLine($"Число {num1} делиться на 7 и 23 без остатка");
}
else
{
        Console.WriteLine ($"Число {num1} не делиться на 7 и 23");
}
