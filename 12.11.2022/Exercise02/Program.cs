// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число: ");
int num01 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num02 = Convert.ToInt32(Console.ReadLine());
if (num01 > num02) Console.Write($"Первое число {num01} больше, чем второе число {num02} ");
else Console.Write($"Второе число {num02} больше, чем первое число {num01} ");
