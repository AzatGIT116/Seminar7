/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. */

int[,] array = new int[3, 4];
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write(" | ");
            Console.Write($"{array[i, j],4} | ");
        }
        Console.WriteLine("");
    }
}
void CheckArray(int[,] array)
{
    double arifmet = 0;
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        arifmet = sum / array.GetLength(0);
        if (j == 0) Console.WriteLine("Среднее арифметическое каждого столбца:");
        if (j == 0) Console.Write(" | ");
        Console.Write($"{Math.Round(arifmet, 1),4} | ");
    }
}
FillArray(array);
PrintArray(array);
Console.WriteLine();
CheckArray(array);
