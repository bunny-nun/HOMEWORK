// Сгенерировать список из 20 элементов, удалить дубликаты

int length = 20;

int[] NewArray(int m)
{
    int[] newArray = new int[m];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(1, 10);
    }
    return newArray;
}

void PrintArray(int[] array01)
{
    for (int i = 0; i < array01.Length; i++)
    {
        Console.Write($"{array01[i]} ");
    }
    Console.WriteLine();
}

int[] newArray = NewArray(length);
PrintArray(newArray);

int[] DeleteDoubles(int[] array02, int checkElement)
{
    int count = 0;
    for (int i = checkElement + 1; i < array02.Length; i++)
    {
        if (array02[i] == array02[checkElement]) count++;
    }
    int[] changeArray = new int[array02.Length - count];
    int newIndex = 0;
    for (int oldIndex = 0; oldIndex < array02.Length; oldIndex++)
    {
        if (oldIndex <= checkElement)
        {
            changeArray[newIndex] = array02[oldIndex];
            newIndex++;
        }
        else if (array02[oldIndex] == array02[checkElement]) continue;
        else
        {
            changeArray[newIndex] = array02[oldIndex];
            newIndex++;
        }
    }
    return changeArray;
}
for (int n = 0; n < newArray.Length - 1; n++)
{
    newArray = DeleteDoubles(newArray, n);
}
PrintArray(newArray);