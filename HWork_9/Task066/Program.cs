// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumber(int m, int n)
{
    
    if (m == n)
    {
        return m;
    }
    return m + SumNumber(m + 1, n);
}

Console.Write("Введите число m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumNumber(numberM, numberN));
