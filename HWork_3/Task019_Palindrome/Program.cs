﻿// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if ((num / 10000) == (num % 10) & ((num / 1000) % 10 == ((num % 100) / 10)))
{
    Console.Write("да");
}
else
{
    Console.Write("нет");    
}