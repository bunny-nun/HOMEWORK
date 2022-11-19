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
    while (index < 5)
    {
        numbers[index] = num % (n * 10) / n;
        Console.Write(numbers[index] + " ");
        n = n * 10;
        index++;
    }
}
int[] array = new int[5];
newArray(array);
Console.WriteLine();
if (array[0] == array[4] && array[1] == array[3])
{
    Console.WriteLine($"Число {num} является палиндромом");
}
else
{
    Console.WriteLine($"Число {num} не является палиндромом");
}