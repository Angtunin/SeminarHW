// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] InputNum(int K, int B)
{
    double[,] matrix = new double[K, B];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                Console.Write($"Введите коэф b{j + 1}: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            } 
            else
            {
                Console.Write($"Введите коэф k{j + 1}: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            } 
        }    
    }
    return matrix;
}

void Equation(double[,] array)
{
    double[] res = new double[2];
    res[0] = (array[0, 1] - array[0, 0]) / (array[1, 0] - array[1, 1]);
    res[1] = array[1, 0] * res[0] + array[0, 0];
    Console.WriteLine($"Точка пересечения: ({res[0]}, {res[1]})");
}

double[,] myArray = InputNum(2, 2);
void printArray(double[,] arr)
{
   for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }    
}
printArray(myArray);
Equation(myArray);
