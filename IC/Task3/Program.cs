// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

System.Console.WriteLine("Задача 3: Задайте произвольный массив. Выведете его элементы,");
System.Console.WriteLine("начиная с конца. Использовать рекурсию, не использовать циклы.");
int [] array = CreateArray(10,10,0);
System.Console.WriteLine($"Произвольный массив => [{PrintArray(array)}]");
System.Console.WriteLine($"Перевернутый массив => [{PrintArray(ArraySwap(array,array.Length-1))}]");

