/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.*/

/*
k1 * x + b1 = k2 * x + b2
x * (k1 - k2) = b2 - b1
x = (b2 - b1) / (k1 - k2)
y = k1 * ((b2 - b1) / (k1 - k2)) + b1
*/

Console.WriteLine("Введите значение углового коэффициента k1: ");
double k1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите значение свободного коэффициента b1: ");
double b1 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите значение углового коэффициента k2: ");
double k2 = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите значение свободного коэффициента b2: ");
double b2 = Convert.ToInt64(Console.ReadLine());

void Coordinates(double k1, double b1, double k2, double b2)
{
    if (k1 == k2 && b1 == b2) Console.WriteLine("Линии совпадают");
    else if (k1 == k2) Console.WriteLine("Линии не пересекаются");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Линии пересекаются в точке ({x}, {y})");
    }
}
Coordinates(k1, b1, k2, b2); 