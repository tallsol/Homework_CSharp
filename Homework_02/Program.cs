﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int result;

if (a > b)
	{
		result = a;
	}
else
	{
        result = b;
	}

if (result > c)
    {
        Console.WriteLine("Наибольшее число - " + result);
    }
else
    {
        Console.WriteLine("Наибольшее число - " + c);
    }