// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
System.Console.WriteLine(number);

int del = number / 100;
Console. WriteLine (del);
int del2 = number % 10;
Console. WriteLine(del2) ;
Console.WriteLine($" {del}{del2}");

