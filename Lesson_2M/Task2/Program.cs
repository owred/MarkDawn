// Напишите программу, которая принимает на вход трехзначное число и возводит вторуюцифру этого числа в степень равнуютретей цифре

Console.WriteLine("Введите значение: ");
int a = int.Parse(Console.ReadLine()!);
int SecondNumb = a / 10 % 10;
int ThirdNumb = a % 10;
Console.WriteLine(Math.Pow(SecondNumb,ThirdNumb));