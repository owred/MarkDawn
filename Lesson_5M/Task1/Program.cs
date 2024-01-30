// Создайте двумерный массив.Найдите элементы, у которых оба индекса четные, замените эти элименты на их квадраты

int[,] CreateMatrix(int rowCount, int columsCount) // функция создания матрицы с элементами от 1 до 999
{
    int[,] matrix = new int[rowCount, columsCount];
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

void ShowMatrix(int[,] matrix) //Функция вывода матрицы на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(3, 4); //Задание размера матрицы и инициализация интересного числа
ShowMatrix(matrix);

void evenIndex(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
        Console.WriteLine();
    }
}

evenIndex(matrix);
ShowMatrix(matrix);