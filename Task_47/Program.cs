/* Задача 47. Задайте двумерный массив размером m×n,
 заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */

int n = 3, m = 4, max = 100;

double [,] GetArray(int n, int m, int max)
{
    double [,] Array = new double [n, m];
    var rnd = new Random();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = Math.Round(rnd.NextDouble()*max,3);
        }
    }
    return Array;
}
void PrintArray(double [,] Array)
{
   
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"|");
            Console.Write($"{Array[i, j],3}"+"\t");
        }
        Console.WriteLine();
    }
}
double [,] result = GetArray( n,  m,  max);
PrintArray (result );
