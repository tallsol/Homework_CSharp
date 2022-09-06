﻿// Напишите программу вычисления функции Аккермана с помощью 
// рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int AckermannFunction (int m, int n)
{
    if (m == 0) return n + 1;
	else if (n == 0) return AckermannFunction(m - 1, 1);
    return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.WriteLine($"Результат равен {AckermannFunction(M, N)}");
