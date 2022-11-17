Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c");
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