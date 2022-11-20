//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

try
{
Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0)
{
        Console.WriteLine("Число четное");
}
else
{
      Console.WriteLine("Число нечетное");
}
}
catch
{
    Console.WriteLine("Вы ввели некоректные данные");
}