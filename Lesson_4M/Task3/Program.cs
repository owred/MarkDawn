// Заполните массив N (вводится с консоли, не более 8) случайных чисел от 0 до 9.
// Сформируйте ЦЕЛОЕ ЧИСЛО, которое будет состоять из цифр массива. Старший разряд числа находится на 0-м индексе, младший - на последнем.

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


int[] MassNums(int size, int from, int to)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(from, to + 1);
    return arr;
}

int num = int.Parse(Console.ReadLine()!);
int start = int.Parse(Console.ReadLine()!);
int stop = int.Parse(Console.ReadLine()!);

int[] mass = MassNums(num, start, stop);
Print(mass);

long Int1(int[] arr)
{
    string num = "";
    foreach (int item in arr)
    {
        num += item;
    }
    return long.Parse(num);
}

long result = Int1(mass);
Console.WriteLine("\n");
Console.WriteLine(result);