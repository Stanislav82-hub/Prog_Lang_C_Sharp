﻿// Задача 22. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
Console.Write("Hi, give me a number \t");
int a = int.Parse(Console.ReadLine());
for (int i = 1; i <= a; i++)
  {
    System.Console.Write(" "+Math.Pow(i,2));
  }