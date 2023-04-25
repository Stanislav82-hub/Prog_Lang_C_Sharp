// Задание 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе 
// показывает последнюю цифру этого числа.

//Console.WriteLine("Please type in a number: ");
//int a = int.Parse(Console.ReadLine());
//Console.Write("An answer is: ");
//Console.WriteLine(a%10); 
// На верху то, что сами на семинаре придумали, а с низу как должно быть):

Console.WriteLine("Please type in a number: ");
int a = int.Parse(Console.ReadLine());
if (a>=100 && a < 1000){   // && - означает "и" в условии, т.е. а больше или равно 100 "И" а меньше 1000
    Console.WriteLine(a % 10);
}
else{
    Console.Write("Wrong number");
}
