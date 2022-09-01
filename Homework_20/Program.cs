// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Пример:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите номер строки: ");
int x = Convert.ToInt32(Console.ReadLine()) - 1;

Console.WriteLine("Введите номер столбца: ");
int y = Convert.ToInt32(Console.ReadLine()) - 1;

int[,] matrix = new int [4, 4];


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

void FillArray(int[,] matr)
{
	for (int i = 0; i < matr.GetLength(0); i++)
	{
	for (int j = 0; j < matr.GetLength(1); j++)
		{
			matr[i, j] = new Random().Next(31);
		}
	}
}


FillArray(matrix);
PrintArray(matrix);

for (int i = -1; i < matrix.GetLength(0); i++)
{
    if (x == i)
    {
        for (int j = -1; j < matrix.GetLength(1); j++)
        {
            if (j == y)
            { Console.WriteLine($"Значение элемента = {matrix[x, y]}"); }
        }
    }
}

if (x > matrix.GetLength(0) || y > matrix.GetLength(1))
{ Console.WriteLine("Данного элемента не существует");}


