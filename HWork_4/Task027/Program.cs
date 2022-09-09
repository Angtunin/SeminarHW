// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Ndigits(int number)
{
    int count = 0;
    while (number != 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}

int SumDigits(int number)
{
    int result = 0;
    int NTen = 10;
    int Nx = 1;
    for (int i = 0; i < Ndigits(number); i++)
    {
        result = result + ((number % NTen) / Nx);
        NTen = NTen * 10;
        Nx = Nx * 10;
    }
    return result;
}

Console.Write("Введите число: ");
int numSum = int.Parse(Console.ReadLine());

Console.WriteLine($"{SumDigits(numSum)}");
