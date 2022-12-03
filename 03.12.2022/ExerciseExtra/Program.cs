// Сгенерировать список из 20 элементов, удалить дубликаты

int length = 20;

int[] NewArray(int m) //создаем новый массив из псевдо-случайных чисел
{
    int[] newArray = new int[m];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(1, 10);
    }
    return newArray;
}

void PrintArray(int[] array01) // выводим массив в консоль
{
    for (int i = 0; i < array01.Length; i++)
    {
        Console.Write($"{array01[i]} ");
    }
    Console.WriteLine();
}

int[] newArray = NewArray(length);
PrintArray(newArray);

int[] DeleteDoubles(int[] initialArray, int checkElement) //локальная функция дальше будет зациклена
{
    int count = 0;
    for (int i = checkElement + 1; i < initialArray.Length; i++) //определяем длину нового массива
    {
        if (initialArray[i] == initialArray[checkElement]) count++;
    }
    int[] changeArray = new int[initialArray.Length - count];
    int newIndex = 0;
    for (int oldIndex = 0; oldIndex < initialArray.Length; oldIndex++)
    {
        if (oldIndex <= checkElement) //переписываем элементы до проверяемого
        {
            changeArray[newIndex] = initialArray[oldIndex];
            newIndex++;
        }
        else if (initialArray[oldIndex] == initialArray[checkElement]) continue;
        else
        {
            changeArray[newIndex] = initialArray[oldIndex]; //переписываем элемент в новый массив, если он не равен проверяемому
            newIndex++;
        }
    }
    return changeArray;
}
for (int n = 0; n < newArray.Length - 1; n++) //перезаписываем массив по ходу проверки каждого его последующего элемента
{
    newArray = DeleteDoubles(newArray, n);
}
PrintArray(newArray);