﻿// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя)

Console.WriteLine("Fill in number to findout it's square:");
double number = double.Parse(Console.ReadLine());
double result = Math.Pow(number, 2);
Console.Write("Square of ");
Console.Write(number);
Console.Write(" is ");
Console.WriteLine(result);

