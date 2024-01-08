int n = 10;
int[] arr = new int[n];
int i = 0;

while (i < n)
//while (i < arr.Length)
{
    arr[i] = i + 1;
    //Console.write(arr[i]);
    //Console.write(' ');
    Console.Write($"{arr[i]} "); //Тоже самое действие что и в 8,9 стороке
    i = i + 1;
}