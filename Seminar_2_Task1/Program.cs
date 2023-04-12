// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100); //создание случайного числа/в скобках первое число включительно, второе нет
int first = number / 10;
int second = number % 10;
System.Console.WriteLine(number);
if(first > second)
{
    System.Console.WriteLine("первое больше");
}
else{
    System.Console.WriteLine("второе больше");
}


