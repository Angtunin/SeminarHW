// Задача 29: Напишите программу, которая задаёт массив из N элементов, заполненных случайнми числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]
// 3, 1, 35 -> [6, 1, 33]

int [] ArrayRandom(int Num, int A, int B)
{
    int[] array = new int[Num];
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(A, B);
       
    }
    return array;
}

Console.Write("Введите длину массива Num: ");
int Num = int.Parse(Console.ReadLine());

Console.Write("Введите начало диапазона массива A: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите разрядность массива B: ");
int B = int.Parse(Console.ReadLine());

Console.WriteLine(String.Join(", ", ArrayRandom(Num, A, B)));
