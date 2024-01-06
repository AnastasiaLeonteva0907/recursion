Console.Clear();
// Задача 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// void RoadMToN(int N=1, int M=1)
// {
//     if(N == M-1)
//     {
//         return;

//     }
//     RoadMToN(N - 1, M);
//     Console.Write($"{N} ");
// }

// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// if (N>M)
// RoadMToN(N,M);
// else
// RoadMToN(M,N);

// Задача 1.* Задайте значения M и N. Напишите программу, которая найдет сумму натуральных чисел в промежутке от M до N.


int SumMN(int M, int N)
{
    
    if(M == N)
    {
        return 0;
    }
    int sum = M;
    M++;
    sum = M + SumMN(M, N);
    return sum;
}

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write($"{SumMN(M-1,N)}");
