// Напишите программу, которая принимает на вход координаты точки(x и y), причем x != 0 и y != 0
// и выдает номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите x: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите y: ");
int y = int.Parse(Console.ReadLine()!);

if (x > 0 && y > 0)
{
    Console.WriteLine("1 Четверть");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2 Четверть");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3 Четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4 Четверть");
}
else
{
    Console.WriteLine("Точка на оси координат");
}