// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника.

Console.WriteLine("Введите количество строк:");
int n = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int[][] FillArray(int height)
{
    int[][] newArray = new int[height][];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new int[i + 1];
        for (int j = 0; j < newArray[i].Length; j++)
        {
            if (j == 0 || j == newArray[i].Length - 1)
            {
                newArray[i][j] = 1;
            }
            else newArray[i][j] = (newArray[i - 1][j]) + (newArray[i - 1][j - 1]);
        }
    }
    return newArray;
}

void PrintArray(int[][] array02)
{
    for (int i = 0; i < array02.Length; i++)
    {
        int rowLength = ArrayLength(array02, i);
        int lastRowLength = ArrayLength(array02, (array02.Length - 1));
        int startPosition = ZeroPosition(rowLength, lastRowLength);
        if (i == (array02.Length - 1))
        {
            Console.SetCursorPosition(startPosition, i);
            for (int j = 0; j < array02[i].Length; j++)
            {
                Console.Write($"{array02[i][j]} ");
            }
        }
        else
        {
            rowLength = ArrayLength(array02, i + 1);
            startPosition = ZeroPosition(rowLength, lastRowLength);
            for (int j = 0; j < array02[i].Length; j++)
            {
                startPosition += ((ElementLength(array02, i + 1, j) + ElementLength(array02, i + 1, j + 1) + 2) / 2);
                Console.SetCursorPosition(startPosition, i);
                Console.Write($"{array02[i][j]} ");
            }
        }
        Console.WriteLine();
    }
}

int ZeroPosition(int rowLength, int lastRowLength)
{
    int coordinates = (100 + (lastRowLength - rowLength)) / 2;
    return coordinates;
}

int ArrayLength(int[][] array04, int index)
{
    int count = 0;
    for (int i = 0; i < array04[index].Length; i++)
    {
        for (int j = array04[index][i]; j > 0; j /= 10)
        {
            count++;
        }
    }
    count += array04[index].Length - 1;
    return count;
}

int ElementLength(int[][] array04, int index01, int index02)
{
    int count = 0;
    for (int i = array04[index01][index02]; i > 0; i /= 10)
    {
        count++;
    }
    return count;
}

PrintArray(FillArray(n));


