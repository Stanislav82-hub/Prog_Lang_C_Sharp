//Напишите программу, которая на вход принимает два числа и проверяет, является 
//ли первое число квадратом второго.

Console.WriteLine("Please fill in a number");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Please fill in second number");
int number2 = int.Parse(Console.ReadLine());
int result = number1 / number2;
Console.WriteLine(result);
if(result == number2)
{
    Console.Write(number1);
    Console.Write(" is a square of ");
    Console.Write(number2);
}
else
{
    Console.Write(number1);
    Console.Write(" is not a square of ");
    Console.Write(number2);
}
