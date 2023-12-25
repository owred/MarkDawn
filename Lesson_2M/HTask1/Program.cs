Console.WriteLine("Введите первое значение: ");
int a = int.Parse(Console.ReadLine()!);

if(a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no" );
}