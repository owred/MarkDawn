// Задайте массив символов (тип char []). Создайте строку из символов этого массива.

string concat(char[] mass)
{
    string buf = "";
    for(int i = 0; i < mass.Length; i++)
    {
        buf = buf + mass[i];
    }
    return buf;
}
char[] charArr = { 'H','e','l','l','o' };
string res = concat(charArr);
Console.WriteLine(res);