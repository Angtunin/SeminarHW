﻿// Задача 13: Напишите программу, которая выводит третью цифру 
// (справа налево) заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

if (num < 0)
{
    num = -num;
}

if (num / 100 >= 1)
{
    Console.WriteLine($"{(num % 1000) / 100}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}