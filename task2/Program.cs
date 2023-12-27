// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите Х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y");
int y = Convert.ToInt32(Console.ReadLine());

if(x == 0 || y == 0)
{
    Console.WriteLine("точка не принадлежит ни одной из четвертей");
}
else if (x > 0)
{
    if(y>0)
    {
        Console.WriteLine("1");
    }
    else
    {
        Console.WriteLine("4");
    }
}
else
{
    if(y>0)
    {
        Console.WriteLine("2");
    }
    else
    {
        Console.WriteLine("3");
    }
}