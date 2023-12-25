// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. если второе число не кратно первому , то программа выводит остаток от деления

Console.WriteLine("Введите первое значение: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе значение: ");
int b = int.Parse(Console.ReadLine()!);

if(a % b == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no, " + a % b);
}