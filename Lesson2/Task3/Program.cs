int n = 10;
int[] array = { 2, 5, 4, 7, 8, 35, 1, 3, 8, 5 };
int i = 0;

while(i < n)
//while(i < array.Length)     // тогда нужно закоментить первую стоку так как переменная n не используется
{
    if(array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i += 1; // i = i + 1;
}