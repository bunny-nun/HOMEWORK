// Программа, которая принимает на вход любое число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 0)
{
    Console.WriteLine("Введено неверное число. Введите пятизначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}

//while (num < 10000 || num > 99999)
//{
//    Console.WriteLine("Введено неверное число. Введите пятизначное число: ");
//    num = Convert.ToInt32(Console.ReadLine());
//}

string newNumber(int number)
{
    string number01 = System.String.Empty;
    while (number > 0)
    {
        number01 = number01 + (number % 10);
        number = number / 10;
    }
    return number01;
}
int compNumber = Convert.ToInt32(newNumber(num));
Console.WriteLine(compNumber);
if (compNumber != num)
{
    Console.WriteLine($"Число {num} не является палиндромом");
}
else
{
    Console.WriteLine($"Число {num} является палиндромом");
}
