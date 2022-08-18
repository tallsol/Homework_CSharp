// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату первой точки по оси X: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату первой точки по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату первой точки по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату второй точки по оси X: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату второй точки по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату второй точки по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));

Console.WriteLine($"Расстояние между точками: {Math.Round(result, 2)}");