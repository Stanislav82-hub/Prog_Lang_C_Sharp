//Задача 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все
// целые числа в промежутке от -N до N.

Console.WriteLine("Please fill in a number:");   
int a = int.Parse(Console.ReadLine());
for (int b = -a; b <= a ; b++)
{
    Console.Write(b+" ");
    // Console.Write($"{b} ")
} 





