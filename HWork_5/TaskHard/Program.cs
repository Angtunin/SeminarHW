// Написать метод сортировки массива "пузырьковый" способом,
// реализовать невозрастающую сортировку.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] BableSort(int[] array)
{
    int size = array.Length;
    int temp = 0;
    for (int i = 0; i < size; i++)
    {
        
        for (int k = 0; k < size - 1 - i; k++)
        {
            if (array[k] > array[k + 1])
            {
                temp = array[k + 1];
                array[k + 1] = array[k];
                array[k] = temp;
            }
        }
    }
    return array; 
}

int[] myArray = GetArray(10, -10, 10);

Console.WriteLine(String.Join(" ", myArray));
int[] Result = BableSort(myArray);
Console.WriteLine(String.Join(" ", Result));