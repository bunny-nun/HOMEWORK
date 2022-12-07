/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int m = 5;
int n = 7;
int[,] newArray = new int[m, n];

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

int[,] SortArray(int[,] array03)
{
    int max;
    int maxpos;
    int buffer;
    for (int i = 0; i < array03.GetLength(0); i++)
    {
        for (int j = 0; j < array03.GetLength(1); j++)
        {
            for (int k = j + 1; k < array03.GetLength(1); k++)
            {
                max = array03[i, j];
                maxpos = j;
                if (array03[i, k] > max)
                {
                    max = array03[i, k];
                    maxpos = k;
                }
                buffer = array03[i, j];
                array03[i, j] = array03[i, maxpos];
                array03[i, maxpos] = buffer;
            }
        }
    }
    return array03;
}

PrintArray(FillArray(newArray));
Console.WriteLine();
PrintArray(SortArray(newArray));
