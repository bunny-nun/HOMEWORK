/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


int[] ConvertToArray(string? input) // Конвертация string в int[]
{
    int[] numbers = input.Split(' ', '.', ',').Select(Int32.Parse).ToArray();
    return numbers;
}

Console.WriteLine("Введите числа: ");
string? inputNumbers = Console.ReadLine();

/*
int[] CreateArray()
{
    Console.WriteLine("Введите количество чисел: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] newArray = new int[num];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
*/

int[] array = ConvertToArray(inputNumbers);

int Count(int[] anyArray)
{
    int count = 0;
    for (int i = 0; i < anyArray.Length; i++)
    {
        Console.Write(anyArray[i] + " ");
        if (anyArray[i] > 0) count++;
    }
    Console.WriteLine();
    return count;
}
Console.WriteLine($"Вы ввели {Count(array)} чисел больше 0");