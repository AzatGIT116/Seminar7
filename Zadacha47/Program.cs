/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. */


double[,] GetMatrix(int m, int n, int min, int max)
{
    double[,] matrix = new double[m, n];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{Math.Round(mtrx[i, j], 1),4} | ");
        }
        Console.WriteLine();
    }
}

double[,] result = GetMatrix(3, 4, 1, 20);
PrintMatrix(result);