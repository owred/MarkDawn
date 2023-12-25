// Напишите программу, которая принимает на вход  
// Трехзначое число и удаляет вторую цифру этого числа

Console.WriteLine("Введите значение: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine((a / 100) * 10 + a % 10);