//Задача 21

Console.WriteLine("Введите координаты первой точки");
Console.Write("Введите X: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите Z: ");
double z1 = double.Parse(Console.ReadLine());


Console.WriteLine("Введите координаты второй точки");
Console.Write("Введите X: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("Введите Z: ");
double z2 = double.Parse(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
Console.WriteLine($"Расстояние между точками {distance}");