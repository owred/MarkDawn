﻿// Вычислить значение формулы (a * b)/(c + d), a,b,c,d, - некоторые целые числа. Решение оформить в виде функции


double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b; // числитель
    int denomenator = c + d; // знаменатель
    double result = numenator / denomenator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);
