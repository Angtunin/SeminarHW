// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// void PlusNum(char[] arr, int Num)
// {
    
//     int plusN = 0;
//     int item = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (Convert.ToInt32(arr[i]) > 0)
//         {
//             plusN++;
//             item = item + arr[i];
//             Console.WriteLine(arr[i]);
//         } 

//     }
//     Console.WriteLine(plusN);
// }

// string InputN(int Num)
// {
//     // int M = int.Parse(Console.ReadLine());
//     int i = 0;
//     int count = 0;
//     string arr = String.Empty;
//     while (i < Num)
//     {
//         Console.Write($"Введите число {i + 1}: ");
//         int Dm = int.Parse(Console.ReadLine());
//         if (Dm > 0) count++;
//         arr = arr + Dm.ToString();
//         i++; 
//     }
//     return arr; count.ToString();

// }

Console.Write("Введите число M (количество чисел): ");

int M = int.Parse(Console.ReadLine());
int i = 0;
int count = 0;
string arr = String.Empty;
while (i < M)
{
    Console.Write($"Введите число {i + 1}: ");
    int Dm = int.Parse(Console.ReadLine());
    if (Dm > 0) count++;
    arr = arr + Dm.ToString() + " ";
    i++; 
}

Console.WriteLine($"[{String.Join(" ", arr.ToCharArray())}] количество положительных чисел {count}");

// var result = InputN(M);
// Console.WriteLine(result);
// char[] myArray = result.ToArray();


// PlusNum(myArray, M);
// char[] myArray = arr.ToCharArray();

// Console.WriteLine($"количество чётных чисел = {String.Join(" ", PlusNum(myArray))}");

