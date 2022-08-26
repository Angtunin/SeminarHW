// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.Write("Введите цифру дня недели: ");
int number_week = int.Parse(Console.ReadLine());

if (0 < number_week && number_week < 8)
{
    if (number_week == 6 || number_week == 7) Console.WriteLine("да");
    else
    {
        Console.WriteLine("нет");
    } 
}
else
{
    Console.WriteLine("Введён не правильный день недели");    
}