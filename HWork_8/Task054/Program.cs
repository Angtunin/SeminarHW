// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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




void BableSortRow(int[,] array)
{
    int size = array.GetLength(0);
    int size1 = array.GetLength(1);
    int temp = 0, i = 0;
    while (i < size)
    {
        for (int j = 0; j < size1; j++)
        {
            for (int k = 0; k < size1 - 1 - j; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
        i++;
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

int[,] myArray = GetArray(m, n, min, max);
PrintArray(myArray);
Console.WriteLine();

BableSortRow(myArray);
PrintArray(myArray);