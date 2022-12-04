/* Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int m = 4;
int n = 4;
int o = 3;
int[,,] newArray = new int[m, n, o];

bool Unique(int[,,] array, int element, int dimension0, int dimension1, int dimension2)
{
    bool isUnique = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (i == dimension0 && j == dimension1 && k == dimension2) continue;
                else if (array[i, j, k] == element)
                {
                    isUnique = false;
                    break;
                }
            }
        }
    }
    return isUnique;
}

int[,,] FillArray(int[,,] array01)
{
    for (int i = 0; i < array01.GetLength(0); i++)
    {
        for (int j = 0; j < array01.GetLength(1); j++)
        {
            for (int k = 0; k < array01.GetLength(2); k++)
            {
                array01[i, j, k] = new Random().Next(10, 100);
                while (!Unique(array01, array01[i, j, k], i, j, k))
                {
                    array01[i, j, k] = new Random().Next(10, 100);
                }
            }
        }
    }
    return array01;
}

void PrintArray(int[,,] array02)
{
    for (int i = 0; i < array02.GetLength(0); i++)
    {
        for (int j = 0; j < array02.GetLength(1); j++)
        {
            for (int k = 0; k < array02.GetLength(2); k++)
            {
                Console.Write($"{array02[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
PrintArray(FillArray(newArray));