// 63. Задайте значение N. Напишите программу которая выведет все натуральные числа в промежутке от 1 до N.
//Решить через рекурсию.
void PrintNumber(int number)
{
    if (number != 0)
    {
        PrintNumber(number - 1);
    }
    System.Console.Write(number);
}

//PrintNumber(5);

// 64. Задайте значения M и N. Напишите программу которая выведет все натуральные числа в промежутке от M до N.

void Print(int a)
{
    Console.Write(a);
    if (a > 0)
    {
        Print(a - 1);
    }

}

void PrintIncr(int a)
{

    if (a > 0)
    {
        PrintIncr(a - 1);
    }
    Console.Write(a);
}

void Seminar_9_Task_64(int FirstNumber, int SecondNumber)
{
    Console.Write($"{FirstNumber} ");
    if (FirstNumber != SecondNumber)
    {
        Seminar_9_Task_64(FirstNumber + 1, SecondNumber);
    }

}
//Print(5);
//PrintIncr(5);

Seminar_9_Task_64(1, 5);