// Задача 29: Программа, которая задаёт массив из 8 элементов и выводит их на экран

int[] Array(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}
int[] newArray = Array(8);
var a = string.Join (", ", newArray);
Console.WriteLine($"[ {a} ]");

