/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int m = 20;
int n = 3;
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
        Console.Write($"{i + 1}: ");
        for (int j = 0; j < array02.GetLength(1); j++)
        {
            Console.Write($"{array02[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] SumArray(int[,] array04)
{
    int[] sumArray = new int[array04.GetLength(0)];
    int sum;
    for (int i = 0; i < array04.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array04.GetLength(1); j++)
        {
            sum += array04[i, j];
        }
        sumArray[i] = sum;
        Console.Write($"{i + 1}: [{sumArray[i]}]; ");
    }
    Console.WriteLine();
    return sumArray;
}

void PrintMinArray(int[] array05)
{
    int min = array05[0];
    int minArray = 0;
    int text;
    int count = 0;
    string equals = String.Empty;
    for (int i = 0; i < array05.Length; i++)
    {
        if (array05[i] < min)
        {
            min = array05[i];
            minArray = i;
        }
    }
    for (int j = 0; j < array05.Length; j++)
    {
        if (array05[j] == min)
        {
            if (count > 0)
            {
                text = j + 1;
                equals = equals + ", " + text;
            }
            count++;
        }
    }
    Console.WriteLine($"Строка(-и) с наименьшей суммой элементов - {minArray + 1}{equals} строка(-и)");
}

PrintArray(FillArray(newArray));
Console.WriteLine();
PrintMinArray(SumArray(newArray));

