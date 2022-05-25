// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

void FillArrayRandom(Double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().NextDouble() * 10;
    }
}
void PrintArray(Double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],4:F1} ");
        Console.WriteLine();
    }
}
int m, n;
Console.WriteLine("Введите количество строк (m):");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n):");
n = int.Parse(Console.ReadLine());
Double[,] array = new Double[m, n];
FillArrayRandom(array);
PrintArray(array);
