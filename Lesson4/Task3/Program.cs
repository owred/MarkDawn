// назовем число ИНТЕРЕСНЫМ если его сумма цифр четная
// Создадим двумерный массив, состоящий из целых чисел. Выведем на экран ИНТЕРЕСНЫЕ элементы массива

int[,] CreateMatrix (int rowCount, int columnsCount)
{
    int[,] matrix = new int[rowCount, columnsCount];
    
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix[i,j] = rnd.Next(1, 1000);
        }
    }
    return matrix;

}

void ShowMatrix(int[,] matrix)
{
        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} "); // Интерполяция строк
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3,4);
ShowMatrix(matrix);
Console.WriteLine();

foreach (int e in matrix)
{
    if (Isinteresting(e) == true)
    {
        Console.WriteLine($"{e} ");
    }
    
}

bool Isinteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if (sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
    
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum += value % 10;
        value /=10;
    }
    return sum;
}

