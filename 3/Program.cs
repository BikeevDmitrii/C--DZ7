// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int m, n;
Console.WriteLine("Введите количество строк (m):");
m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (n):");
n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

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
double summ = 0;
void SRA(int[,] array)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
          {
             
             summ = summ + array[i, j];
             //Console.WriteLine($"{summ};i = {i};  j = {j}");
            }       // Console.WriteLine();
             Console.Write($"{summ/m:F1}; ");
          summ=0;
     
        
    }
}


FillArrayRandom(array, -10, 10);
PrintArray(array);
SRA(array);