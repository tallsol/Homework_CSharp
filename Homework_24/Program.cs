// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] mtr1 = new int[,]{{2, 4}, {3, 2}};
int[,] mtr2 = new int[,]{{3, 4}, {3, 3}};


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

void MultiplyMatrix (int[,] mtr1, int[,] mtr2)
{
    int[,] resultMatrix = new int [mtr1.GetLength(1), mtr1.GetLength(0)];
    
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int multiply = 0;
            for (int k = 0; k < mtr1.GetLength(1); k++)
            {
                multiply += mtr1[i,k] * mtr2[k,j];
            }
        resultMatrix[i,j] = multiply;
        }
    }
    PrintArray(resultMatrix);
}

PrintArray(mtr1);
Console.WriteLine();
PrintArray(mtr2);
Console.WriteLine();
MultiplyMatrix(mtr1, mtr2);