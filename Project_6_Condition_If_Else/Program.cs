Console.WriteLine("Введите имя пользователя ");
string? username = Console.ReadLine();
if(username.ToLower() == "наташа")
{
   Console.WriteLine("Привет, Натусик-веселусик!!!)))");
}
else
{
    Console.WriteLine("Здарова, ");
    Console.WriteLine(username);
}