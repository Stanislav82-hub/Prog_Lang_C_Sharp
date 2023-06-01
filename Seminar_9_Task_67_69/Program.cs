// 67. Напишите программу, которая будет принимать число и выводить сумму его цифр.
int SumNum(int number)
{
    if (number > 0)
    {
        return number % 10 + SumNum(number / 10);
    }
    return number % 10;
}
//System.Console.WriteLine(SumNum(453));

//69. Напишите программу, которая будет принимать два числа и (А и Б) и возводить число А в целую степень Б
// с помощью рекурсии

int PowNumber(int a, int b)
{
    if (b > 0)
    {
        return a * PowNumber(a, b-1);
    }
    return 1;
}
System.Console.WriteLine(PowNumber(3, 2));