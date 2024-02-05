// Замена заглавных букв на строчные в строке

public class Task2_hm
{
    public static void Main(string[] args)
    {
        // Входная строка со смешанными буквами обоих регистров
        string input = "aBcD1ef!-";
        // Преобразование всех заглавных букв в строчные
        string result = input.ToLower();
        // Вывод результата
        Console.WriteLine(result);
    }
}

string LowUp(string word)
{
    return word.ToLower();
}

Console.Write("Enter some text: ");
string text = Console.ReadLine()!;

string res = LowUp(text);
Console.WriteLine(res);
