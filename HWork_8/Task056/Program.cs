// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка;

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

int[,] SumRow(int[,] array)
{
    int[,] ResSumRow = new int[array.GetLength(0), 2];
    int countI = 1; 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        int SumRow = 0;
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            SumRow = SumRow + array[i, j];
            
        }
        ResSumRow[i, 0] = SumRow;
        ResSumRow[i, 1] = countI;
        countI++;
    }
    return ResSumRow;
}   

void minSumElement(int[,] array)
{
    int MinIndexI = 0;
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // MinIndexI = i;
        if (array[i, 0] < min)
        {
            min = array[i, 0];
            MinIndexI = i;
        } 
        
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {array[MinIndexI, 1]}"); 
    
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

int[,] newArray = SumRow(myArray);
// Console.WriteLine(String.Join(" ", newArray));
PrintArray(newArray);
Console.WriteLine();
minSumElement(newArray);
