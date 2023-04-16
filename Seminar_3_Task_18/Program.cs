// Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

void RangeOfQuater(int quater)
{
  if(quater == 1)
   {
     Console.WriteLine("Range of First quater is: for x - from 0 till infinity; for y - from 0 till infinity"); 
   } 
  else if(quater == 2)
    {
      Console.WriteLine("Range of Second quater is: for x - from 0 till minus infinity; for y - from 0 till infinity");
    } 
  else if(quater == 3)
    {
      Console.WriteLine("Range of Third quater is: for x - from 0 till minus infinity; for y - from 0 till minus infinity");
    } 
  else if(quater == 4)
    {
      Console.WriteLine("Range of Fourth quater is: for x - from 0 till infinity; for y - from 0 till minus infinity");
    } 
}

Console.WriteLine("Please fill in quater number");
int quater = int.Parse(Console.ReadLine());

RangeOfQuater(quater);