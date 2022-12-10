/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("Введите первое число: ");
int number01 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number02 = Convert.ToInt32(Console.ReadLine());

while (number01 == number02)
{
    Console.WriteLine("Числа не могут быть равны. Введите первое число: ");
    number01 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите второе число: ");
    number02 = Convert.ToInt32(Console.ReadLine());
}

int Summ(int num01, int num02)
{
    if (num02 == num01) return num01;
    return num02 + Summ(num01, num02 - 1);
}

int result;

if (number02 > number01)
{
    result = Summ(number01, number02);
    Console.WriteLine($"Сумма элементов в промежутке от {number01} до {number02} равна {result}");
}
else
{
    result = Summ(number02, number01);
    Console.WriteLine($"Сумма элементов в промежутке от {number02} до {number01} равна {result}");
}
