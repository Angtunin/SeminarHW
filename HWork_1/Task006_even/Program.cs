// Задача 6: Напишите программу, которая на вход принимает число и 
// выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int number_a = int.Parse(Console.ReadLine());
int result = number_a % 2;
if (result == 0)
{
    Console.Write("Число чётное");
}
else
{
    Console.Write("Число чётное");    
}
