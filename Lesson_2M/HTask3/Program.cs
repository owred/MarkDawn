// Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа

Console.WriteLine("Введите целое число из отрезка [10, 99]: ");
int number = int.Parse(Console.ReadLine()!);

if (number >= 10 && number <= 99)
{
    int firstNum = number /10;
    int secondNum = number % 10;

    int maxNum = firstNum > secondNum ? firstNum:secondNum;
    Console.WriteLine(maxNum);
}
else
{
    Console.WriteLine("Введено не корректное число");
}