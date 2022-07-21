/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. */

Console.Write("Введите номер строки элемента: ");
int posi = (int.Parse(Console.ReadLine()!)) - 1;
Console.Write("Введите номер столбца элемента: ");
int posj = (int.Parse(Console.ReadLine()!)) - 1;
Console.WriteLine();

int[,] GetMatrix(int m, int n, int min, int max)
{
    int[,] mtrx = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            mtrx[i, j] = rnd.Next(min, max + 1);
        }
    }
    return mtrx;
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{mtrx[i, j],3} | ");
        }
        Console.WriteLine();
    }
}

int ResultPosiPosj(int[,] mtrx, int posi, int posj)
{
    int number = 0;
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            if (i == posi && j == posj)
            {
                number = mtrx[i, j];
            }
        }
    }
    return number;
}

int[,] result = GetMatrix(6, 6, 1, 100);
PrintMatrix(result);
if (ResultPosiPosj(result, posi, posj) > 0)
{
    Console.WriteLine("Значение элемента на позиции равна: " + ResultPosiPosj(result, posi, posj));
}
else
{
    Console.WriteLine("Такого элемента нет");
}