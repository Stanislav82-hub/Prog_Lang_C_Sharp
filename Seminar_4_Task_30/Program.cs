// Задача 30. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
int[] RandomArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < number; i++)
        array[i] = (new Random().Next(0, 2));
    return array;
}
Console.Write("Fill in number \t");
int number = int.Parse(Console.ReadLine());
Console.Write(String.Join(", ", RandomArray(number)));
