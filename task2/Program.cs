﻿Console.Clear();
// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman (int m, int n)
{
    if (m == 0)
    {
       return  n + 1;
    }

    if (m>0 && n==0)
    {
        return Akkerman(m-1,1);
    }
        return Akkerman(m-1, Akkerman(m,n-1));
    
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(m,n));
