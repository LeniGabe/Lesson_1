//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

try
{
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

int max = 0;
int min = 0;

if(a > b)
{
    max = a;
    min = b;
    Console.WriteLine("Наибольшее число равно " + a);
}
else
{
    max = b;
    min = a;
    Console.WriteLine("Наибольшее число равно " + b);
}
}
catch
{
    Console.WriteLine("Вы ввели некоректные данные");
}