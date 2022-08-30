﻿// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// Значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1:");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите b2:");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k1:");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите k2:");
double k2 = Convert.ToInt32(Console.ReadLine());

// x = (y - b2) / k2 - выводим х из второго уравнения и вставляем его в первое уравнение

double y = ((k1 * b2) - (k2 * b1)) / (k1 - k2); // получившаяся формула - результат сокращений
double x = (((k1 * b2) - (k2 * b1)) / (k1 - k2) - b2) / k2; // вставляем y в уравнение с x


Console.WriteLine($"Точка пересечения М: ({x};{y})");