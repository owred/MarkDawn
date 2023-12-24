// Напишите программу, которая на вход принимает два целых числа и проверяет, является ли первое число квадратом второго.
// а = 25, b = 5 => yes
// a = 2, b = 10  => no
// a = 9, b = -3 => yes
// a = -3, b = 9 => no

int a1 = 2;
int b1 = 10;

if (b1 * b1 == a1)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");

int a2 = 25;
int b2 = 5;

if (b2 * b2 == a2)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");

int a3 = 9;
int b3 = -3;

if (b3 * b3 == a3)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");

int a4 = -3;
int b4 = 9;

if (b4 * b4 == a4)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");

// При вводе данных с консоли
//Console.WriteLine("Enter a number:");
//strung str1 = Console.ReadLine()!;
// Получается строка, чтобы преоброзовать 2 способ
//int num1 = int.Parse(str1);

//Боле короткий
//  Console.Write("Enter a number: ");
//  int num1 = int.Parse(Console.ReadLine()!);

