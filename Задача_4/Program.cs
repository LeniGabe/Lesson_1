//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

try
{
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());


int max = 0;
int min = 0;

if(a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
if(c > max)
{
    max = c;
    min = max;
}

Console.WriteLine("Наибольшее число " + max);
}
catch
{
    Console.WriteLine("Вы ввели некоректные данные");
}