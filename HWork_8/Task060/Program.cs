// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] NotRecurringNum(int m, int n, int c)
{
    int[] res = new int[m * n * c];
    res[0] = new Random().Next(10, 100);
    int i = 1;
    
    while (i < 8)
    {
        int find = new Random().Next(10, 100);
        if (res[i] == find)
        {
            for (int j = 0; j < res.Length - 1; j++)
            {
                continue;
            }
        }
        else
        {
            res[i] = find;
            i++;
        }
    }
    return res;   
}


int[,,] GetArray(int m, int n, int c, int[] array)
{
    int[,,] result = new int[m, n, c];
    int k = 0;
    while (k < array.Length)
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                for (int l = 0; l < result.GetLength(2); l++)
                {
                    result[i, j, l] = array[k];
                    k++; 
                }
                
            }
        }
        
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
    }

}

Console.Write("Введите число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число n: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число c: ");
int c = int.Parse(Console.ReadLine());

int[] myArray = NotRecurringNum(m, n, c);
Console.WriteLine(String.Join(" ", myArray));

int[,,] myArray1 = GetArray(m, n, c, myArray);
PrintArray(myArray1);

