// Задайте одномерный массив, заполненый случайными числами. 
// определите количество чисел в этом массиве.
class Program
{

    static void Main()
    {
        //Создаем объект Random для генерации случайных чисел
        Random random = new Random();
        //Создаем массив из 10 случайных чисел 
        int[] numbers = new int[10];
        for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 100); // генерация случайного числа в заданном диапозоне от 1 до 100
            Console.Write($"{numbers[i]} ");            
        }
        //определение количества простых чисел в массиве
        int count = 0;
        foreach (var number in numbers)
        {
            if (IsPrime(number))
            {
                count++;
            }
        }
        //вывод результата
        Console.WriteLine("\nКоличество простых чисел в массиве: "+ count);
    }
    //метод для определения является ли число простым 
    static bool IsPrime(int number)
    {
        if (number < 2) return false;

        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}