Console.Clear();
// Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void RoadMToN(int N=1, int M=1)
{
    if(N == M-1)
    {
        return;

    }
    RoadMToN(N - 1, M);
    Console.Write($"{N} ");
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
if (N>M)
RoadMToN(N,M);
else
RoadMToN(M,N);
