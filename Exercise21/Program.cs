// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координату точки А на оси oX: ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки А на оси oY: ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки А на оси oZ: ");
int Az = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки B на оси oX: ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B на оси oY: ");
int By = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки B на оси oZ: ");
int Bz = Convert.ToInt32(Console.ReadLine());

double cathetus = Math.Round(Math.Sqrt(Math.Pow(Ax - Bx, 2) + Math.Pow(Az - Bz, 2)), 4);
double distance = Math.Round(Math.Sqrt(Math.Pow(cathetus, 2) + Math.Pow(Ay - By, 2)), 2);

Console.WriteLine($"Расстояние от точки А ({Ax}, {Ay}, {Az}) до точки B ({Bx}, {By}, {Bz}) равно {distance}");