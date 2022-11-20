// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs (num);
while (num < 100 || num > 999)
{
    Console.WriteLine("Введено неверное число. Введите трехзначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}
Console.Write($"Вторая цифра введенного числа: {(num % 100 - num % 10) / 10}"); //num % 100 / 10
