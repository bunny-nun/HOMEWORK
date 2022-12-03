/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3*/

int m = 5;
int n = 5;
double[,] newArray = new double[m, n];

double[,] FillArray(double[,] array01)
{
    for (int i = 0; i < array01.GetLength(0); i++)
    {
        for (int j = 0; j < array01.GetLength(1); j++)
        {
            array01[i, j] = Math.Round((new Random().NextDouble() * 9), 0);
        }
    }
    return array01;
}

void PrintArray(double[,] array02)
{
    for (int i = 0; i < array02.GetLength(0); i++)
    {
        for (int j = 0; j < array02.GetLength(1); j++)
        {
            Console.Write($"{array02[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(FillArray(newArray));
Console.WriteLine();

double[] CountAverage(double[,] array03)
{
    double[] averageArray = new double[array03.GetLength(1)];
    double rowSum = 0;
    for (int i = 0; i < array03.GetLength(1); i++)
    {
        rowSum = 0;
        for (int j = 0; j < array03.GetLength(0); j++)
        {
            rowSum += array03[j, i];
        }
        averageArray[i] = Math.Round((rowSum / array03.GetLength(0)), 1);
    }
    return averageArray;
}

void PrintAverage(double[] array04)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < array04.Length; i++)
    {
        Console.Write($"{array04[i]} ");
    }
    Console.WriteLine();
}

PrintAverage(CountAverage(newArray));