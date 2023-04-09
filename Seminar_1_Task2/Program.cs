string Day1 = "Monday";
string Day2 = "Tuesday";
string Day3 = "Wednesday";
string Day4 = "Thursday";
string Day5 = "Friday";
string Day6 = "Saturday";
string Day7 = "Sunday";
Console.WriteLine("Please enter weekday number (1-7)");
int weekday = int.Parse(Console.ReadLine());
if (weekday == 1){
    Console.WriteLine(Day1);
}
else if(weekday == 2)
{
    Console.WriteLine(Day2);
}
else if(weekday == 3)
{
    Console.WriteLine(Day3);
}
else if(weekday == 4)
{
    Console.WriteLine(Day4);
}
else if(weekday == 5)
{
    Console.WriteLine(Day5);
}
else if(weekday == 6)
{
    Console.WriteLine(Day6);
}
else if(weekday == 7)
{
    Console.WriteLine(Day7);
}
else{
    Console.WriteLine("Wrong number, chose from 1 to 7");
}
