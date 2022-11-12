// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num01 = 1;
while ( num01 <= num)
{
    if (num01%2 == 0) 
    {
        Console.Write(num01);
        Console.Write(" ");
    } 
    num01++;
}
