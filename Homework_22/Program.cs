// Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] matrix = new int[,]{{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

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

void ReverseMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int r = 0; r < matrix.GetLength(1) - 1; r++)
            {
                if (matrix[i, r] < matrix[i, r + 1])
                {
                    int temp = matrix[i, r + 1];      
                    matrix[i, r + 1] = matrix[i, r];  
                    matrix[i, r] = temp;              
                }
            }
        }
    }
}

PrintArray(matrix);
ReverseMatrix(matrix);
Console.WriteLine();
PrintArray(matrix);