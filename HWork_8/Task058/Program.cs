// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// int[,] a = new int[,]
// {
//     {2, 4},
//     {3, 2},
// };
// int[,] b = new int[,]
// {
//     {3, 4},
//     {3, 3},
// };

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

int[,] ProductMatrix(int[,] arr1, int[,] arr2)
{
    int[,] res = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                res[i, k] = res[i, k] + arr1[i, j] * arr2[j, k];
            }
        }
    }
    return res;
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

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите минимальную границу диапазон: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите максимальную границу диапазон: ");
int max = int.Parse(Console.ReadLine());


int[,] Array1 = GetArray(m, n, min, max);
int[,] Array2 = GetArray(m, n, min, max);

PrintArray(Array1);
Console.WriteLine();
PrintArray(Array2);
Console.WriteLine();
int[,] Result = ProductMatrix(Array1, Array2);
PrintArray(Result);