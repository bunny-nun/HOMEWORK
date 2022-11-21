// Задача 25: Цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.WriteLine("Введите первое число: ");
int num01 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num02 = Convert.ToInt32(Console.ReadLine());

double Pow(int a, int b)
{
    double index = a;
    if (b == 0) index = 1;
    else if (b > 0)
    {
        for (int mult = 2; mult <= b; mult++) index *= a;
    }
    else
    {
        for (int mult = 2; mult <= Math.Abs(b); mult++) index *= a;
        index = 1 / index;
    }
    return index;
}
double num03 = Pow(num01, num02);
Console.WriteLine($"Число {num01} в степени {num02} равно {num03}");
/*double num04 = Math.Pow(num01, num02);
Console.WriteLine($"Проверка: {num04}");*/
