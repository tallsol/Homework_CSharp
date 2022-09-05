// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов

int[,] matrix = new int[,]{{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};

int minSum = 0;
int count = 1;

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}" + "\t");
        }
        Console.WriteLine();
    }
}

for (int i =0; i < matrix.GetLength(1); i++)
{
    int rowSum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        rowSum += matrix [i, j];
    }

    if (i == 0)
    {
        minSum = rowSum;
    }

    if (rowSum < minSum)
    {
        count = i + 1;
        minSum = rowSum;
    }
}

PrintArray(matrix);
Console.WriteLine();
Console.WriteLine($"Строчка с наименьшей суммой элементов - {count}");