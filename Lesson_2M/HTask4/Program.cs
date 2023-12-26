// Напиши программу, которая на вход принимает натуральное число N,
// а на выходе показывает его цифры через запятую

Console.WriteLine("Введите натуральное число N: ");
int N = int.Parse(Console.ReadLine()!);


if (N < 10)
{
    Console.WriteLine(N);
}
else
{      
    while (N > 0)
    {
        int numb = N % 10;
        N = N / 10;
        if (N > 0)
        {
            Console.Write(numb + ",");
        }
    
        else
        {
        Console.WriteLine(numb);
        }
    }
    
}