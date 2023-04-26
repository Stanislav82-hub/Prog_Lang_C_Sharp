// See https://aka.ms/new-console-template for more information

int digit = GetDigitFromNumber(FillInNumber(), FillInNumber());

if (digit != -1)
{
    Console.WriteLine(digit);
}
else
{
    Console.WriteLine("Arror");
}

int GetDigitFromNumber(int number, int digitPosition)
{
    number = Math.Abs(number);
    if (number < Math.Pow(10, digitPosition - 1)) // 100
    {
        return -1; // -1 - эТо ошибка.
    }
    
    while (number > Math.Pow(10, digitPosition))
    {
        number /= 10;
    }
    return number % 10;
}

int FillInNumber()
{
     Console.Write("Hello, give me a number \t");
     return int.Parse(Console.ReadLine());
}
