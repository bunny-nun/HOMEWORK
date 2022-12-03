/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет*/


Console.WriteLine("Введите индекс строки: ");
int inputM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца: ");
int inputN = Convert.ToInt32(Console.ReadLine());

int m = 5;
int n = 5;
int[,] newArray = new int[m, n];

int[,] FillArray(int[,] array01)
{
    for (int i = 0; i < array01.GetLength(0); i++)
    {
        for (int j = 0; j < array01.GetLength(1); j++)
        {
            array01[i, j] = new Random().Next(0, 10);
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

PrintArray(FillArray(newArray));

void FindElement(int[,] array03, int posM, int posN)
{
    if (posM < array03.GetLength(0) && posN < array03.GetLength(1))
    {
        Console.WriteLine($"Элемент с позицией: строка {posM}, столбец {posN} равен {array03[posM, posN]}");
    }
    else
    {
        Console.WriteLine($"Элемента с позицией: строка {posM}, столбец {posN} в массиве нет");
    }
}
FindElement(newArray, inputM, inputN);