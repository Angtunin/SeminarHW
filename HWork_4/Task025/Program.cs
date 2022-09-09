// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число A: ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int numB = int.Parse(Console.ReadLine());
int result = numA;

for (int i = 0; i < numB - 1; i++)
{
    result = result * numA;
}
Console.WriteLine($"{numA} в степени {numB} = {result}");
