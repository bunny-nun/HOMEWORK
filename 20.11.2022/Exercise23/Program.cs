// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());

void square(double[] numbers)
{
    int index = 0;
    int num = 1;
    int length = numbers.Length;
    while (num <= length)
    {
        numbers[index] = Math.Pow(num, 3);
        Console.Write(numbers[index] + " ");
        index++;
        num++;
    }
}
double[] array = new double[n];
square(array);