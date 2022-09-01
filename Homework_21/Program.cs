// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] matrix = new int[,]{{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

void PrintArray(int[,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
		{
		for (int j = 0; j < matr.GetLength(1); j++)
			{
				Console.Write($"{matrix[i, j]}" + "\t");
			}
		Console.WriteLine();
		}
}


double avg1 = 0;
double avg2 = 0;
double avg3 = 0;
double avg4 = 0;

for (int i = 0; i < matrix.GetLength(0); i++) // GetLength(0) - строчки
{
    for (int j = 0; j < matrix.GetLength(1); j++) // GetLength(1) - столбцы
    {
        if (j == 0) {avg1 += matrix[i,j];}
        if (j == 1) {avg2 += matrix[i,j];}
        if (j == 2) {avg3 += matrix[i,j];}
        if (j == 3) {avg4 += matrix[i,j];}
    }
}


PrintArray(matrix);
Console.WriteLine($"Среднее арифметическое каждого из столбцов: {avg1 / matrix.GetLength(0)}, {avg2 / matrix.GetLength(0)}, {avg3 / matrix.GetLength(0)}, {avg4 / matrix.GetLength(0)}");