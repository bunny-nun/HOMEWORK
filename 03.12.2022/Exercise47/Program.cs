// Задача 47. Задайте двумерный массив размером mxn, заполненный случайными вещественными числами

int m = 5;
int n = 5;
double[,] newArray = new double[m, n];

double[,] FillArray(double[,] array01)
{
    for (int i = 0; i < array01.GetLength(0); i++)
    {
        for (int j = 0; j < array01.GetLength(1); j++)
        {
            array01[i, j] = Math.Round((new Random().NextDouble() * 100), 2);
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