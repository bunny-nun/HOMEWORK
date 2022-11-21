// Задача 27: Программа, которая принимает на вход число и выдаёт сумму цифр в числе
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Value(int a)
{
    int value = 0;
    while (a != 0)
    {
        value += a % 10;
        Console.Write(a % 10 + " ");
        a /= 10;
    }
    Console.WriteLine(" ");
    return value;
}
Console.WriteLine(Value(num));