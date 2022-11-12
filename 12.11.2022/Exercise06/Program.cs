// Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num%2 == 0) Console.WriteLine($"Число {num} является четным");
else Console.WriteLine($"Число {num} является нечетным");
