/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/


string Numbers(int num)
{
    if (num == 1) return Convert.ToString(num);
    return Convert.ToString(num) + " " + Numbers(num - 1);
}
string numbers = Numbers(8);

Console.WriteLine(numbers);