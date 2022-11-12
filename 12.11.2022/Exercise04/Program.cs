// Программа, которая принимает на вход три числа и выдает максимальное из этих чисел
Console.WriteLine("Введите первое число: ");
int num01 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num02 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num03 = Convert.ToInt32(Console.ReadLine());
int max = num01;
if (num02 > max) max = num02;
if (num03 > max) max = num03;
Console.Write($"Максимальное число: {max}");

