// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1); 
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] ResultMatrix(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] matrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                matrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return matrix;
}


int[,] firstArray2D = CreateMatrixRndInt(2, 2, 2, 4);
int[,] secondArray2D = CreateMatrixRndInt(2, 2, 2, 4);
PrintMatrix(firstArray2D);
Console.WriteLine("  ");
PrintMatrix(secondArray2D);
Console.WriteLine("  ");
int[,] FinalArray2D = ResultMatrix(firstArray2D, secondArray2D);
PrintMatrix(FinalArray2D);