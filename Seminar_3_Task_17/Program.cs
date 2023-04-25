// Задача 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта точка.

string CheckXY(double x, double y)
{
    if(x > 0 && y > 0)
    {
      return "First quater";
    } 
    else if (x < 0 && y > 0)
    {
      return "Second quater";
    } 
    else if (x < 0 && y < 0)
    {
      return "Third quater";
    } 
    else if (x > 0 && y < 0)
    {
      return "Fourth quater";
    } 
    else
    {
       return "Out of graph";
    }
}

Console.WriteLine("Please fill in meaning for x");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Please fill in meaning for y");
int y = int.Parse(Console.ReadLine());

Console.WriteLine(CheckXY(x, y));