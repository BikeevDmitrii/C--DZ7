// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void FillArrayRandom(int [,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],2} ");
        Console.WriteLine();
    }
}

int m, n, i, j;
Console.WriteLine("Введите количество строк (m):");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n):");
n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];
FillArrayRandom(array, -9, 9);
PrintArray(array);
/*
Console.WriteLine("Введите номер строки:");
i = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца:");
j = int.Parse(Console.ReadLine());
*/
void Find(int x, int y)
{
    if (x <= n & y <= m)
    {
        Console.WriteLine("Число по заданному адресу  = "+ array[x, y]);
    }    
    else 
    {
    Console.WriteLine("Такого числа в массиве нет");
    }
}
Find(4,2);