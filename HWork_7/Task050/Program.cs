// Задача 50. Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] GetArray(int m, int n, int mimValut, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(mimValut, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }

}

int СheckNum(int[,] array, int Num)
{
    int Fnum = 0;
    int Find = 0;
    int size1 = array.GetLength(0);
    int size2 = array.GetLength(1);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (Num == array[i, j])
            {
                Find = array[i, j];
                Console.Write($"Индексы элемента {Num}:(i)={i}, (j)={j}");
                return Find;
            }
            else Fnum++;
        }
    }
    

    if (Fnum == array.GetLength(0) * array.GetLength(1))
    {
        Console.Write($"{Num} - такого числа в массиве нет");
    }
    return Find;
}    

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите минимальную границу диапазон: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальную границу диапазон: ");
int max = int.Parse(Console.ReadLine());
Console.Write("Введите число для проверки: ");
int k = int.Parse(Console.ReadLine());

int[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);
Console.WriteLine();
СheckNum(myArray, k);
