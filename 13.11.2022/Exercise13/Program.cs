// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100) Console.WriteLine("Третьей цифры нет");
else
{
    while (num > 999) num = num / 10;
    num = num % 10;
    Console.Write($"Третья цифра введенного числа: {num}");
}

