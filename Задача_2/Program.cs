Console.WriteLine("Введите число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b");
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
