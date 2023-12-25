// Напишите программу, которая выводит 3 с конца цифру заданного числа или сообщает что третьей цифры нет

Console.WriteLine("Введите значение: ");
int a = int.Parse(Console.ReadLine()!);
if (a < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine(a / 100 % 10);
}