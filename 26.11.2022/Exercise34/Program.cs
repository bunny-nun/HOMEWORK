/*Задача 34: Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] CreateArray(int length)
{
    int[] numbers = new int[length];
    for (int n = 0; n < numbers.Length; n++)
    {
        numbers[n] = new Random().Next(100, 1000);
        Console.Write(numbers[n] + " ");
    }
    Console.WriteLine();
    return numbers;
}

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
int sum = 0;
for (int i = 0; i < length; i++)
{
    if ((array[i] % 2) == 0) sum++;
}
Console.WriteLine($"Количество четных чисел в массиве равно {sum}");
