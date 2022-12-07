/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

int l = 4;
int m = 5;
int n = 6;
int[,] matrix01 = new int[l, m];
int[,] matrix02 = new int[m, n];
int[,] resultMatrix = new int[l, n];

int[,] FillArray(int[,] array01)
{
    for (int i = 0; i < array01.GetLength(0); i++)
    {
        for (int j = 0; j < array01.GetLength(1); j++)
        {
            array01[i, j] = new Random().Next(1, 10);
        }
    }
    return array01;
}

void PrintArray(int[,] array02)
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

int[,] MatrixMultiplication(int[,] array03, int[,] array04, int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < array03.GetLength(1); k++)
            {
                newArray[i, j] += array03[i, k] * array04[k, j];
            }
        }
    }
    return newArray;
}

PrintArray(FillArray(matrix01));
Console.WriteLine();
PrintArray(FillArray(matrix02));
Console.WriteLine();
PrintArray(MatrixMultiplication(matrix01, matrix02, resultMatrix));

