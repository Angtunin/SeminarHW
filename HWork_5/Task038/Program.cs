// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] ArrayDouble(int size)
{
    double[] array = new double[size];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-100, 100) + rand.NextDouble();    
    }
    return array;    
}
double NumMaxArray(double[] array)
{
    double NumMax = 0;
    foreach (var el in array)
    {
        if (el > NumMax) NumMax = el;
    }
    return NumMax;
}

double NumMinArray(double[] array)
{
    double NumMin = 0;
    foreach (var el in array)
    {
        if (el < NumMin) NumMin = el;
    }
    return NumMin;
}

Console.Write("Введите размерность массива: ");
int Num = int.Parse(Console.ReadLine());
double[] myArray = ArrayDouble(Num);
Console.WriteLine(String.Join(" ", myArray));
Console.WriteLine($"{NumMaxArray(myArray) - NumMinArray(myArray)}");
