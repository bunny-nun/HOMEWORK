// Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 10000 || num > 99999)
{
    Console.WriteLine("Введено неверное число. Введите пятизначное число: ");
    num = Convert.ToInt32(Console.ReadLine());
}
void newArray(int[] numbers)
{
    int n = 1;
    int index = 0;
    int length = numbers.Length;
    while (index < length)
    {
        numbers[index] = num % (n * 10) / n;
        Console.Write(numbers[index] + " ");
        n = n * 10;
        index++;
    }
}

int lengthDef(int numLength)
{

    int y = 0;
    while (numLength > 0)
    {
        numLength = numLength / 10;
        y++;
    }
    return y;
}
int def = lengthDef(num);
Console.WriteLine(def);
int[] array = new int[def];
newArray(array);
Console.WriteLine();
int g1 = 0;
int g2 = def - 1;
while (g1 < g2)
{
    if (array[g1] != array[g2])
    {
        Console.WriteLine($"Число {num} не является палиндромом");
        break;
    }
    else
    {
        g1++;
        g2--;
    }
}
if (g1 == g2 || g1 > g2) Console.WriteLine($"Число {num} является палиндромом");
