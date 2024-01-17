﻿// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новый массив

using System;
using System.Collections.Generic;

class PrimeNumbersCounter
{
    // Метод для генерации случайного массива заданной длины
    // length - длина массива
    public static int[] GenerateRandomArray(int length)
    {
        Random random = new Random();
        int[] numbers = new int[length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100);
        }
        return numbers;
    }

    // Метод для подсчета количества простых чисел в массиве и вывода списка простых чисел
    // numbers - массив, в котором ведется подсчет
    public static void CountPrimeNumbers(int[] numbers, out int count, out List<int> primes)
    {
        count = 0;
        primes = new List<int>();
        for (int i = 0; i < numbers.Length; i++)
        {
            if (IsPrime(numbers[i]))
            {
                count++;
                primes.Add(numbers[i]);
            }
        }
    }

    // Метод для определения является ли число простым
    // number - число, которое проверяется на простоту
    public static bool IsPrime(int number)
    {
        if (number < 2) return false;

        // Проверяем только делители от 2 до корня из числа
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    // Метод для вывода результата на экран
    // count - количество простых чисел в массиве
    // primes - список простых чисел в массиве
    public static void PrintResult(int count, List<int> primes)
    {
        Console.WriteLine("Количество простых чисел в массиве: " + count);
        Console.WriteLine("Список простых чисел в массиве: " + string.Join(", ", primes));
    }
}

class Answer
{
    public static void Main(string[] args)
    {
        int[] array;

        if (args.Length >= 1)
        {
            // Преобразуем аргумент командной строки в целое число
            int length = int.Parse(args[0]);
            array = PrimeNumbersCounter.GenerateRandomArray(length);
        }
        else
        {
            array = PrimeNumbersCounter.GenerateRandomArray(10);
        }

        int count;
        List<int> primes;
        PrimeNumbersCounter.CountPrimeNumbers(array, out count, out primes);
        PrimeNumbersCounter.PrintResult(count, primes);
    }
}