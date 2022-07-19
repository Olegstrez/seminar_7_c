/* Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int n = 3, m = 4, max = 100;

int[,] GetArray(int n, int m, int max)
{
    int[,] Array = new int[n, m];
    var rnd = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = rnd.Next(0, max);
        }
    }
    return Array;
}
void PrintArray(int[,] Array)
{

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"|");
            Console.Write($"{Array[i, j],3}");
        }
        Console.WriteLine();
    }
}
double[] ArithmeticArrayColumn(int[,] array)
{
    double  sum = 0;
    double[] ArithmeticArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        ArithmeticArray[j] = sum/array.GetLength(0);
        sum = 0;
    }
    return ArithmeticArray;
}
void PrintArithmeticArray(double[] Array)
{

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        Console.Write($"{Array[i]}" + "\t");
    }
}
int[,] Result = GetArray(n, m, max);
PrintArray(Result);
Console.WriteLine();
double[] ResultArithmet = (ArithmeticArrayColumn(Result));
PrintArithmeticArray(ResultArithmet);

