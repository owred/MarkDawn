// Считать строку с консоли, состоящую из латинских букв в нижнем регистре. Выяснить, сколько среди введённых букв гласных.

using System;

class Program
{
    static void Main()
    {


        // Просим пользователя ввести строку
        Console.WriteLine("Введите строку из латинских букв в нижнем регистре:");
        string input = Console.ReadLine()!;
        int vowelCount = CountVowels(input);

        // Выводим результат
        Console.WriteLine($"Количество гласных букв в строке: {vowelCount}");

    }

    // Метод для подсчета количества гласных
    private static int CountVowels(string input)
    {
    
        //Создаем массив с гласными
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        int count = 0;

        //Проходим по каждому символу
        for (int i = 0; i < input.Length; i++)
        {
            //Если символ гласный ,увеличиваем счетчик
            if (Array.IndexOf(vowels, input[i] != -1))
            {
                count++;
            }
        }
        return count;
    }

    
}