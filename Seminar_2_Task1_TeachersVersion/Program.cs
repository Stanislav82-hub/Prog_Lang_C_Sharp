// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

System.Console.WriteLine("min ");
int min = ReadInt();

System.Console.WriteLine("max ");
int max = ReadInt();

int number = GetRandomNumber(min, max);

System.Console.WriteLine(number);

if(GetFirstDigit(number) > GetSecondDigit(number))
{
    Console.WriteLine("First is bigger"); 
}
else 
{
    Console.WriteLine("Second is bigger");
}


int GetRandomNumber(int min, int max)
{
    return new Random().Next(min, max + 1);
}

int GetFirstDigit(int number)
{
    return number / 10;
}

int GetSecondDigit(int number)
{
    return number % 10;
}

int ReadInt()   //1:03:10
{
    return int.Parse(Console.ReadLine());
}