/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

int[] CreateArray(int length)
{
    int[] numbers = new int[length];
    for (int n = 0; n < numbers.Length; n++)
    {
        numbers[n] = new Random().Next(0, 100);
        Console.Write(numbers[n] + " ");
    }
    Console.WriteLine();
    return numbers;
}

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(length);
int sum = 0;
for (int i = 1; i < length; i += 2)
{
    sum += array[i];
}
Console.WriteLine($"Cумму элементов, стоящих на нечетных позициях {sum}");
