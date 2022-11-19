// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите координаты первой точки x, y, z: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите координаты второй точки x, y, z: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());
double num = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
Console.WriteLine($"Расстояние между точками равно {num}");  