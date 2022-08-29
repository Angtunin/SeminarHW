// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите xa: ");
int xa = int.Parse(Console.ReadLine());
Console.Write("Введите ya: ");
int ya = int.Parse(Console.ReadLine());
Console.Write("Введите za: ");
int za = int.Parse(Console.ReadLine());
Console.Write("Введите xb: ");
int xb = int.Parse(Console.ReadLine());
Console.Write("Введите yb: ");
int yb = int.Parse(Console.ReadLine());
Console.Write("Введите zb: ");
int zb = int.Parse(Console.ReadLine());

double D = Math.Sqrt((xa - xb) * (xa - xb) + (ya - yb) * (ya - yb) + (za - zb) * (za - zb));
Console.WriteLine($"{D:f2}");