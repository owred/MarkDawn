﻿// Напишите программу которая будет принимать на вход чило и возвращать сумму его цифр.

int rec(int a)
{
    if (a == 0)
    {
        return 0;
    }
    return rec(a / 10) + a % 10;
}
int res = rec(123);
Console.Write(res);