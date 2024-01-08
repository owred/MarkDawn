int n = 5;
int[] array = { 2, 4, 7, 3, 9 };
int i = 0;
int max = array[0];

while (i < n)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i += 1;
}
Console.WriteLine(max);

// Через For

max = 0;
for(int j = 0; j < n; j++)   //j++  = j=j+1
{
    if (array[j] > max)
    {
        max = array[j];
    }
}
Console.WriteLine(max);


// Через Foreach

max = 0;
foreach(int e in array)
{
    if(e > max)
    {
        max = e;
    }
}
Console.WriteLine(max);