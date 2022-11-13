// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным
Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num > 7 || num < 1)
{
    Console.WriteLine("Введено неверное число. Введите цифру от 1 до 7, обозначающую день недели: ");
    num = Convert.ToInt32(Console.ReadLine());
}
if (num > 5) Console.Write("День является выходным");
else Console.Write("День не является выходным");
