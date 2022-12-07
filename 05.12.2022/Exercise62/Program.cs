/* Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int m = 4;

int[,] FillArray(int steps)
{
    int[,] newArray = new int[steps, steps];
    int max = steps * steps;
    int number = 1;
    int horizontal = 0;
    int vertical = 0;
    int circle = 0;
    while (number < max + 1)
    {
        while (vertical < steps)
        {
            newArray[horizontal, vertical] = number;
            number++;
            vertical++;
        }
        horizontal++;
        vertical--;
        while (horizontal < steps)
        {
            newArray[horizontal, vertical] = number;
            number++;
            horizontal++;
        }
        horizontal--;
        vertical--;
        while (vertical > circle)
        {
            newArray[horizontal, vertical] = number;
            number++;
            vertical--;
        }
        steps--;
        circle++;
        while (horizontal > circle)
        {
            newArray[horizontal, vertical] = number;
            number++;
            horizontal--;
        }
    }
    return newArray;
}

void PrintArray(int[,] array01)
{
    for (int i = 0; i < array01.GetLength(0); i++)
    {
        for (int j = 0; j < array01.GetLength(1); j++)
        {
            if (array01[i, j] < 10)
                Console.Write($"00{array01[i, j]} ");
            else if (array01[i, j] < 100)
                Console.Write($"0{array01[i, j]} ");
            else Console.Write($"{array01[i, j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(FillArray(m));
int[,] test = FillArray(m);

